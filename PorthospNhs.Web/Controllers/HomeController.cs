using PorthospNhs.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace PorthospNhs.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<PatientViewModel> patients = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51074/api/");                
                var responseTask = client.GetAsync("patients");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<PatientViewModel>>();
                    readTask.Wait();

                    patients = readTask.Result;
                }
                else
                {
                    patients = Enumerable.Empty<PatientViewModel>();
                }
            }

            return View(patients);
        }
    }
}