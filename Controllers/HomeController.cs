using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectOne.Models;
using ProjectOne.Models.ViewModels;
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
        private AppointmentListContext _context { get; set; }

        //set private context object in constructor to be used throughout controller 
        public HomeController(ILogger<HomeController> logger, AppointmentListContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Appointments()
        {
            return View(_context);
        }

        public IActionResult SignUp()
        {
            return View(_context);
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(string slotDay, string slotTime)
        {
            //create new appointment object and set the datetime attribute using the strings from previous form
            var appt = new Appointment
            {
                Datetime = slotDay + " " + slotTime + ":00"
            };
            return View(appt);
        }

        [HttpPost]
        public IActionResult Confirm(Appointment appt)
        {
            if (ModelState.IsValid)
            {
                //update timeslot availability 
                foreach(var t in _context.TimeSlots)
                {
                    if(t.DayOfWeek + " " + t.Time + ":00" == appt.Datetime)
                    {
                        t.Available = false;
                    }
                }

                //Update and save appt
                _context.Appointments.Add(appt);
                _context.SaveChanges();

                //Route back to home
                return View("Index");
            }

            return View();
        }


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
