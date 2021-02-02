using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.CarManagement.Application
{
    public class CarDTO
    {
        public Guid Id { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        public int CarClassId { get; set; }
        
        public CarClassDTO CarClassDto { get; set; }
    }
}
