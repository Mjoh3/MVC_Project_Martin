using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MartinWebApp.Models;
namespace MartinWebApp.Controllers
{
    [Route("/People")]
    public class PeopleController : Controller
    {
        [HttpGet]
        public IActionResult PeopleIndex()
        {
            return View();
        }
        [HttpPost]
        [Route("/People/PeopleIndex")]
        public IActionResult PeopleIndex(string name, string phonenumber, string city)
        {
            var p = new Person();
            p.City = city;
            p.Name = name;
            p.PhoneNumber = phonenumber;
            
            if(p.City!=null && p.Name!=null && p.PhoneNumber!=null)
            {
                CreatePersonViewModel.CreatePerson(p);
                CreatePersonViewModel.CreatePeopleResult(null, null, null);
            }
            else
            {
                ViewBag.ErrorMess = "Fill in all fields please";
            }
            return View(new PeopleViewModel());
        }
        [HttpPost]
        [Route("/People/PeopleSearch")]
        public IActionResult PeopleSearch(string name, string phonenumber, string city)
        {
            CreatePersonViewModel.CreatePeopleResult(name, phonenumber, city);
            return View(new PeopleViewModel());
        }
    }
}
