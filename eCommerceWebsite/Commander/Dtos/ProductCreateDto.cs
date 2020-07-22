using System.ComponentModel.DataAnnotations;
using System;
using Commander.Models;

namespace Commander.Dtos
{
    public class ProductCreateDto
    {
        [Required]
        [MaxLength]
        public string Name { get; set; }
        [Required]
        public int? ProductCategoryId { get; set; }
        [Required]
        public float? Price { get; set; }
        [Range(0,100)]
        public int Sale {get;set;}
        public string ImgUrl { get; set; }
        public DateTime DateOfCreate { get; set; }
        public bool IsShowInShop { get; set; }
    }
}