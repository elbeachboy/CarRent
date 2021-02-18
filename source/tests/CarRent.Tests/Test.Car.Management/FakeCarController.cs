using System;
using System.Collections.Generic;
using CarRent.CarManagement.Application;

namespace CarRent.Tests.TestCarManagement
{
    public class FakeCarController
    {
        private CarDTO _car = new CarDTO();
        private CarClassDTO _carClassDto = new CarClassDTO();
        private Guid testGuid = Guid.NewGuid();

        private List<CarDTO> _carList = new List<CarDTO>();
        public FakeCarController()
        {
            this._carClassDto.Id = 1;
            this._carClassDto.ClassType = "Luxusklasse";
            this._carClassDto.PricePerDay = 50;


            this._car.Id = testGuid;
            this._car.Brand = "Volkswagen";
            this._car.Type = "Golf R";
            this._car.CarClassId = 1;
            this._car.CarClassDto = _carClassDto;

            this._carList.Add(_car);
        }

        public List<CarDTO> Get()
        {
            return _carList;
        }
    }
}
