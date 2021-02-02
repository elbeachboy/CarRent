using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.CarManagement.Application
{
    public class CarClassDTO
    {
        public int Id { get; set; }
        
        public int PricePerDay { get; set; }

        public string ClassType { get; set; }
    }
}
