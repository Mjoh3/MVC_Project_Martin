using MartinWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Controllers
{
    [Route("/PersonaLanguage")]
    public class PersonaLanguageController : Controller
    {
        private readonly AppDbContext _context;

        public PersonaLanguageController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Personas_Languages.ToList();
            return View(data);
        }
    }
}
