using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace WebAPI.Models
{
    [Table("tblProductSize")]
    public class SizeOfProduct
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [Required]
        public int? SizeId { get; set; }
        [ForeignKey("SizeId")]
        public Size Size { get; set; }
    }
}