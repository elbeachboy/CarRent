using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.CarManagement.Domain
{
    public class Car
    {
        public Guid Id { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        public int CarCLassId { get; set; }
        
        public CarClass CarClass { get; set; }
    }
}
