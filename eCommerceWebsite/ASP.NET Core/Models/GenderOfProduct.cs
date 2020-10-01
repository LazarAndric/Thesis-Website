using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Commander.Models
{
    [Table("tblProductGender")]
    public class GenderOfProduct
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [Required]
        public int? GenderId { get; set; }
        [ForeignKey("GenderId")]
        public Gender Gender { get; set; }
    }
}