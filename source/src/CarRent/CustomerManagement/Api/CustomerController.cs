// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using System.Security.Cryptography.X509Certificates;
using CarRent.CustomerManagement.DbContext;
using CarRent.CustomerManagement.Domain;
using Microsoft.EntityFrameworkCore;

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

        private readonly CustomerDbContext _dbContext;
        public CustomerController(CustomerDbContext db)
        {
            this._dbContext = db;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public List<CustomerDTO> Get()
        {

            var list = new List<CustomerDTO>();
            //var customers = _dbContext.Customers.Include(x => x.).ToList();
            //foreach (var c in customers)
            //{
            //    var customer = new CustomerDTO();
            //    customer.Id = c.Id;
            //    customer.Name = c.Name;
            //    customer.Surname = c.Surname;
            //    customer.Street = c.Street;
            //    var zipCodePlace = new ZipCodePlaceDTO();
            //    zipCodePlace.Id = c.ZipCodePlace.Id;
            //    zipCodePlace.Place = c.ZipCodePlace.Place;
            //    zipCodePlace.ZipCode =  c.ZipCodePlace.ZipCode;


            //    list.Add(customer);
            //}
            return list;
        }


        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public CustomerDTO Get(Guid id)
        {
            var c = _dbContext.Customers.Include(x => x.ZipCodePlace).FirstOrDefault();
            var customer = new CustomerDTO();
            customer.Id = c.Id;
            customer.Name = c.Name;
            customer.Surname = c.Surname;
            customer.Street = c.Street;
            var zipCodePlace = new ZipCodePlaceDTO();
            zipCodePlace.Id = c.ZipCodePlace.Id;
            zipCodePlace.Place = c.ZipCodePlace.Place;
            zipCodePlace.ZipCode = c.ZipCodePlace.ZipCode;
            customer.ZipCodePlaceDto = zipCodePlace;
            return customer;
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

            _dbContext.Customers.Add(c);
            _dbContext.SaveChanges();
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
