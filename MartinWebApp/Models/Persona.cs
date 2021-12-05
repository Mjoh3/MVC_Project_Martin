using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        
        public int? CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public string Name { get; set; }


        public ICollection<Persona_Language> Persona_Language { get; set; }
    }
}
