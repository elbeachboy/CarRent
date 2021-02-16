using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.ReservationManagement.Domain;

namespace CarRent.ReservationManagement.Application
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository reservationRepository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            this.reservationRepository = reservationRepository;
        }

        public List<Reservation> GetAllReservations()
        {
            return reservationRepository.GetAllReservations();
        }

        public List<Reservation> GetReservationsById(Guid id)
        {
            return reservationRepository.FindById(id);
        }

        public void AddReservation(Reservation reservation)
        {
            reservationRepository.Add(reservation);
        }

        public void DeleteReservation(Guid id)
        {
            reservationRepository.Remove(id);
        }

        public void UpdateReservation(Reservation reservation)
        {
            reservationRepository.Upsert(reservation);
        }
    }
}
