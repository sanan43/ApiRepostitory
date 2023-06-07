using AutoMapper;
using TaskWebAPI.Entities.Auth;
using TaskWebAPI.Entities.Dtos.Auth;

namespace TaskWebAPI.Profiles
{
    public class AuthProfile:Profile
    {
        public AuthProfile()
        {
            CreateMap<RegisterDto, AppUser>();
            CreateMap<LoginDto, AppUser>();
        }
    }
}
