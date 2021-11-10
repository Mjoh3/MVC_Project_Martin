using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Models
{
    public class TemperatureModel
    {
        public static float temperatureC { set; get; }
        public static string ShowStatus(float toohigh, float toolow) {
            if (temperatureC > toohigh)
            {
                return "You are sick";
            }
            else if (temperatureC < toolow)
            {
                return "You have hypothermeria";
            }
            else
            {
                return "You are healthy";
            }
        }
        


    }
}
