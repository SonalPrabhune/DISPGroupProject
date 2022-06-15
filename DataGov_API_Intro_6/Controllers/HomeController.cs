using Project_College_Scorecard.Models;
using Microsoft.AspNetCore.Mvc;
using Project_College_Scorecard.DataAccess;
using System.Diagnostics;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
//using System.Web.Mvc;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace Project_College_Scorecard.Controllers
{
    public class HomeController : Controller
    {
        HttpClient httpClient;

        static string BASE_URL = "https://api.data.gov/ed/collegescorecard/v1";
        static string API_KEY = "oA32eJnmauMrYQv83qjlgGQcMvxQfpTnW3ZtpdXU"; //Add your API key here inside ""

        public ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public async Task<IActionResult> Index()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string NATIONAL_COLLEGE_API_PATH = BASE_URL + "/schools?school.state=FL&api_key=";
            string collegesData = "";

            AllColleges colleges = null;
            School schools = null;

            httpClient.BaseAddress = new Uri(NATIONAL_COLLEGE_API_PATH);

            if (!dbContext.schools.Any())
            {
                try
                {
                    HttpResponseMessage response = httpClient.GetAsync(NATIONAL_COLLEGE_API_PATH)
                                                            .GetAwaiter().GetResult();

                    if (response.IsSuccessStatusCode)
                    {
                        collegesData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    }

                    if (!collegesData.Equals(""))
                    {
                        // JsonConvert is part of the NewtonSoft.Json Nuget package
                        colleges = JsonConvert.DeserializeObject<AllColleges>(collegesData);
                    }

                    dbContext.allColleges.Add(colleges);
                    await dbContext.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    // This is a useful place to insert a breakpoint and observe the error message
                    Console.WriteLine(e.Message);
                }
            }    
            var allCollegeData = dbContext.schools.ToList();
            ViewData["School"] = allCollegeData;
            return View(schools);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var college = await dbContext.schools
                                .FirstOrDefaultAsync(s => s.id == id);
            if (college == null)
            {
                return NotFound();
            }
            return View(college);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        //CRUD
        //Create
        [System.Web.Mvc.HttpPost]
        public async Task<IActionResult> Create(
        [Bind("zip,city,name,state,tuition_revenue_per_fte,instructional_expenditure_per_fte")] School school)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbContext.Add(school);
                    await dbContext.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(school);
        }

        //Update
        public async Task<IActionResult> Edit(int id, 
            [Bind("zip,city,name,state,tuition_revenue_per_fte,instructional_expenditure_per_fte")] School school)
        {
            if (id != school.id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    dbContext.Update(school);
                    await dbContext.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
            }
            return View(school);
        }

        //Delete
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var school = await dbContext.schools
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.id == id);
            if (school == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(school);


            //Response<string> result = new Response<string>();
            //try
            //{
            //    User data = _dbContext.Users.FirstOrDefault(u => u.Id == id);
            //    _dbContext.Users.Remove(data);
            //    var res = _dbContext.SaveChanges();
            //    if (res == 1)
            //    {
            //        result.message = "Success";
            //    }
            //    else
            //    {
            //        result.message = "Failed";
            //    }

            //}
            //catch (Exception ex)
            //{
            //    result.message = ex.Message;

            //}
            //return result;
        }
    }
}