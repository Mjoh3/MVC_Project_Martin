using MartinWebApp.Data;
using MartinWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Controllers
{
    
    public class CountriesController : Controller
    {
        private readonly AppDbContext _context;

        public CountriesController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            DbViewModel vm = new DbViewModel();
            vm.Countries = _context.Countries.ToList();

            return View(vm);
        }
        [HttpPost]
        public IActionResult AddCountry(string name)
        {
            DbViewModel vm = new DbViewModel();

            _context.Countries.Add(new Country()
            {
                Name = name
            });
            _context.SaveChanges();
            vm.Countries = _context.Countries.ToList();


            return View("Index", vm);
        }
        [HttpPost]
        public IActionResult EditCountry(string id, string name)
        {
            DbViewModel vm = new DbViewModel();
            var country = _context.Countries.First(a => a.Id == int.Parse(id));
            country.Name = name;

            _context.SaveChanges();
            vm.Countries = _context.Countries.ToList();

            return View("Index", vm);
        }
        [HttpPost]
        public IActionResult DeleteCountry(string id)
        {
            DbViewModel vm = new DbViewModel();
            vm.Cities = _context.Cities.ToList();
            var country = new Country() { Id = int.Parse(id) };
            if (vm.Cities.Any(p => p.Id == int.Parse(id)))
            {
                ViewBag.ErrorMess = "Could not delete, make sure all cities connected to the country are deleted";
            }
            else
            {
                _context.Countries.Attach(country);
                _context.Countries.Remove(country);
                _context.SaveChanges();
            }
            vm.Countries = _context.Countries.ToList();
            return View("Index", vm);
        }
    }
}
