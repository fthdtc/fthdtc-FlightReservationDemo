using FlightReservationDemo.Data.Entity;
using FlightReservationDemo.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationDemo.Service.Services
{
    public class FlightService  
    {
        private IRepository<Flight> flightRepository = new FlightRepository();
        public List<Flight> GetAllFlights()
        {
            return flightRepository.GetAll();
        }

        public void CreateFlight(Flight entity)
        {
            flightRepository.Add(entity);
        }
    }
}
