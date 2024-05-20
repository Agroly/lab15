using Microsoft.AspNetCore.Identity;

namespace lab15.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
