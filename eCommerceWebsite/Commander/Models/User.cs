using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commander.Models
{
    [Table("tblUser")]
    public class User
    {
        [Key]
        public int Id { get; set; }
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
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:dd/MM/yyyy}")]
        public string DateOfBirth { get; set; }
        
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:dd/MM/yyyy}")]
        public string DateOfRegistration { get; set; }
        
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:dd/MM/yyyy}")]
        public string LastLogin { get; set; }
    }
}