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


                if (!context.People.Any())
                {
                    context.People.AddRange(new List<Persona>()
                    {
                        new Persona()
                        {
                            Name = "Juan",
                            Countryname = "Mexico",
                            Languagename="Spanish",
                            Cityname="Hermosillo",
                            PhoneNumber="02020202"

                        },
                        new Persona()
                        {
                            Name = "Cici",
                            Countryname = "Romania",
                            Languagename="Romanian",
                            Cityname="Sebes",
                            PhoneNumber="04060202"

                        },
                        new Persona()
                        {
                            Name = "Ulrich",
                            Countryname = "Germany",
                            Languagename="German",
                            Cityname="Hannover",
                            PhoneNumber="05065502"

                        }

                    });
                    context.SaveChanges();
                }
                
            }
        }
    } 
}
