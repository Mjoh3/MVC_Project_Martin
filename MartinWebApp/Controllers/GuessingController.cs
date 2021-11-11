using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MartinWebApp.Models;

namespace MartinWebApp.Controllers
{
    [Route("/GuessingGame")]
    public class GuessingController : Controller
    {
        [HttpGet]
        public IActionResult GuessingGame()
        {
            GuessingModel.SetRandomNumber();
            HttpContext.Session.SetInt32("RandomNum", GuessingModel.GetCorrectNumber());            
            return View();
        }
        [HttpPost]
        public IActionResult GuessingGame(int guess)
        {
            if (HttpContext.Session.GetInt32("RandomNum") != null)
            {
                ViewBag.Message = GuessingModel.GuessResponseMessage(guess);
            }
            else
            {
                ViewBag.Message = "Session expired";
            }
            return View();
        }

    }
}
