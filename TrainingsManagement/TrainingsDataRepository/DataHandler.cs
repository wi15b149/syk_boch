using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingsDataRepository
{
    public class DataHandler
    {
        //Ado.Net Framework einbinden
        //DB auswählen

        syco_trainingEntities db = new syco_trainingEntities();

        public List<Workout> QueryWorkouts(string description)
        {
            return (from x in db.Trainings
                        where x.Description.Contains(description) || x.Exercises.Contains(description)
                        select new Workout()
                        {
                            Description = x.Description,
                            Duration = x.Duration,
                            Exercises = x.Exercises,
                            Intensity = x.Level
                        }).ToList();

            //Alternative: For each Trainingsliste zu Workoutliste
            
        }

        public int AddWorkout(Workout w)
        {
            db.Trainings.Add(new Trainings() {
                Description = w.Description,
                Duration = w.Duration,
                Exercises = w.Exercises,
                Level = w.Intensity,
                Id = Guid.NewGuid()
            });

            return db.SaveChanges();
                
        }
    }
}
