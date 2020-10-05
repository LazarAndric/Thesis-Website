using System.ComponentModel.DataAnnotations;
using WebAPI.Models;
using System;

namespace WebAPI.Dtos
{
    public class ProductUpdateDto
    {
        [Required]
        [MaxLength]
        public string Name { get; set; }
        public string Description{get;set;}
        [Required]
        public int? ProductCategoryId { get; set; }
        [Required]
        public float? Price { get; set; }
        public bool IsOnSale { get; set; }
        [Range(0,100)]
        public int Sale {get;set;}
        public string ImgUrl { get; set; }
        public int NumberOfViews { get; set; }
        public int NumberOfPurchases { get; set; }
        public bool IsShowInShop { get; set; }
    }
}