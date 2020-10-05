using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [Table("tblSize")]
    public class Size
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength]
        public string Name { get; set; }
    }
}