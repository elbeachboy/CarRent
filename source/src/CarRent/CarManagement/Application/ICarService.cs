using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Domain;
using CarRent.CustomerManagement.Domain;

namespace CarRent.CarManagement.Application
{
    public interface ICarService
    {
        List<Car> GetAllCars();

        List<Car> GetCarByID(Guid id);

        List<Car> GetCarByType(string type);

        void AddCar(Car car);

        void DeleteCarById(Guid id);

        void UpdateCar(Car car);

    }
}
