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
            GuessingModel.ResetTries();
            if(HttpContext.Session.GetInt32("RandomNum") == null)
            {
                GuessingModel.highScore = 1000;
            }
            
            HttpContext.Session.SetInt32("RandomNum", GuessingModel.GetCorrectNumber());
            
            HttpContext.Response.Cookies.Append("HighScore", GuessingModel.highScore.ToString());
            return View();
        }
        [HttpPost]
        public IActionResult GuessingGame(int guess)
        {
            if (HttpContext.Session.GetInt32("RandomNum") != null)
            {
                
                GuessingModel.UpdateTries();
                
                
                ViewBag.Message = GuessingModel.GuessResponseMessage(guess);
                
                if (GuessingModel.GetCorrectNumber() == guess)
                {
                    GuessingModel.UpdateHighScore();
                    HttpContext.Response.Cookies.Append("HighScore", GuessingModel.highScore.ToString());
                    GuessingModel.SetRandomNumber();                    
                    HttpContext.Session.SetInt32("RandomNum", GuessingModel.GetCorrectNumber());
                    GuessingModel.ResetTries();
                }
                if (HttpContext.Request.Cookies["HighScore"] != "1000")
                {
                    ViewBag.Cookiemessage = "High score: " + HttpContext.Request.Cookies["HighScore"];
                }
                else
                {
                    ViewBag.Cookiemessage = "High score: -";
                }

            }
            else
            {
                ViewBag.Message = "Session expired";
            }
            return View();
        }

    }
}
