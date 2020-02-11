using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Undergraduate_thesis.Models
{
    public class FormAdress
    {
        [Required]
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string City { get; set;}
        public string House { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
