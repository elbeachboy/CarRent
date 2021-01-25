// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using System.Security.Cryptography.X509Certificates;
using AutoMapper;
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

        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            this._customerService = customerService;
            this._mapper = mapper;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public List<CustomerDTO> Get()
        {
           var list = new List<CustomerDTO>();
           foreach (var customer in _customerService.GetAllCustomers())
           {
               var customerDTO  = _mapper.Map<CustomerDTO>(customer);
               list.Add(customerDTO);
           }

           return list;
        }

        // GET api/<CustomerController>
        [HttpGet("CustomerByName/{name}")]
        public List<CustomerDTO> Get(string name)
        {
            var list = new List<CustomerDTO>();
            foreach (var customer in _customerService.GetCustomerByName(name))
            {
                var customerDTO  = _mapper.Map<CustomerDTO>(customer);
                list.Add(customerDTO);
            }

            return list;
        }

        // GET api/<CustomerController>
        [HttpGet("CustomerById/{id}")]
        public List<CustomerDTO> Get(Guid id)
        {
            var list = new List<CustomerDTO>();
            foreach (var customer in _customerService.GetCustomerById(id))
            {
                var customerDTO  = _mapper.Map<CustomerDTO>(customer);
                list.Add(customerDTO);
            }

            return list;
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] CustomerDTO customer)
        {
            var c =_mapper.Map<Customer>(customer);
            _customerService.AddCustomer(c);
        }

        // PUT api/<CustomerController>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] CustomerDTO customer)
        {
            var c =_mapper.Map<Customer>(customer);
            _customerService.UpdateCustomer(c);
        }

        // DELETE api/<CustomerController>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _customerService.DeleteCustomer(id);
        }
    }
}
