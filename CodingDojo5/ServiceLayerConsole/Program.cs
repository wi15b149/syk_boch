using ServiceLayerLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application running press ENTER to terminate...");

            //Starts the PersonHandler
            PersonHandler sh = new PersonHandler();
            Console.ReadLine();

        }
    }
}
