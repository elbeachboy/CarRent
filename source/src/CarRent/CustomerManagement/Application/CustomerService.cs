using System;
using System.Collections.Generic;
using System.Configuration;
using CarRent.CustomerManagement.Domain;

namespace CarRent.CustomerManagement.Application
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> GetAllCustomers()
        {
           return _customerRepository.GetAll();
        }

        public List<Customer> GetCustomerById(Guid id)
        {
            return _customerRepository.FindById(id);
        }

        public void AddCustomer(Customer customer)
        {
            _customerRepository.Add(customer);
        }

        public void DeleteCustomer(Guid id)
        {
            _customerRepository.Remove(id);
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerRepository.Upsert(customer);
        }

        public List<Customer> GetCustomerByName(string name)
        {
            return _customerRepository.FindByName(name);
        }
    }
}
