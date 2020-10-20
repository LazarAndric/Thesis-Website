using System.ComponentModel.DataAnnotations;
using System;
using WebAPI.Models;

namespace WebAPI.Dtos
{
    public class ProductCreateDto
    {
        [Required]
        [MaxLength]
        public string Name { get; set; }
        [MaxLength]
        public string Description{get;set;}
        [Required]
        public int? CategoryId { get; set; }
        [Required]
        public float? Price { get; set; }
        public bool IsOnSale { get; set; }
        [Range(0,100)]
        public int Sale {get;set;}
        public string ImgUrl { get; set; }
        public DateTime DateOfCreate { get; set; }
        public bool IsShowInShop { get; set; }
        public int?[] listOfSize{get;set;}
    }
}