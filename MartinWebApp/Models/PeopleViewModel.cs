using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Models
{
    public class PeopleViewModel
    {
        public static List<Person> people = new List<Person>();
        public static List<Person> peopleResult = new List<Person>();
        public static bool IdExistInPeople(int id)
        {
            foreach (var p in people)
            {
                if (p.GetID() == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
