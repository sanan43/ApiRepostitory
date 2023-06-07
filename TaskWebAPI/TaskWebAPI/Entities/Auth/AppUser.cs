using Microsoft.AspNetCore.Identity;

namespace TaskWebAPI.Entities.Auth
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
    }
}
