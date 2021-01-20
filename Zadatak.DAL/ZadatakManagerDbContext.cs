using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Zadatak.Model;

namespace Zadatak.DAL
{
    public class ZadatakManagerDbContext : DbContext
    {
        protected ZadatakManagerDbContext()
        {

        }

        public ZadatakManagerDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().HasData(new Person
            {
                ID = 1,
                FirstName = "Pero",
                LastName = "Peric",
                CityName = "Zagreb",
                PostalCode = "10000",
                MobileNumber = "38511151816"
            });


        }
    }
}
//dotnet ef migrations add Initial --startup-project Zadatak.Web --context ZadatakManagerDbContext --project Zadatak.DAL

//dotnet ef database update Initial --startup-project Zadatak.Web --context ZadatakManagerDbContext --project Zadatak.DAL