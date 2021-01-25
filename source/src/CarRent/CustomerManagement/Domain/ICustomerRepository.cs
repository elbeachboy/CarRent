namespace CarRent.CustomerManagement.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface ICustomerRepository
    {
        List<Customer> GetAll();
        List<Customer> FindById(Guid id);
        List<Customer> FindByName(string name);
        void Add(Customer customer);
        void Upsert(Customer customer);
        void Remove(Guid id);
        void Remove(Customer customer);
    }
}
