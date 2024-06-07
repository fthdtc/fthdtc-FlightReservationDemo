using FlightReservationDemo.Data.Context;
using FlightReservationDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationDemo.Data.Repository
{
    public class CustomerRepository : IRepository<Customer>
    { 
        public int Add(Customer entity)
        {
            var last = DBContext._customerStore.OrderByDescending(r => r.Id).FirstOrDefault();
            int lastId = last == null ? 0 : last.Id;
            entity.Id = lastId + 1;
            DBContext._customerStore.Add(entity);
            return entity.Id;
        }

        public List<Customer> GetAll()
        {
            return DBContext._customerStore;
        }

        public Customer GetById(int id)
        {
            return DBContext._customerStore.FirstOrDefault(r => r.Id == id);
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
