using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Models
{
    public class Persona_Language
    {
        public int LanguageId { get; set; }
        public Language Language{get;set;}

        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
    }
}
