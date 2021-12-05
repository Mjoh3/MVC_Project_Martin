using MartinWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Controllers
{
    [Route("/Cities")]
    public class CitiesController : Controller
    {
        private readonly AppDbContext _context;

        public CitiesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Cities.ToList();
            return View(data);
        }
    }
}
