using System;
using System.Collections.Generic;
using CarRent.CustomerManagement.Application;

namespace CarRent.Tests.TestCustomerManagement
{
    public class FakeCustomerController
    {
        private CustomerDTO _customer = new CustomerDTO();
        private ZipCodePlaceDTO _zipCodePlaceDto = new ZipCodePlaceDTO();
        private Guid testGuid = Guid.NewGuid();

        private List<CustomerDTO> _customerList = new List<CustomerDTO>();
        public FakeCustomerController()
        {
            this._zipCodePlaceDto.Id = 1;
            this._zipCodePlaceDto.Place = "Goldach";
            this._zipCodePlaceDto.ZipCode = 9403;


            this._customer.Id = testGuid;
            this._customer.Name = "Scherer";
            this._customer.Surname = "Simon";
            this._customer.Street = "Musterstrasse 95";
            this._customer.ZipCodePlaceId = 1;
            this._customer.ZipCodePlaceDto = _zipCodePlaceDto;

            this._customerList.Add(_customer);
        }

        public List<CustomerDTO> Get()
        {
            return _customerList;
        }
    }
}
