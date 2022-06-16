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
using Microsoft.AspNetCore.Mvc.Filters;

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


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var college = dbContext.schools
                                .FirstOrDefault(s => s.id == id);
            if (college == null)
            {
                return RedirectToAction("Index");
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
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(School school)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbContext.Add(school);
                    dbContext.SaveChanges();
                    return RedirectToAction("Details", new {id = school.id});
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
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var college = dbContext.schools
                                .FirstOrDefault(s => s.id == id);
            if (college == null)
            {
                return RedirectToAction("Index");
            }
            return View(college);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, School school)
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
                    dbContext.SaveChanges();
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
        [HttpPost]
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var school = dbContext.schools
                .AsNoTracking()
                .FirstOrDefault(s => s.id == id);
            if (school == null)
            {
                return NotFound();
            }

            string result;
            try
            {
                School data = dbContext.schools.FirstOrDefault(s => s.id == id);
                dbContext.schools.Remove(data);
                var res = dbContext.SaveChanges();
                if (res == 1)
                {
                    result = "Deleted Successfully";               
                }
                else
                {
                    result = "Delete Failed";
                }

            }
            catch (Exception ex)
            {
                result = ex.Message;

            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            //TempData["message"] = result;
            //FlashMessage.Warning("Your error message");
            return RedirectToAction("Index", "Home");
        }
    }
}