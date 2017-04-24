using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Repo
    {
        public List<Person> Persons { get; set; }

        public void AddPerson(Person p)
        {
            Persons.Add(p);
        }      

        
        public Repo()
        {
            Persons = new List<Person>();
        }

    }
}
