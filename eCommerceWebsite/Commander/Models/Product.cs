using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commander.Models
{
    [Table("tblProduct")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public string ImgUrl { get; set; }

        public int? ProductCategoryId { get; set; }

        [ForeignKey("ProductCategoryId")]
        public Category ProductCategory { get; set; }

        public float NumberOfViews { get; set; }
        public float NumberOfBought { get; set; }
    }
}