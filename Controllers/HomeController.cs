using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private FormContext _context { get; set; }

        /*public HomeController(ILogger<HomeController> logger, FormContext context)
        {
            _logger = logger;
            _context = context;

        }*/

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Confirm()
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult SignUp(TimePeriod time)
        {
            return View("Form", time);
        }*/

        /*[HttpPost]
        public IActionResult Form(Appointment appt)
        {
            if (ModelState.IsValid)
            {
                //Update and save database
                _context.Appointments.Add(appt);
                _context.SaveChanges();

                return View("Index");
            }

            return View();
        }*/

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
