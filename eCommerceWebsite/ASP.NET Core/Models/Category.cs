using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commander.Models
{
    [Table("tblCategory")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength]
        public string Name { get; set; }
    }
}