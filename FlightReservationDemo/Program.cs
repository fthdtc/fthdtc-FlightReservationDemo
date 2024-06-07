
using FlightReservationDemo.Service.Services;

Console.WriteLine("start");
IReservationService reservationService = new ReservationService();
reservationService.StartReservation();