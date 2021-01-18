namespace CarRent.CustomerManagement.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface ICustomerRepository
    {

        Customer FindById(Guid id);
        IEnumerable<Customer> FindByName(string name);
        void Add(Customer customer);
        Customer Upsert(Customer customer);
        void Remove(Guid id);
        void Remove(Customer customer);
    }
}
