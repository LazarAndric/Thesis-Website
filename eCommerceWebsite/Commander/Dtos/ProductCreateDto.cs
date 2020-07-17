using System.ComponentModel.DataAnnotations;
using Commander.Models;

namespace Commander.Dtos
{
    public class ProductCreateDto
    {
        [Required]
        [MaxLength]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public string ImgUrl { get; set; }

        public int? ProductCategoryId { get; set; }

        public float NumberOfViews { get; set; }
        public float NumberOfBought { get; set; }
    }
}