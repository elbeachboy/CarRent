using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Application;
using CarRent.CustomerManagement.Application;

namespace CarRent.ReservationManagement.Application
{
    public class ReservationDTO
    {
        public Guid Id { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public int TotalDays { get; set; }

        public bool IsContract { get; set; }

        public int TotalCost { get; set; }

        public Guid CustomerId { get; set; }

        public Guid CarId { get; set; }

        public CustomerDTO CustomerDto { get; set; }

        public CarDTO CarDto { get; set; }
    }
}
