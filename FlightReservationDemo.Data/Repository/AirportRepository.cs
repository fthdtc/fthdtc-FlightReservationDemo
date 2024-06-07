using FlightReservationDemo.Data.Context;
using FlightReservationDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationDemo.Data.Repository
{
    public class AirportRepository : IRepository<Airport>
    {
        public int Add(Airport entity)
        {
            var last = DBContext._airportStore.OrderByDescending(r => r.Id).FirstOrDefault();
            int lastId = last == null ? 0 : last.Id;
            entity.Id = lastId + 1;
            DBContext._airportStore.Add(entity);
            return entity.Id;
        }

        public List<Airport> GetAll()
        {
            return DBContext._airportStore;
        }

        public Airport GetById(int id)
        {
            return DBContext._airportStore.FirstOrDefault(r => r.Id == id);
        }

        public void Update(Airport entity)
        {
            throw new NotImplementedException();
        }
    }
}
