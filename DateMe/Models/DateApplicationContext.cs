using System;
using Microsoft.EntityFrameworkCore;

namespace DateMe.Models
{
    public class DateApplicationContext: DbContext
    {
        // constructor
        public DateApplicationContext (DbContextOptions<DateApplicationContext> options): base(options)
        {
            //Leave blank now
        }

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    ApplicationID = 1,
                    FirstName = "Michael",
                    LastName = "Scott",
                    Age = 35,
                    Phone = "555-123-4567",
                    Major="Sales",
                    CreeperStalker = false
                },

                new ApplicationResponse
                {
                    ApplicationID = 2,
                    FirstName = "Creed",
                    LastName = "Bratton",
                    Age = 30,
                    Phone = "123-456-7890",
                    Major = "Undeclared",
                    CreeperStalker = true
                }
            );
        }
    }
}
