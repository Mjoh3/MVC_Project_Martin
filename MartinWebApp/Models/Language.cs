using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Models
{
    public class Language
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public ICollection<Persona_Language> Persona_Language { get; set; }
    }
}
