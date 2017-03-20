using MyFirstWcfServiceConsumer.SR_SimpleWcfService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWcfServiceConsumer
{
    class Program
    {
        private static bool run = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Lets consume a service!");
            SimpleWcfServiceProviderClient client = new SimpleWcfServiceProviderClient();
            client.DoWorkCompleted += client_DoWorkCompleted;
            client.DoWorkAsync(new ChatMessage() { Header = "Testnachricht", Date = DateTime.Now, Content = "Hello World" } );

            while (run)
            {
                Console.WriteLine("I am waiting...");

            }

            Console.ReadLine();
        }

        private static void client_DoWorkCompleted(object sender, AsyncCompletedEventArgs e)
        {
            run = false;
            Console.WriteLine("Data sent to Service Provider");
        }
    }
}
