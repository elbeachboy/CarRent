using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarRent.CarManagement.Application;
using CarRent.CarManagement.Domain;
using CarRent.CustomerManagement.Application;
using CarRent.CustomerManagement.Domain;
using CarRent.ReservationManagement.Application;
using CarRent.ReservationManagement.Domain;

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

                CreateMap<Reservation, ReservationDTO>()
                    .ForMember(dest => dest.CustomerDto, opt => opt.MapFrom(src => src.Customer))
                    .ForMember(dest => dest.CarDto, opt => opt.MapFrom(src => src.Car));
                CreateMap<ReservationDTO, Reservation>();

            }  
        }  
    }
}
