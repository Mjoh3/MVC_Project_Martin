using MartinWebApp.Data;
using MartinWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Controllers
{
    
    public class CitiesController : Controller
    {
        private readonly AppDbContext _context;

        public CitiesController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            DbViewModel vm = new DbViewModel();
            vm.Countries = _context.Countries.ToList();
            vm.Cities = _context.Cities.ToList();
            return View(vm);
        }
        [HttpPost]
        public IActionResult AddCity(string name, string country)
        {
            DbViewModel vm = new DbViewModel();

            _context.Cities.Add(new City()
            {
                Name = name,
                
                CountryId = int.Parse(country)
            });
            _context.SaveChanges();
            vm.Countries = _context.Countries.ToList();
            vm.Cities = _context.Cities.ToList();

            return View("Index", vm);
        }
        [HttpPost]
        public IActionResult EditCity(string id, string name, string country)
        {
            DbViewModel vm = new DbViewModel();
            var city = _context.Cities.First(a => a.Id == int.Parse(id));
            city.Name = name;
            
            city.CountryId = int.Parse(country);
            _context.SaveChanges();
            vm.Countries = _context.Countries.ToList();
            vm.Cities = _context.Cities.ToList();

            return View("Index", vm);
        }
        [HttpPost]
        public IActionResult DeleteCity(string id)
        {
            DbViewModel vm = new DbViewModel();
            vm.Countries = _context.Countries.ToList();
            vm.Personas = _context.People.ToList();
            var city = new City() { Id = int.Parse(id) };
            if (vm.Personas.Any(p => p.Id == int.Parse(id)))
            {
                ViewBag.ErrorMess = "Could not delete, make sure no people are connected to the city";
            }
            else
            {
                _context.Cities.Attach(city);
                _context.Cities.Remove(city);
                _context.SaveChanges();
            }
            vm.Cities = _context.Cities.ToList();

            return View("Index", vm);
        }
    }
}
