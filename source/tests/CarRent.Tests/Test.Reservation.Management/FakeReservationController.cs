using System;
using System.Collections.Generic;
using CarRent.CarManagement.Application;
using CarRent.CustomerManagement.Application;
using CarRent.ReservationManagement.Application;

namespace CarRent.Tests
{
    public class FakeReservationController
    {
        private ReservationDTO _reservationDto = new ReservationDTO();
        private CustomerDTO _customerDto = new CustomerDTO();
        private ZipCodePlaceDTO _zipCodePlaceDto = new ZipCodePlaceDTO();
        private CarDTO _carDto = new CarDTO();
        private CarClassDTO _carClassDto = new CarClassDTO();
        private Guid _testGuidCustomer = Guid.NewGuid();
        private Guid _testGuidCar = Guid.NewGuid();
        private Guid _testGuidReservation = Guid.NewGuid();

        private List<ReservationDTO> _reservationList = new List<ReservationDTO>();
        public FakeReservationController()
        {
            this._zipCodePlaceDto.Id = 1;
            this._zipCodePlaceDto.Place = "Goldach";
            this._zipCodePlaceDto.ZipCode = 9403;


            this._customerDto.Id = _testGuidCustomer;
            this._customerDto.Name = "Scherer";
            this._customerDto.Surname = "Simon";
            this._customerDto.Street = "Musterstrasse 95";
            this._customerDto.ZipCodePlaceId = 1;
            this._customerDto.ZipCodePlaceDto = _zipCodePlaceDto;

            this._carClassDto.Id = 1;
            this._carClassDto.ClassType = "Luxusklasse";
            this._carClassDto.PricePerDay = 50;


            this._carDto.Id = _testGuidCar;
            this._carDto.Brand = "Volkswagen";
            this._carDto.Type = "Golf R";
            this._carDto.CarClassId = 1;
            this._carDto.CarClassDto = _carClassDto;

            this._reservationDto.Id = _testGuidReservation;
            this._reservationDto.StartDateTime = new DateTime(2021,2,18);
            this._reservationDto.EndDateTime = new DateTime(2021,2,28);
            this._reservationDto.TotalDays = 10;
            this._reservationDto.TotalCost = 10 * this._carClassDto.PricePerDay;
            this._reservationDto.CarDto = _carDto;
            this._reservationDto.CustomerDto = _customerDto;
            this._reservationDto.CarId = _testGuidCar;
            this._reservationDto.CustomerId = _testGuidCustomer;
            this._reservationDto.IsContract = true;


            this._reservationList.Add(_reservationDto);
        }

        public List<ReservationDTO> Get()
        {
            return _reservationList;
        }
    }
}
