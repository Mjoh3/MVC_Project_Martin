//using MartinWebApp.Models.db_models;

using MartinWebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
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
            modelBuilder.Entity<Persona_Language>().HasKey(pl => new
            {
                pl.PersonaId,
                pl.LanguageId
            });

            modelBuilder.Entity<Persona_Language>().HasOne(p => p.Language).WithMany(pl => pl.Persona_Language).HasForeignKey(p => p.LanguageId);
            modelBuilder.Entity<Persona_Language>().HasOne(l => l.Persona).WithMany(pl => pl.Persona_Language).HasForeignKey(l => l.PersonaId);

            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Persona> People { get; set; }

        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Language> Languages { get; set; }

        public DbSet<Persona_Language> Personas_Languages{get; set;}

        
    }

}
