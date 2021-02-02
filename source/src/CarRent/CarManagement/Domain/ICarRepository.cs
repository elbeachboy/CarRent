using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CustomerManagement.Domain;

namespace CarRent.CarManagement.Domain
{
    public interface ICarRepository
    {
        List<Car> GetAll();
        List<Car> FindById(Guid id);
        List<Car> FindByType(string type);
        void Add(Car car);
        void Upsert(Car car);
        void Remove(Guid id);
        void Remove(Car car);
    }
}
