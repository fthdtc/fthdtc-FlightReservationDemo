using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationDemo.Data.Entity
{
    public class Reservation
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
    }
}
