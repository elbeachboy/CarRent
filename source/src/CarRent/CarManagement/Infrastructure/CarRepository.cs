using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Domain;
using CarRent.CustomerManagement.DbContext;
using Microsoft.EntityFrameworkCore;

namespace CarRent.CarManagement.Infrastructure
{
    public class CarRepository : ICarRepository
    {

        private readonly CarRentDBContext _dbContext;

        public CarRepository(CarRentDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Car> GetAll()
        {
            return _dbContext.Cars.Include(c => c.CarClass).ToList();
        }

        public List<Car> FindById(Guid id)
        {
            return _dbContext.Cars.Include(c => c.CarClass).Where(c => c.Id == id).ToList();
        }

        public List<Car> FindByType(string type)
        {
            return _dbContext.Cars.Include(c => c.CarClass).Where(c => c.Type == type).ToList();
        }


        public void Add(Car car)
        {
            _dbContext.Add(car);
            _dbContext.SaveChanges();
        }

        public void Upsert(Car car)
        {
            _dbContext.Cars.Update(car);
            _dbContext.SaveChanges();
        }

        public void Remove(Guid id)
        {
            _dbContext.Cars.Remove(_dbContext.Cars.Find(id));
            _dbContext.SaveChanges();
        }

        public void Remove(Car car)
        {
            _dbContext.Cars.Remove(car);
            _dbContext.SaveChanges();
        }
    }
}
