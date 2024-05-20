using Microsoft.AspNetCore.Mvc;

namespace lab15.ViewModels
{
    public class CreateUserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int Year { get; set; }
    }
}
