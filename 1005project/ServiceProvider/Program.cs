using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProvider
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(ServiceLogic));
            sh.Open();
            Console.WriteLine("Service started...");
            Console.ReadLine();
        }
    }
}
