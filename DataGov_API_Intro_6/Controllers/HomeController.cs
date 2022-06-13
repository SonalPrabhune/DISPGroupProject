using Project_College_Scorecard.Models;
using Microsoft.AspNetCore.Mvc;
using Project_College_Scorecard.DataAccess;
using System.Diagnostics;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

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

            httpClient.BaseAddress = new Uri(NATIONAL_COLLEGE_API_PATH);

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

            return View(colleges);
        }
    }
}