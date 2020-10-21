
using System;
using System.ComponentModel.DataAnnotations;

public class User
    {
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string EMail { get; set; }
    
    public string Password { get; set; }
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
    
    public int GenderId { get; set; }

    public string Adress { get; set; }
       
    public string AdressNumber { get; set; }
       
    public string Place { get; set; }
        
    public string Contry { get; set; }
       
    public string PostalCode { get; set; }
       
    public string PhoneNumber { get; set; }
}