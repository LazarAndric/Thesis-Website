using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class UserUpdateDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
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
        public string EMail { get; set; }
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:dd/MM/yyyy}")]
        public string DateOfBirth { get; set; }
    }
}