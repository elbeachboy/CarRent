using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRent.CustomerManagement.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class Customer
    {
        private string _name;
        private string _surname;
        private string _street;
        private int _zipCodePlaceId;
        private Guid _id;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }
        public string Street
        {
            get => _street;
            set => _street = value;
        }
        public Guid Id
        {
            get => _id;
            set => _id = value;
        }
        public int ZipCodePlaceId
        {
            get => _zipCodePlaceId;
            set => _zipCodePlaceId = value;
        }
    }
}
