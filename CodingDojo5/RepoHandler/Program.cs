using DataLayer;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Repo repositoryA = new Repo();
            Repo repositoryB = new Repo();

            repositoryA.AddPerson(new Person("Michael Boch1", Guid.NewGuid(), 1, 666, true));
            repositoryA.AddPerson(new Person("Michael Boch2", Guid.NewGuid(), 1, 777, false));
            repositoryA.AddPerson(new Person("Michael Boch3", Guid.NewGuid(), 0, 888, true));

            repositoryB.AddPerson(new Person("Michael Boch6", Guid.NewGuid(), 1, 111, true));
            repositoryB.AddPerson(new Person("Michael Boch7", Guid.NewGuid(), 0, 222, false));
            repositoryB.AddPerson(new Person("Michael Boch8", Guid.NewGuid(), 1, 333, true));

            while (true)
            {
                
            }
        }
    }
}
