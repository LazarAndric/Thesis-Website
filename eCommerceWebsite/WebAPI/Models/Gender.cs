using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [Table("tblGender")]
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength]
        public string Name { get; set; }
    }
}