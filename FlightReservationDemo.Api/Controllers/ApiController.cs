using FlightReservationDemo.Data.Entity;
using FlightReservationDemo.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightReservationDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly ILogger<ApiController> _logger;
        private AirportService airportService = new AirportService();
        private FlightService flightService = new FlightService();
        private CustomerService customerService = new CustomerService();
        private ReservationService reservationService = new ReservationService();

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAirports")]
        public IEnumerable<Airport> GetAirports()
        { 
            return airportService.GetAllAirports().AsEnumerable();
        }

        [HttpGet(Name = "GetCustomers")]
        public IEnumerable<Customer> GetCustomers()
        {
            return customerService.GetAllCustomers().AsEnumerable();
        }

        [HttpGet(Name = "GetFlights")]
        public IEnumerable<Flight> GetFlights()
        {
            return flightService.GetAllFlights().AsEnumerable();
        }

        [HttpGet(Name = "GetReservations")]
        public IEnumerable<Reservation> GetReservations()
        {
            return reservationService.GetAllReservation().AsEnumerable();
        }
    }
}
