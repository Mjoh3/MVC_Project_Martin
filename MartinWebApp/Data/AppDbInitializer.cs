using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MartinWebApp.Models;
using Microsoft.AspNetCore.Identity;
using MartinWebApp.Static;

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
                if (!context.Languages.Any())
                {
                    context.Languages.AddRange(new List<Language>()
                    {
                        new Language()
                        {

                            Name = "Swedish"
                        },
                        new Language()
                        {

                            Name = "English"
                        },
                        new Language()
                        {

                            Name = "Spanish"
                        },
                    });
                    context.SaveChanges();

                }
                if (!context.Personas_Languages.Any())
                {
                    context.Personas_Languages.AddRange(new List<Persona_Language>()
                    {
                        new Persona_Language()
                        {
                            PersonaId=1,
                            LanguageId=1
                        },
                        new Persona_Language()
                        {
                            PersonaId=1,
                            LanguageId=2
                        },
                        new Persona_Language()
                        {
                            PersonaId=2,
                            LanguageId=2
                        },
                        new Persona_Language()
                        {
                            PersonaId=3,
                            LanguageId=2
                        },
                        new Persona_Language()
                        {
                            PersonaId=2,
                            LanguageId=3
                        },

                    });
                    context.SaveChanges();

                }

            }
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope= applicationBuilder.ApplicationServices.CreateScope())
            {
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                if(!await roleManager.RoleExistsAsync(UserRoles.Admin))
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                }
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
                }


                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@MartinWebApp.com";
                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FirstName = "App",
                        LastName = "User",
                        Birthday= new DateTime(2000, 10, 10),
                        UserName = adminUserEmail,
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "##Password1111");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@MartinWebApp.com";
                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FirstName = "App",
                        LastName="User",
                        Birthday = new DateTime(2001, 11, 11),
                        UserName = appUserEmail,
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "##Password1111");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
            
        } 
    } 
}
