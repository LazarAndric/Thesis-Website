
using System;

public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GenderId{get;set;}
        public Gender Gender{get;set;}
        public string Adress { get; set; }
        public string AdressNumber { get; set; }
        public string Place { get; set; }
        public string Contry { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public DateTime? LastLogin { get; set; }
    }