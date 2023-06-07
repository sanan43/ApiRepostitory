using AutoMapper;
using TaskWebAPI.Entities;
using TaskWebAPI.Entities.Dtos.Cars;

namespace TaskWebAPI.Profiles
{
    public class CarProfile:Profile
    {
        public CarProfile()
        {
            //CreateMap<Car, CreateCarDto>();
            CreateMap<UpdateCarDto, Car>();
            CreateMap<CreateCarDto, Car>();
        }
    }
}
