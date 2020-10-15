
using System.ComponentModel.DataAnnotations;

public class LoginUserModel
    {
        [Required(ErrorMessage = "Molimo Vas unesite email...")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Molimo Vas unesite šifru...")]
        public string Password { get; set; }
    }