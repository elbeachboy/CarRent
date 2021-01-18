// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using CarRent.CustomerManagement.DbContext;
using CarRent.CustomerManagement.Domain;

namespace CarRent.CustomerManagement.Api
{
    using CarRent.CustomerManagement.Application;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly CustomerDbContext db;

        public CustomerController(ICustomerService customerService, CustomerDbContext db)
        {
            _customerService = customerService;
            this.db = db;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public List<CustomerDTO> Get()
        {

            var customers = from c in db.Customers
                            select new CustomerDTO()
                            {
                                Id = c.Id,
                                Name = c.Name,
                                Surname = c.Surname,
                                Street = c.Street,
                                ZipCodePlaceId = c.ZipCodePlaceId
                            };
            return customers.ToList();
        }


        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public CustomerDTO Get(int id)
        {
            return new CustomerDTO();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] CustomerDTO customer)
        {
            var c = new Customer();
            c.Id = Guid.NewGuid();
            c.Name = customer.Name;
            c.Surname = customer.Surname;
            c.Street = customer.Street;
            c.ZipCodePlaceId = customer.ZipCodePlaceId;

            db.Customers.Add(c);
            db.SaveChanges();
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CustomerDTO customer)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
