using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarRent.CarManagement.Application;
using CarRent.CarManagement.Domain;
using CarRent.CustomerManagement.Application;
using CarRent.CustomerManagement.Domain;

namespace CarRent.Common.Mapper
{
    public class AutomapperProfile
    {
        public class AutoMapperProfile : Profile  
        {  
            public AutoMapperProfile()
            {
                CreateMap<Customer, CustomerDTO>().ForMember(dest => dest.ZipCodePlaceDto,
                    opt => opt.MapFrom(src => src.ZipCodePlace));
                CreateMap<ZipCodePlace, ZipCodePlaceDTO>();

                CreateMap<CustomerDTO, Customer>();

                CreateMap<Car, CarDTO>().ForMember(dest => dest.CarClassDto,
                    opt => opt.MapFrom(src => src.CarClass));
                CreateMap<CarClass, CarClassDTO>();

                CreateMap<CarDTO, Car>();

            }  
        }  
    }
}
