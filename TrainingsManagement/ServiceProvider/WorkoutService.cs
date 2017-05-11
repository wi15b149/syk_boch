using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Shared;
using TrainingsDataRepository;

namespace ServiceProvider
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "WorkoutService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    public class WorkoutService : IWorkoutService
    {
        DataHandler dbh = new DataHandler();

        public List<Workout> QueryWorkouts(string description)
        {
            return dbh.QueryWorkouts(description);
        }
    }
}
