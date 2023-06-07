using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TaskWebAPI.Entities.Dtos.Cars;
using TaskWebAPI.Entities;
using TaskWebAPI.Entities.Dtos.Brands;

namespace TaskWebAPI.Profiles
{
    public class BrandProfile:Profile
    {
        public BrandProfile()
        {
            CreateMap<UpdateBrandDto, Brand>();
            CreateMap<CreateBrandDto, Brand>();
        }
    }
}
