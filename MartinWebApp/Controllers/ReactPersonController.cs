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


        [HttpPost]
        public IActionResult AddPerson(string name, string phonenumber, string cities)
        {

            if (name.Length > 1 && phonenumber.Length > 1)
            {
                var newperson = new Persona()
                {
                    Name = name,
                    PhoneNumber = phonenumber,
                    CityId = int.Parse(cities)
                };
                _context.People.Add(newperson);
                _context.SaveChanges();
                //return StatusCode(200);
                return Json(newperson);
            }
            else
            {

                return StatusCode(404);
            }
        }
        [HttpPost]
        public IActionResult DeletePersona(string id)
        {
            
            var persona = new Persona() { Id = int.Parse(id) };
            if (!(_context.People.Any(p => p.Id == int.Parse(id))))
            {
                
                return StatusCode(404);
            }
            else
            {
                _context.Personas_Languages.RemoveRange(_context.Personas_Languages.Where(x => x.PersonaId == int.Parse(id)));
                _context.People.Attach(persona);
                _context.People.Remove(persona);
                
                _context.SaveChanges();
                return StatusCode(200);
            }
            


            
        }
    }
}
