using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Models
{
    public class Person
    {
        private static int IDgenerator = 0;
        private readonly int iD;
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public int GetID()
        {
            return iD;
        }
        public Person()
        {
            iD = IDgenerator;
            IDgenerator += 1;
        }
    }
}
