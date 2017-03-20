using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceConsumer.SR_WebService;

namespace WebServiceConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Call Service..");

            SimpleWebServiceSoapClient client = new SimpleWebServiceSoapClient();

            client.DoWork("Boch", "Michael", 26);

            Console.ReadLine();
        }
    }
}
