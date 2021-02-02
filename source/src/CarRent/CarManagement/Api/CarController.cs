using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarRent.CarManagement.Application;
using CarRent.CarManagement.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.CarManagement.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        private readonly IMapper _mapper;

        public CarController(ICarService carService, IMapper mapper)
        {
            _carService = carService;
            _mapper = mapper;
        }

        // GET: api/<CarController>
        [HttpGet]
        public List<CarDTO> Get()
        {
            var list = new List<CarDTO>();
            foreach (var car in _carService.GetAllCars())
            {
                var carDto  = _mapper.Map<CarDTO>(car);
                list.Add(carDto);
            }

            return list;
        }

        // GET api/<CarController>/5
        [HttpGet("CarById/{id}")]
        public List<CarDTO> Get(Guid id)
        {
            var list = new List<CarDTO>();
            foreach (var car in _carService.GetCarByID(id))
            {
                var carDto  = _mapper.Map<CarDTO>(car);
                list.Add(carDto);
            }

            return list;
        }
        // GET api/<CarController>/Vw
        [HttpGet("CarById/{type}")]
        public List<CarDTO> Get(string type)
        {
            var list = new List<CarDTO>();
            foreach (var car in _carService.GetCarByType(type))
            {
                var carDto  = _mapper.Map<CarDTO>(car);
                list.Add(carDto);
            }

            return list;
        }

        // POST api/<CarController>
        [HttpPost]
        public void Post([FromBody] CarDTO car)
        {
            var c =_mapper.Map<Car>(car);
            _carService.AddCar(c);
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] CarDTO car)
        {
            var c =_mapper.Map<Car>(car);
            _carService.UpdateCar(c);
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _carService.DeleteCarById(id);
        }
    }
}
