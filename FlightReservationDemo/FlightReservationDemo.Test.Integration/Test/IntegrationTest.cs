using FlightReservationDemo.Data.Entity;
using FlightReservationDemo.Service.Services;
using FlightReservationDemo.Test.Integration.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FlightReservationDemo.Test.Integration.Test
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        [Description("CreateCustomers")]
        public void Test_001()
        {
            CustomerService service = new CustomerService();

            List<Customer> list = new List<Customer>();
            list.Add(new Customer { Name = "Customer Test 1", Address = "Customer Adress 1", City = "ISTANBUL", PostalCode = "3401", CustomerEmail = "customer1@customer.com", CustomerMobileNumber = "2220000001", Id = 1 });
            list.Add(new Customer { Name = "Customer Test 2", Address = "Customer Adress 2", City = "ISTANBUL", PostalCode = "3401", CustomerEmail = "customer2@customer.com", CustomerMobileNumber = "2220000002", Id = 2 });
            list.Add(new Customer { Name = "Customer Test 3", Address = "Customer Adress 3", City = "ISTANBUL", PostalCode = "3401", CustomerEmail = "customer3@customer.com", CustomerMobileNumber = "2220000003", Id = 3 });
            list.Add(new Customer { Name = "Customer Test 4", Address = "Customer Adress 4", City = "ISTANBUL", PostalCode = "3401", CustomerEmail = "customer4@customer.com", CustomerMobileNumber = "2220000004", Id = 4 });
            list.Add(new Customer { Name = "Customer Test 5", Address = "Customer Adress 5", City = "ISTANBUL", PostalCode = "3401", CustomerEmail = "customer5@customer.com", CustomerMobileNumber = "2220000005", Id = 5 });

            foreach (var item in list)
            {
                if (!service.AddCustomer(item)) Assert.Fail($"fail on adding customer!:{item.Id}");
            }
        }

        [TestMethod]
        [Description("CheckCreatedCustomers")]
        public void Test_002()
        {
            CustomerService service = new CustomerService();
            List<Customer> list = service.GetAllCustomers();
            if(list.Count != 5) Assert.Fail($"customer count should be 5!, current:{list.Count}"); 
        }

        [TestMethod]
        [Description("AuthNewCustomer")]
        public void Test_003()
        {
            CustomerService service = new CustomerService();
            Customer newCustomer = service.GetAllCustomers().FirstOrDefault(r => r.CustomerEmail != null && r.CustomerEmail == "customer5@customer.com");
            if (newCustomer == null) Assert.Fail($"customer couldn't found!, current:{"customer5@customer.com"}");

            if(!new AuthService().Authenticate(newCustomer)) Assert.Fail($"customer couldn't authenticated!, current:{"customer5@customer.com"}");

            IntegrationContext.CurrentCustomer = newCustomer;
        }

        [TestMethod]
        [Description("CreateAirport")]
        public void Test_004()
        {
            AirportService service = new AirportService();
            Airport airport = new Airport
            {
                Id = 10,
                AirportName = "Orlando International Airport",
                CountryId = 1
            };
            service.CreateAirport(airport);
            IntegrationContext.NewAirportId = airport.Id;
        }


        [TestMethod]
        [Description("CheckCreatedAirport")]
        public void Test_005()
        {
            AirportService service = new AirportService();
            Airport newAirport = service.GetAllAirports().FirstOrDefault(r=>r.Id == IntegrationContext.NewAirportId);
            if (newAirport == null) Assert.Fail($"airport is null, current:{IntegrationContext.NewAirportId}");
        }


        [TestMethod]
        [Description("CreateFlight")]
        public void Test_006()
        {
            FlightService service = new FlightService();
            Flight flight = new Flight
            {
                Id = 20,
                CompanyId = 1,
                FlightCode = "FL0001",
                FromAirportId = IntegrationContext.NewAirportId,
                ToAirportId = IntegrationContext.NewAirportId,
                FlightName = "FL0001"
            };
            service.CreateFlight(flight);
            IntegrationContext.NewFlightId = flight.Id;
        }


        [TestMethod]
        [Description("CheckCreatedFlight")]
        public void Test_007()
        {
            FlightService service = new FlightService();
            Flight newFlight = service.GetAllFlights().FirstOrDefault(r => r.Id == IntegrationContext.NewFlightId);
            if (newFlight == null) Assert.Fail($"flight is null, current:{IntegrationContext.NewFlightId}");
        }

        [TestMethod]
        [Description("CreateReservation")]
        public void Test_008()
        {
            ReservationService service = new ReservationService();
            Reservation reservation = new Reservation();
            reservation.ReservationDate = DateTime.Now;
            reservation.FlightDate = DateTime.Now;
            reservation.CustomerId = IntegrationContext.CurrentCustomer.Id;
            reservation.FlightId = IntegrationContext.NewFlightId;
            reservation.Id = 100;

            if (!service.CreateReservation(reservation)) Assert.Fail($"reservation couldn't created!, current:{reservation.Id}"); 

            IntegrationContext.CurrentReservation = reservation;
        }

        [TestMethod]
        [Description("CheckReservation")]
        public void Test_009()
        {
            ReservationService service = new ReservationService();
            Reservation reservation = service.GetAllReservation().FirstOrDefault(r => r.Id == IntegrationContext.CurrentReservation.Id);
            if (reservation == null) Assert.Fail($"reservation is null, current:{IntegrationContext.CurrentReservation.Id}");

            //todo: remove new data if tests run in real environment!
        }
    }
}