using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commander.Models
{
    public class GenderUpdateDto
    {
        [Required]
        [MaxLength]
        public string Name { get; set; }
    }
}