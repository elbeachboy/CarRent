using CarRent.CustomerManagement.Domain;

namespace CarRent.CustomerManagement.Application
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();

        Customer GetCustomerById(Guid id);

        List<Customer> GetCustomerByName(string name);

        void AddCustomer(Customer customer);

        void DeleteCustomer(Guid id);

        void UpdateCustomer(Customer customer);
    }
}
