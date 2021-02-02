using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Domain;

namespace CarRent.CarManagement.Application
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public List<Car> GetAllCars()
        {
            return _carRepository.GetAll();
        }

        public List<Car> GetCarByID(Guid id)
        {
            return _carRepository.FindById(id);
        }

        public List<Car> GetCarByType(string type)
        {
            return _carRepository.FindByType(type);
        }

        public void AddCar(Car car)
        {
            _carRepository.Add(car);
        }

        public void DeleteCarById(Guid id)
        {
            _carRepository.Remove(id);
        }

        public void UpdateCar(Car car)
        {
            _carRepository.Upsert(car);
        }
    }
}
