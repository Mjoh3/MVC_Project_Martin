using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinWebApp.Models
{

    public class CreatePersonViewModel
    {
        public static void CreatePerson(Person p)
        {
            PeopleViewModel.people.Add(p);
        }
        public static void CreatePeopleResult(string name, string phonenumber, string city)
        {
            PeopleViewModel.peopleResult.Clear();
            foreach (var p in PeopleViewModel.people)
            {
                if((p.Name==name|| name==null) &&
                    (p.PhoneNumber == phonenumber || phonenumber==null) &&
                    (p.City == city || city == null))
                {
                    PeopleViewModel.peopleResult.Add(p);
                }
            }
        }
        public static void DeletePerson(string name, string phonenumber, string city)
        {
            for(int i=0; i< PeopleViewModel.people.Count; i++)
            {
                if(PeopleViewModel.people[i].City==city && 
                    PeopleViewModel.people[i].PhoneNumber == phonenumber && 
                    PeopleViewModel.people[i].Name == name) 
                { 
                    PeopleViewModel.people.RemoveAt(i); 
                    break; 
                }
                
            }
            
            
        }

    }
}
