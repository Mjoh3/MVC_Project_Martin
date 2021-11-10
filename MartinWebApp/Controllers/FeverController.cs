using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MartinWebApp.Models;
namespace MartinWebApp.Controllers
{
    [Route("/FeverCheck")]
    public class FeverController : Controller
    {
        public IActionResult FeverCheck()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FeverCheck(float tempC)
        {
            TemperatureModel.temperatureC = tempC;
            string temperatureResult = TemperatureModel.ShowStatus(37,35);
            ViewBag.Message = temperatureResult;
            return View();
        }
    }
    
}
