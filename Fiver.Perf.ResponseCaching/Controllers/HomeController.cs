using System;
using Microsoft.AspNetCore.Mvc;
using Fiver.Perf.ResponseCaching.Models.Home;

namespace Fiver.Perf.ResponseCaching.Controllers
{
    //[ResponseCache(Duration = 60)]
    [ResponseCache(CacheProfileName = "default")]
    public class HomeController : Controller
    {   
        public IActionResult Index()
        {
            return View(new HomeOutputModel
            {
                LastUpdated = DateTime.Now
            });
        }
    }
}
