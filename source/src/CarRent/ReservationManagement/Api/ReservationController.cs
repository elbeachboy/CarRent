using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarRent.ReservationManagement.Application;
using CarRent.ReservationManagement.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.ReservationManagement.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        private readonly IMapper _mapper;

        public ReservationController(IReservationService reservationService, IMapper mapper)
        {
            _reservationService = reservationService;
            _mapper = mapper;
        }

        // GET: api/<ReservationController>
        [HttpGet]
        public List<ReservationDTO> Get()
        {
            var list = new List<ReservationDTO>();
            foreach (var reservation in _reservationService.GetAllReservations())
            {
                var reservationDto  = _mapper.Map<ReservationDTO>(reservation);
                list.Add(reservationDto);
            }

            return list;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public List<ReservationDTO> Get(Guid id)
        {
            var list = new List<ReservationDTO>();
            foreach (var reservation in _reservationService.GetReservationsById(id))
            {
                var reservationDto  = _mapper.Map<ReservationDTO>(reservation);
                list.Add(reservationDto);
            }

            return list;
        }

        // POST api/<ReservationController>
        [HttpPost]
        public void Post([FromBody]Reservation reservation)
        {
            var r = _mapper.Map<Reservation>(reservation);
            _reservationService.AddReservation(r);
        }

        // PUT api/<ReservationController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Reservation reservation)
        {
            var r = _mapper.Map<Reservation>(reservation);
            _reservationService.UpdateReservation(r);
        }

        // DELETE api/<ReservationController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _reservationService.DeleteReservation(id);
        }
    }
}
