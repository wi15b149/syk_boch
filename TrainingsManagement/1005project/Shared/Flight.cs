using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Flight
    {
        public Guid FlightID { get; set; }
        public string FlightNo { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public string Operator { get; set; }


    }
}
