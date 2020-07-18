using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class UserCreateDto
    {
        [Required]
        [MaxLength]
        public string FirstName { get; set; }
        [Required]
        [MaxLength]
        public string LastName { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string AdressNumber { get; set; }
        [Required]
        public string Place { get; set; }
        [Required]
        public string Contry { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        [Required]
        public string EMail { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string DateOfBirth { get; set; }
    }
}