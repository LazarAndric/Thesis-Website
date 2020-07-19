using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class UserReadDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string AdressNumber { get; set; }
        public string Place { get; set; }
        public string Contry { get; set; }
        public string PostalCode { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string EMail { get; set; }
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:dd/MM/yyyy}")]
        public string DateOfBirth { get; set; }
        
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:dd/MM/yyyy}")]
        public string LastLogin { get; set; }
    }
}