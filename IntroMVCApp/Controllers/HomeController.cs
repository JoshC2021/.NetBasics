using IntroMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IntroMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //This line is call to the view engine to return the view 
            //that matches the action's Name
            return View();
        }

        public IActionResult Duck()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Calculator()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

        //These parameters MUST match the names on the form inputs
        //public IActionResult Result(int num1, int num2, string operation)
        public IActionResult Result(Result r)
        {
            int result;
            if(r.operation == "+")
            {
                result = r.num1 + r.num2;
            }
            else if(r.operation == "-")
            {
                result = r.num1 - r.num2;
            }
            else if(r.operation == "*")
            {
                result = r.num1 * r.num2;
            }
            else
            {
                result = r.num1 / r.num2;
            }
            r.output = result;
            return View(r);
        }

        public IActionResult LogResult(LogResult r)
        {
            return View(r);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
