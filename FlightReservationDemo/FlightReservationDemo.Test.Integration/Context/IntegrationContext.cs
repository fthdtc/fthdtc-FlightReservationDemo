using FlightReservationDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationDemo.Test.Integration.Context
{
    public static class IntegrationContext
    {
        public static int NewAirportId { get; set; }
        public static int NewFlightId { get; set; }
        public static Customer CurrentCustomer { get; set; }
        public static Reservation CurrentReservation { get; set; }
    }
}
