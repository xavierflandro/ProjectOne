using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectOne.Models
{
    public class AppointmentItem
    {
        [Key]
        [Required]
        public int ApptId { get; set; }

        //user required info
        [Required]
        public string GroupName { get; set; }
        [Required]
        public int GroupSize { get; set; }
        [Required]
        public string Email { get; set; }

        //optional info
        public int PhoneNumber { get; set; }
    }
}
