using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        public string Cityname { get; set; }
        public string Languagename { get; set; }
        public string PhoneNumber { get; set; }
        public string Countryname { get; set; }
        public string Name { get; set; }
    }
}
