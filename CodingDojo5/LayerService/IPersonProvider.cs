using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LayerService
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "IPersonProvider" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceContract]
    public interface IPersonProvider
    {
        [OperationContract]
        bool AddPerson(Person p);
    }
}
