using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectOne.Models
{
    //to show possible/available time slots
    public class TimeSlot
    {
        [Key]
        public int TimeId { get; set; }
        public string? DayOfWeek { get; set; }
        public int? Time { get; set; }

    }
}
