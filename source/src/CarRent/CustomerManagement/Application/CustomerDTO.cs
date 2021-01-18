using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;

namespace CarRent.CustomerManagement.Application
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CustomerDTO
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Street { get; set; }
        
        public int ZipCodePlaceId { get; set; }
    }
}
