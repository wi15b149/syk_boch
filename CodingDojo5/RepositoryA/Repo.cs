using Shared;
using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Repo : IPersonQueryable
    {
        public string Name { get; set; }

        public List<Person> Persons { get; set; }

        public void AddPerson(Person p)
        {
            Persons.Add(p);
        }

        public override string ToString()
        {
            string output = "";
            if (Persons != null)
            {               
                foreach (var item in Persons)
                {
                    output = output + item.ToString() + "\n";
                }
            }
            return output;
        }

        public List<Person> QueryPerson()
        {
            return Persons;
        }

        public Repo(string name)
        {
            Name = name;
            Persons = new List<Person>();
        }

    }
}
