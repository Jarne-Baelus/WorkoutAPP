using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using project.Models;
using Contentful.Core;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IContentfulClient _client;


        public HomeController(ILogger<HomeController> logger, IContentfulClient client)
        {
            _client = client;
            _logger = logger;
        }
        
        
        public async Task<IActionResult> Index()
        {
            var Workouts = await _client.GetEntries<Workouts>();
            return View(Workouts);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Workouts()
        {
            var Workouts = await _client.GetEntries<Workouts>();
            return View(Workouts);
        }
        
        
        [HttpPost]
        public async Task<IActionResult> Index(int days, int time)
        {
            var Workouts = await _client.GetEntries<Workouts>();
            GeneratedW program = new GeneratedW(days,time);
            Console.WriteLine(program.Amountofdays);
            Console.WriteLine(time);
            ViewBag.program = program;
            return View("Workout",Workouts);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
