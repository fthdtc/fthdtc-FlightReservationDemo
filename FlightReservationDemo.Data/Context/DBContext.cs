using FlightReservationDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationDemo.Data.Context
{
    public static class DBContext
    {
        public static List<Customer> _customerStore = new List<Customer>();
        public static List<Airport> _airportStore = new List<Airport>();
        public static List<Reservation> _reservationStore = new List<Reservation>();
        public static List<Flight> _flightStore = new List<Flight>();
    }
}
