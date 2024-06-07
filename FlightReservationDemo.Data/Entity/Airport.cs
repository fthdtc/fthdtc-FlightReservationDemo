using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationDemo.Data.Entity
{
    public class Airport
    {
        public int Id { get; set; }
        public string AirportName { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
    }
}
