using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Gym_.Models;
using Gym_.Data;

namespace Gym_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDBContext _db;

        public HomeController(ILogger<HomeController> logger, AppDBContext appDbContext)
        {
            _logger = logger;
            _db = appDbContext;
        }
        public IActionResult Index() 
        { return View(); }
        public IActionResult Reserve()
        {

            return View();
        }
      

      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }


        [HttpPost]
        public IActionResult GetAllTypes()
        {
            var types = _db.Subscriptions.Select(x => new
            {
                id = x.Id,
                name = x.Name
            }).ToList();
            return Json(new { data = types });
        }


        [HttpPost]
        public IActionResult GetPrice(int duration, int subscriptionId)
        {
            var types = _db.Subscriptions.Find(subscriptionId);
            var subscriptionPrice = types.Price * duration;
            return Json(new { data = subscriptionPrice });
        }
    }
}
