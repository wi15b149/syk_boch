using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyFirstWcfProvider.Services
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "SimpleWcfServiceProvider" sowohl im Code als auch in der Konfigurationsdatei ändern.
    public class SimpleWcfServiceProvider : ISimpleWcfServiceProvider
    {
      
        public void DoWork(ChatMessage msg)
        {
            Console.WriteLine(String.Format("Received message: {0} Date {1} \r\n\t {2}",msg.Header,msg.Date,msg.Content));
        }
    }
}
