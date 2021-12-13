using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Models
{
    public class DbViewModel
    {
        public IEnumerable<Persona> Personas { get; set; }
        public IEnumerable<City> Cities { get; set; }
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<Language> Languages { get; set; }
        public IEnumerable<Persona_Language> Persona_Languages { get; set; }
    }
}
