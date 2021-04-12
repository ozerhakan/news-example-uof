using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DYG.Core;
using DYG.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DYG.UI.Models;

namespace DYG.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewsServices _newsServices;

        public HomeController(INewsServices newsServices, ILogger<HomeController> logger)
        {
            _logger = logger;
            _newsServices = newsServices;
        }

        public IActionResult Index()
        {
            News data = new News()
            {
                Title = "Denemes",
                Spot = "Spots",
                PublishedTime = DateTime.Now
            };
            _newsServices.CreateNews(data);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}