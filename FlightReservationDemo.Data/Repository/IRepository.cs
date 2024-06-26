﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationDemo.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        int Add(T entity);
        void Update(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
