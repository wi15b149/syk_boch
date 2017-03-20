using MyFirstWcfProvider.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWcfProvider
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the service...");
            ServiceHost host = new ServiceHost(typeof(SimpleWcfServiceProvider));
            host.Open();
            Console.WriteLine("Service started");

            Console.ReadLine();
        }
    }
}
