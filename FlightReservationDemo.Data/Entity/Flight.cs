using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationDemo.Data.Entity
{
    public class Flight
    {
        public int Id { get; set; } 
        public string FlightName { get; set; }
        public string FlightCode { get; set; }
        public int FromAirportId { get; set; }
        public int ToAirportId { get; set; }
        public int CompanyId { get; set; }
    }
}
