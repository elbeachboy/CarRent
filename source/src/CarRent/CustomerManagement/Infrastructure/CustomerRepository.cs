using System.Linq;
using CarRent.CustomerManagement.DbContext;
using Microsoft.EntityFrameworkCore;

namespace CarRent.CustomerManagement.Infrastructure
{
    using CarRent.CustomerManagement.Domain;
    using System;
    using System.Collections.Generic;

    public class CustomerRepository : ICustomerRepository
    {
        private readonly CarRentDBContext _dbContext;

        public CustomerRepository(CarRentDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Customer FindById(Guid id)
        {
            return _dbContext.Customers.Include(c => c.ZipCodePlace).FirstOrDefault(c => c.Id == id);
        }

        public List<Customer> FindByName(string name)
        {
            return _dbContext.Customers.Include(c => c.ZipCodePlace).Where(c => c.Name == name).ToList();
        }

        public void Add(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }

        public void Upsert(Customer customer)
        {
            _dbContext.Customers.Update(customer);
            _dbContext.SaveChanges();
        }

        public void Remove(Guid id)
        {
            _dbContext.Customers.Remove(_dbContext.Customers.Find(id));
            _dbContext.SaveChanges();
        }

        public void Remove(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            return _dbContext.Customers.Include(c => c.ZipCodePlace).ToList();
        }
    }
}
