using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentAdapterMqServiceAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MQ ADAPTER");
            AgentAdapterHandler handler = new AgentAdapterHandler();
            
            Console.WriteLine("Press Enter to stop the Adapter!");
            Console.ReadLine();
        }
    }
}
