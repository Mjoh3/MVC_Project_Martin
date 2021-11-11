using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Models
{
    public class GuessingModel
    {
       
        
        private static int randomNumber;
        
        
        public static int GetCorrectNumber() { return randomNumber; }
        public static void SetRandomNumber()
        {
            Random r = new Random();
            randomNumber = r.Next(1, 100);
        }
        
        public static string GuessResponseMessage(int guesser)
        {
            
            if (guesser<randomNumber)
            {
                return guesser + " was too low, guess higher";
            }
            else if (guesser > randomNumber)
            {
                return guesser + " was too high, guess lower";
            }           
            else
            {
                return guesser + " was correct, congratulations!\n Number of tries:";
            }
            
        }
    }
}
