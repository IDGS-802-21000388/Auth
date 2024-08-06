using Microsoft.AspNetCore.Identity;

namespace AuthAPI_902.Models
{
    public class AppUser : IdentityUser
    {
        public string? FullName { get; set; } // para agregar mas datos al modelo de IdentityUser
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
