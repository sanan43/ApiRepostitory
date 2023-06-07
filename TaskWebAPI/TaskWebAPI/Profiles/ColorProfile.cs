using AutoMapper;
using TaskWebAPI.Entities.Dtos.Cars;
using TaskWebAPI.Entities;
using TaskWebAPI.Entities.Dtos.Colors;

namespace TaskWebAPI.Profiles
{
    public class ColorProfile:Profile
    {
        public ColorProfile()
        {
            CreateMap<UpdateColorDto, Color>();
            CreateMap<CreateColorDto, Color>();
        }
    }
}
