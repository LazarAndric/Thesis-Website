using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class LoginModel
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}