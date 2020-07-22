using System.ComponentModel.DataAnnotations;
using Commander.Models;
using System;

namespace Commander.Dtos
{
    public class ProductUpdateDto
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
        public float NumberOfViews { get; set; }
        public float NumberOfPurchases { get; set; }
        public bool IsShowInShop { get; set; }
    }
}