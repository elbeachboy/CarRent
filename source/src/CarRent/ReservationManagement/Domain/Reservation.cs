using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Domain;
using CarRent.CustomerManagement.Domain;

namespace CarRent.ReservationManagement.Domain
{
    public class Reservation
    {
        public Guid Id { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public int TotalDays { get; set; }

        public bool IsContract { get; set; }

        public Guid CustomerId { get; set; }

        public Guid CarId { get; set; }

        public Customer Customer { get; set; }

        public Car Car{ get; set; }



    }
}
