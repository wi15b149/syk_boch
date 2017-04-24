using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{

    public class Person
    {
        public Person(string name, Guid iD, int type, decimal salary, bool ownskey)
        {
            Name = name;
            ID = iD;
            Type = type;
            Salary = salary;
            Ownskey = ownskey;
        }

        public string Name { get; set; }
        public Guid ID { get; set; }
        public int Type { get; set; }
        public decimal Salary { get; set; }
        public bool Ownskey { get; set; }

    }
}
