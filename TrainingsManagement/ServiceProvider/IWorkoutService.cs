using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceProvider
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "IWorkoutService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceContract]
    public interface IWorkoutService
    {
        [OperationContract]
        List<Workout> QueryWorkouts(string description);


    }
}
