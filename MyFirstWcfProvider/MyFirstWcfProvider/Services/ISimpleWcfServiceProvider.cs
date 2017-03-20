using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyFirstWcfProvider.Services
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "ISimpleWcfServiceProvider" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceContract]
    public interface ISimpleWcfServiceProvider
    {
        [OperationContract]
        void DoWork(ChatMessage msg);
    }
}
