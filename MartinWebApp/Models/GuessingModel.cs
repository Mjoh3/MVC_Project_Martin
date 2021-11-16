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
        private static int tries=0;
        public static int highScore=1000;
        public static void ResetTries() { tries = 0; }
        public static void UpdateHighScore()
        {
            highScore = tries;              
        }
        public static void UpdateTries()
        {   
            tries++;
        }

        public static string GuessResponseMessage(int guesser)
        {
            
            string showtries = tries.ToString();
            
            if (guesser<randomNumber)
            {
                return guesser + " was too low, guess higher, Number of tries: "+showtries;
            }
            else if (guesser > randomNumber)
            {
                return guesser + " was too high, guess lower, Number of tries: "+showtries;
            }           
            else
            {
                return guesser + " was correct, congratulations!, Number of tries:"+showtries;
                
            }
            
        }
    }
}
