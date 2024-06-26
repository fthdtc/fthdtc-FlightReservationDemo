﻿using FlightReservationDemo.Data.Context;
using FlightReservationDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationDemo.Data.Repository
{
    public class FlightRepository : IRepository<Flight>
    {
        public int Add(Flight entity)
        {
            DBContext._flightStore.Add(entity);
            return entity.Id;
        }

        public List<Flight> GetAll()
        {
            return DBContext._flightStore;
        }

        public Flight GetById(int id)
        {
            return DBContext._flightStore.FirstOrDefault(r => r.Id == id);
        }

        public void Update(Flight entity)
        {
            throw new NotImplementedException();
        }
    }
}
