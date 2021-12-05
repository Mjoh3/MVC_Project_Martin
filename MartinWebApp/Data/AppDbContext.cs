//using MartinWebApp.Models.db_models;

using MartinWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Persona>()
                 .HasOne(pe => pe.City)
                 .WithMany(ci => ci.Inhabitants)
                 .HasForeignKey(pe => pe.CityId);

            modelBuilder.Entity<City>()
                .HasOne(ci => ci.Country)
                .WithMany(co => co.Cities)
                .HasForeignKey(ci => ci.CountryId);
          

        }
        public DbSet<Persona> People { get; set; }
       
        public DbSet <City> Cities { get; set; }
        public DbSet <Country> Countries { get; set; }
        
    }

}
