using MartinWebApp.Data;
using MartinWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Controllers
{

    public class PersonaLanguageController : Controller
    {
        private readonly AppDbContext _context;

        public PersonaLanguageController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            DbViewModel vm = new DbViewModel();
            vm.Personas = _context.People.ToList();
            vm.Languages = _context.Languages.ToList();
            vm.Persona_Languages = _context.Personas_Languages.ToList();
            

            return View(vm);
        }
        [HttpPost]
        public IActionResult AddPersonaLanguage(string persona, string language)
        {
            DbViewModel vm = new DbViewModel();
            vm.Persona_Languages = _context.Personas_Languages.ToList();
            if (vm.Persona_Languages.Any(p => p.PersonaId == int.Parse(persona) && p.LanguageId == int.Parse(language))) {
                ViewBag.ErrorMess = "Could not add connection because it already exists";
            }
            else { 
            _context.Personas_Languages.Add(new Persona_Language()
            {
                LanguageId = int.Parse(language),
                PersonaId = int.Parse(persona)
            });
            _context.SaveChanges();
                ViewBag.ErrorMess = null;
            }
            vm.Personas = _context.People.ToList();
            vm.Languages = _context.Languages.ToList();
            vm.Persona_Languages = _context.Personas_Languages.ToList();
            

            return View("Index", vm);
        }
        
        [HttpPost]
        public IActionResult DeletePersonaLanguage(string persona, string language)
        {
            DbViewModel vm = new DbViewModel();
            //vm.Persona_Languages = _context.Personas_Languages.ToList();
            var pl = new Persona_Language()
            {
                LanguageId = int.Parse(language),
                PersonaId = int.Parse(persona)
            };
            _context.Personas_Languages.Attach(pl);
            if (_context.Personas_Languages.ToList().Any(p => p.PersonaId == int.Parse(persona) && p.LanguageId == int.Parse(language)))
            {
                //_context.Personas_Languages.Attach(pl);
                _context.Personas_Languages.Remove(pl);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.ErrorMess = "Could not find the selected item to delete";
            }
                
            vm.Personas = _context.People.ToList();
            vm.Languages = _context.Languages.ToList();
            vm.Persona_Languages = _context.Personas_Languages.ToList();
            return View("Index", vm);
        }
    }
}
