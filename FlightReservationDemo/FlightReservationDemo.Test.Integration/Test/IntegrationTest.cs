using FlightReservationDemo.Data.Entity;
using FlightReservationDemo.Service.Services;

namespace FlightReservationDemo.Test.Integration.Test
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        [Priority(1)]
        public void CreateCustomers()
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
        [Priority(2)]
        public void CheckCreatedCustomers()
        {
            CustomerService service = new CustomerService();
            List<Customer> list = service.GetAllCustomers();
            if(list.Count != 5) Assert.Fail($"customer count should be 5!, current:{list.Count}"); 
        }
    }
}