using FlightReservationDemo.Data.Entity;
using FlightReservationDemo.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationDemo.Service.Services
{
    public class AirportService 
    {
        private IRepository<Airport> airportRepository = new AirportRepository();
        public List<Airport> GetAllAirports()
        {
            return airportRepository.GetAll();
        }
    }
}
