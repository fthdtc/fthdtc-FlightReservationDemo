using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationDemo.Data.Entity
{
    public class Customer
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; } 
        public string PostalCode { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobileNumber { get; set; }
    }
}
