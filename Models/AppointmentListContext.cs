using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectOne.Models
{
    public class AppointmentListContext : DbContext
    {
        public AppointmentListContext(DbContextOptions<AppointmentListContext> options) : base (options)
        { }

        public DbSet<Appointment> Appointments { get; set; }
    }
}
