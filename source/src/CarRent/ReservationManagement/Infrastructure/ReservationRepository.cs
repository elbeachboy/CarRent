using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CustomerManagement.DbContext;
using CarRent.ReservationManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarRent.ReservationManagement.Infrastructure
{
    public class ReservationRepository: IReservationRepository
    {
        private readonly CarRentDBContext _dbContext;

        public ReservationRepository(CarRentDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Reservation> GetAllReservations()
        {
            return _dbContext.Reservations.Include(r => r.Car).Include(r => r.Customer).ToList();
        }

        public List<Reservation> FindById(Guid id)
        {
            return _dbContext.Reservations.Include(r => r.Car).Include(r => r.Customer).Where(r => r.Id == id).ToList();
        }

        public void Add(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
        }

        public void Upsert(Reservation reservation)
        {
            _dbContext.Reservations.Update(reservation);
            _dbContext.SaveChanges();
        }

        public void Remove(Guid id)
        {
            _dbContext.Reservations.Update(_dbContext.Reservations.Find(id));
            _dbContext.SaveChanges();
        }

        public void Remove(Reservation reservation)
        {
            _dbContext.Reservations.Remove(reservation);
            _dbContext.SaveChanges();
        }
    }
}
