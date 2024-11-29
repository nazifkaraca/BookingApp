using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace BookingApp.WebApi.Models
{
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
