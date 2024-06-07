using FlightReservationDemo.Base.Helper;
using FlightReservationDemo.Data.Entity;
using FlightReservationDemo.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationDemo.Service.Services
{
    public class CustomerService  
    {
        private IRepository<Customer> customerRepository = new CustomerRepository();
        public List<Customer> GetAllCustomers()
        {
            return customerRepository.GetAll();
        }

        public bool AddCustomer(Customer entity)
        {
            if (entity.CustomerEmail.ValidateEmail()) throw new Exception("email is invalid!");
            if (entity.CustomerMobileNumber.ValidateGSMNumber()) throw new Exception("GSM number is invalid!");
            if (entity.Address.ValidateAdress()) throw new Exception("Adress is invalid!");

            customerRepository.Add(entity);
            return true;
        }
    }
}
