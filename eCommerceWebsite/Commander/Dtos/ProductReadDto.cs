using System.ComponentModel.DataAnnotations;
using Commander.Models;

namespace Commander.Dtos
{
    public class ProductReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string ImgUrl { get; set; }
        public int? ProductCategoryId { get; set; }
        public float NumberOfViews { get; set; }
        public float NumberOfBought { get; set; }
    }
}