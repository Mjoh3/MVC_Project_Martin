using MartinWebApp.Data;
using MartinWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MartinWebApp.Controllers
{
    public class ReactPersonController : Controller
    {
        private readonly AppDbContext _context;

        public ReactPersonController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Test()
        {

            return View();
        }
        [HttpGet]
        public JsonResult GetAllPeople() {
            var peoplelist = _context.People.ToList();
            
            var json = JsonConvert.SerializeObject(peoplelist);
            return Json(json);
        }
        [HttpGet]
        public JsonResult GetAllCities()
        {
            var citylist = _context.Cities.ToList();

            var json = JsonConvert.SerializeObject(citylist);
            return Json(json);
        }
        [HttpGet]
        public JsonResult GetAllLanguages()
        {
            var languagelist = _context.Languages.ToList();

            var json = JsonConvert.SerializeObject(languagelist);
            return Json(json);
        }
        [HttpGet]
        public JsonResult GetAllCountries()
        {
            var countrylist = _context.Countries.ToList();
            
            var json = JsonConvert.SerializeObject(countrylist);
            return Json(json);
        }
        [HttpGet]
        public JsonResult GetAllPersona_Languages()
        {
            var planguagelist = _context.Personas_Languages.ToList();
            
            var json = JsonConvert.SerializeObject(planguagelist);
            return Json(json);
        }

        [HttpGet]
        public JsonResult DBToJSON()
        {
            DbViewModel vm = new DbViewModel();
            vm.Cities = _context.Cities.ToList();
            vm.Countries = _context.Countries.ToList();
            vm.Languages = _context.Languages.ToList();
            vm.Personas = _context.People.ToList();
            vm.Persona_Languages.ToList();
            for (int i=0; i<vm.Personas.Count(); i++)
            {
                vm.Personas.ElementAt(i).City = vm.Cities.First(x => x.Id == vm.Personas.ElementAt(i).CityId);
                vm.Personas.ElementAt(i).City.Country = vm.Countries.First(x => x.Id == vm.Personas.ElementAt(i).City.CountryId);
                vm.Personas.ElementAt(i).Persona_Language = vm.Persona_Languages.Where(x => x.PersonaId == vm.Personas.ElementAt(i).Id);
                for (int j=0; j<vm.Personas.Count(); j++)
                {
                    vm.Personas.ElementAt(i).Persona_Language.ElementAt(j).Language =
                        vm.Languages.First(x => x.Id == vm.Personas.ElementAt(i).Persona_Language.ElementAt(j).LanguageId);
                }
                
            }
            var json = JsonConvert.SerializeObject(vm);
            return Json(json);
        }
        


        [HttpPost]
        public JsonResult AddPersona(string name, string phonenumber, string cities)
        {
            _context.People.Add(new Persona()
            {
                Name = name,
                PhoneNumber = phonenumber,
                CityId = int.Parse(cities)
            });
            _context.SaveChanges();

            return Json("true");
        }
    }
}
