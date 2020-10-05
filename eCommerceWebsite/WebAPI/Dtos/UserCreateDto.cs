using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace WebAPI.Dtos
{
    public class UserCreateDto
    {
        [Required]
        [MaxLength]
        public string FirstName { get; set; }
        [Required]
        [MaxLength]
        public string LastName { get; set; }
        [EmailAddress]
        [Required]
        public string EMail { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public int GenderId{get;set;}
        public string Adress { get; set; }
        public string AdressNumber { get; set; }
        public string Place { get; set; }
        public string Contry { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public DateTime? LastLogin { get; set; }
    }
}