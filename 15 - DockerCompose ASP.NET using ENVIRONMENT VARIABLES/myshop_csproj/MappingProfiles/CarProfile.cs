using AutoMapper;
using MyShop.Models;
using MyShop.dtos;

namespace MyShop.MappingProfiles{


    public class CarProfile:Profile{
        public CarProfile()
        {
            CreateMap<Car, CarReadDTO>();
            CreateMap<CarWriteDTO, Car>();
            CreateMap<CarUpdateDTO, Car>();

        }
        
    }

}