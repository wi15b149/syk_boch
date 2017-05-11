using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IPersonQueryable
    {
        void AddPerson(Person s);
        List<Person> QueryPerson();
    }
}
