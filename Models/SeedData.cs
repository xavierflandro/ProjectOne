using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            AppointmentListContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<AppointmentListContext>();

            //Run pending migrations
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            //Populate the database with given seed data & additional data
            if (!context.Appointments.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthFirstName = "Victor",
                        AuthLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = 9780451419439,
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        NumPages = 1488

                    }
                    }
                    ) ;
            context.SaveChanges();
        }
    }

}
