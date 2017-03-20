using AgentComServices;
using Shared.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCollectorAgent
{
    class Program
    {
        StringMessageInformer informer;
        Worker worker;

        static void Main(string[] args)
        {
            Program prog = new Program();
            Console.WriteLine("worker running...");

            Console.WriteLine("Press Enter to stop the Worker!");
            Console.ReadLine();
            prog.worker.StopCollectingAppInfo();
        }

        public Program()
        {
            informer = new StringMessageInformer(UpdateReceived);

            Console.WriteLine("Starting App Collector Agent");
            worker = new Worker(60000, informer, new MSMQCommunication());
            worker.StartCollectingAppInfo();
        }

        /// <summary>
        /// Stop the Application
        /// </summary>
        void Stop()
        {
            worker.StartCollectingAppInfo();
        }

        /// <summary>
        /// Worker collected the Information 
        /// </summary>
        /// <param name="message"></param>
        void UpdateReceived(string message)
        {
            Console.Clear();
            Console.WriteLine("Press Enter to stop the Worker!");
            /*
            foreach (var item in worker.AppList)
            {
                Console.WriteLine("\t" + item);
            }
            */

        }
    }
}
