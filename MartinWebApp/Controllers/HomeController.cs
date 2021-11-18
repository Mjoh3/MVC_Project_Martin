using MartinWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult Projects()
        {
            return View();
        }
        [HttpGet]
        public IActionResult People()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult People(string name, string phonenumber, string city)
        {
            var p = new Person();
            p.City = city;
            p.Name = name;
            p.PhoneNumber = phonenumber;

            if (p.City != null && p.Name != null && p.PhoneNumber != null)
            {
                CreatePersonViewModel.CreatePerson(p);
                CreatePersonViewModel.CreatePeopleResult(null, null, null);
            }
            else
            {
                ViewBag.ErrorMess = "Fill in all fields please";
            }
            return View("people",new PeopleViewModel());
        }
        [HttpPost]
        
        public IActionResult PeopleSearch(string name, string phonenumber, string city)
        {
            CreatePersonViewModel.CreatePeopleResult(name, phonenumber, city);
            return View("people",new PeopleViewModel());
        }
        [HttpPost]
        public IActionResult PeopleDelete(string name, string phonenumber, string city)
        {
            CreatePersonViewModel.DeletePerson(name, phonenumber, city);
            CreatePersonViewModel.CreatePeopleResult(null, null, null);

            return View("people",new PeopleViewModel());
        }



    }
}
