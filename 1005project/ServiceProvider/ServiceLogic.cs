using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Shared;
using DataProvider;

namespace ServiceProvider
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "ServiceLogic" sowohl im Code als auch in der Konfigurationsdatei ändern.
    public class ServiceLogic : IServiceLogic
    {
        RepoHandler dbh = new RepoHandler();
        public int AddFlight(string no, string sp, string ep, string op)
        {
            dbh.AddFlight(no, sp, ep, op);
            return 1;
        }

        public List<Flight> QueryFlights()
        {
            List<Flight> flights = new List<Flight>();

            foreach (var item in dbh.QueryList())
            {
                flights.Add(new Flight()
                {
                    FlightID = item.ID,
                    FlightNo = item.FlightNo,
                    StartPoint = item.Startpoint,
                    EndPoint = item.Endpoint,
                    Operator = item.Operator
                });                
            }

            return flights;
            
        }
    }
}
