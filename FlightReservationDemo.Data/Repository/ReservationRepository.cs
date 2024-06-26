﻿using FlightReservationDemo.Data.Context;
using FlightReservationDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationDemo.Data.Repository
{
    public class ReservationRepository : IRepository<Reservation>
    {
        public int Add(Reservation entity)
        {
            DBContext._reservationStore.Add(entity);
            return entity.Id;
        }

        public List<Reservation> GetAll()
        {
            return DBContext._reservationStore;
        }

        public Reservation GetById(int id)
        {
            return DBContext._reservationStore.FirstOrDefault(r => r.Id == id);
        }

        public void Update(Reservation entity)
        {
            throw new NotImplementedException();
        }
    }
}
