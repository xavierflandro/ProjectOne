using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Models.ViewModels
{
    public class AppointmentViewModel
    {
        public TimeSlot Time { get; set; }

        public Appointment Appointment { get; set; }
    }
}
