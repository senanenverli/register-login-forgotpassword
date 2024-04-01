using Microsoft.AspNetCore.Identity;

namespace WebApplication5.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }
    }
}
