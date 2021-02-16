using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.ReservationManagement.Domain
{
    public interface IReservationRepository
    {
        List<Reservation> GetAllReservations();

        List<Reservation> FindById(Guid id);

        void Add(Reservation reservation);

        void Upsert(Reservation reservation);

        void Remove(Guid id);

        void Remove(Reservation reservation);
    }
}
