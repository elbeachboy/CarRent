using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.ReservationManagement.Domain;

namespace CarRent.ReservationManagement.Application
{
    public interface IReservationService
    {
        List<Reservation> GetAllReservations();

        List<Reservation> GetReservationsById(Guid id);

        void AddReservation(Reservation reservation);

        void DeleteReservation(Guid id);

        void UpdateReservation(Reservation reservation);
    }
}
