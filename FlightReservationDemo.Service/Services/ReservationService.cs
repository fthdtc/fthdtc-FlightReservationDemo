using FlightReservationDemo.Data.Entity;
using FlightReservationDemo.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationDemo.Service.Services
{
    public class ReservationService 
    {
        private IRepository<Reservation> reservationRepository = new ReservationRepository();
        public List<Reservation> GetAllReservation()
        {
            return reservationRepository.GetAll();
        }
    }
}
