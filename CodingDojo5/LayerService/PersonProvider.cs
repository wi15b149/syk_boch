using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Shared;

namespace LayerService
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "PersonProvider" sowohl im Code als auch in der Konfigurationsdatei ändern.
    public class PersonProvider : IPersonProvider
    {
        private static Action<Person> informer;

        public static void InitService(Action<Person> informer)
        {
            PersonProvider.informer = informer;
        }

        public bool AddPerson(Person p)
        {
            if (informer != null)
            {
                informer(p);
                return true;
            }
            return false;
        }
        
    }
}
