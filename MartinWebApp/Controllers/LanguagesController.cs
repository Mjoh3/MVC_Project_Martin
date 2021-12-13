using MartinWebApp.Data;
using MartinWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Controllers
{
    
    public class LanguagesController : Controller
    {
        private readonly AppDbContext _context;

        public LanguagesController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            DbViewModel vm = new DbViewModel();
            vm.Languages = _context.Languages.ToList();

            return View(vm);
        }
        [HttpPost]
        public IActionResult AddLanguage(string name)
        {
            DbViewModel vm = new DbViewModel();

            _context.Languages.Add(new Language()
            {
                Name=name
            });
            _context.SaveChanges();
            vm.Languages = _context.Languages.ToList();
            

            return View("Index", vm);
        }
        [HttpPost]
        public IActionResult EditLanguage(string id, string name)
        {
            DbViewModel vm = new DbViewModel();
            var language = _context.Languages.First(a => a.Id == int.Parse(id));
            language.Name = name;

            _context.SaveChanges();
            vm.Languages = _context.Languages.ToList();

            return View("Index", vm);
        }
        [HttpPost]
        public IActionResult DeleteLanguage(string id)
        {
            DbViewModel vm = new DbViewModel();
            
            vm.Persona_Languages = _context.Personas_Languages.ToList();

            var language = new Language() { Id = int.Parse(id) };
            if (vm.Persona_Languages.Any(p => p.LanguageId == int.Parse(id)))
            {
                ViewBag.ErrorMess = "could not delete as there are still connections to people";
            }
            else
            {
                _context.Languages.Attach(language);
                _context.Languages.Remove(language);
                _context.SaveChanges();
            }
            vm.Languages = _context.Languages.ToList();
            return View("Index", vm);
        }
    }
}
