using MartinWebApp.Data;
using MartinWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Controllers
{
    
    public class PeopleController : Controller
    {
        private readonly AppDbContext _context;

        public PeopleController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            DbViewModel vm = new DbViewModel();
            vm.Personas = _context.People.ToList();
            vm.Cities = _context.Cities.ToList();
            //ViewData["cityid"] = new SelectList(_context.Cities, "Id", "Name");
            
            return View(vm);
        }
        [HttpPost]
        public IActionResult AddPersona(string name, string phonenumber, string cities)
        {
            DbViewModel vm = new DbViewModel();
           
            _context.People.Add(new Persona() {
                Name = name,
                PhoneNumber = phonenumber,
                CityId = int.Parse(cities)
            });
            _context.SaveChanges();
            vm.Personas = _context.People.ToList();
            vm.Cities = _context.Cities.ToList();
            
            return View("Index",vm);
        }
        [HttpPost]
        public IActionResult EditPersona(string id, string name, string phonenumber, string cities)
        {
            DbViewModel vm = new DbViewModel();
            var persona = _context.People.First(a => a.Id == int.Parse(id));
            persona.Name = name;
            persona.PhoneNumber = phonenumber;
            persona.CityId = int.Parse(cities);
            _context.SaveChanges();
            vm.Personas = _context.People.ToList();
            vm.Cities = _context.Cities.ToList();

            return View("Index", vm);
        }
        [HttpPost]
        public IActionResult DeletePersona(string id)
        {
            DbViewModel vm = new DbViewModel();
            vm.Persona_Languages = _context.Personas_Languages.ToList();

            var persona = new Persona() { Id = int.Parse(id) };
            if (vm.Persona_Languages.Any(p => p.PersonaId == int.Parse(id)))
            {
                ViewBag.ErrorMess = "could not delete as there are still connections to languages";
            }
            else
            {
                _context.People.Attach(persona);
                _context.People.Remove(persona);
                _context.SaveChanges();
            }
            vm.Personas = _context.People.ToList();
            vm.Cities = _context.Cities.ToList();


            return View("Index",vm);
        }
    }
}
