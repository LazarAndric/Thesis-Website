
using System;
using System.ComponentModel.DataAnnotations;

public class User
    {
        [Required(ErrorMessage = "Molimo Vas unesite ime...")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Molimo Vas unesite prezime...")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Molimo Vas unesite email...")]
        public string EMail { get; set; }
        [Required(ErrorMessage = "Molimo Vas unesite šifru...")]
        public string Password { get; set; }         
        public DateTime DateOfBirth { get; set; }        
        public int GenderId { get; set; }
       
        public string Adress { get; set; }
       
        public string AdressNumber { get; set; }
       
        public string Place { get; set; }
        
        public string Contry { get; set; }
       
        public string PostalCode { get; set; }
       
        public string PhoneNumber { get; set; }
       
        public DateTime DateOfRegistration { get; set; }
       
        public DateTime? LastLogin { get; set; }
}