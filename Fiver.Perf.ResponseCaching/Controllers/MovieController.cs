using System;
using Microsoft.AspNetCore.Mvc;
using Fiver.Perf.ResponseCaching.Models.Movie;

namespace Fiver.Perf.ResponseCaching.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View(new MovieOutputModel
            {
                LastUpdated = DateTime.Now
            });
        }
    }
}
