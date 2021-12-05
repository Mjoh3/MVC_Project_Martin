using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MartinWebApp.Models;
namespace MartinWebApp.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();


                if (!context.Countries.Any())
                {
                    context.Countries.AddRange(new List<Country>()
                    {
                        new Country()
                        {
                            
                            Name = "Sweden"
                        },
                        new Country()
                        {
                            Name = "United Kingdom"
                        },
                        new Country()
                        {
                            
                            Name = "Spain"
                        }
                    }); ;
                    context.SaveChanges();
                }

                if (!context.Cities.Any())
                {
                    context.Cities.AddRange(new List<City>()
                    {
                        new City()
                        {
                            
                            Name = "Stockholm",
                            CountryId=1
                        },
                        new City()
                        {
                            
                            Name = "Malmö",
                            CountryId=1
                        },
                        new City()
                        {
                            
                            Name = "Liverpool",
                            CountryId=2
                        },
                        new City()
                        {
                            
                            Name = "Birmingham",
                            CountryId=2
                        },
                        new City()
                        {
                            
                            Name = "Malaga,", 
                            CountryId=3
                        }
                    }); 
                    context.SaveChanges();
                }
                if (!context.People.Any())
                {
                    context.People.AddRange(new List<Persona>()
                    {
                        new Persona()
                        {
                            
                            Name = "Lennart",
                            PhoneNumber="080111183",
                            CityId=1
                        },
                        new Persona()
                        {
                            
                            Name = "Hannah",
                            PhoneNumber="034441185",
                            CityId=4
                        },
                        new Persona()
                        {
                            
                            Name = "Maria",
                            PhoneNumber="055590902",
                            CityId=5
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    } 
}
