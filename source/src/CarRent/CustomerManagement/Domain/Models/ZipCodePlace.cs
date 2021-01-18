using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.CustomerManagement.Domain.Models
{
    public class ZipCodePlace
    {
        private int _id;
        private int _zipCode;
        private string _place;

        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public int ZipCode
        {
            get => _zipCode;
            set => _zipCode = value;
        }
        public string Place
        {
            get => _place;
            set => _place = value;
        }
    }
}
