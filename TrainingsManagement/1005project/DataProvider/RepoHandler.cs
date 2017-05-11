using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    public class RepoHandler
    {
        syco_trainingEntities1 db;

        public RepoHandler()
        {
            db = new syco_trainingEntities1();
        }

        public List<wi15b666_flight> QueryList()
        {
            var temp = from x in db.wi15b666_flight
                       select x;

            return temp.ToList();
        }

        public int AddFlight(string no, string sp, string ep, string op)
        {
            
            db.wi15b666_flight.Add(new wi15b666_flight()
            {
                ID = Guid.NewGuid(),
                FlightNo = no,
                Startpoint = sp,
                Endpoint = ep,
                Operator = op
            });
            return db.SaveChanges();
        }
    }
}
