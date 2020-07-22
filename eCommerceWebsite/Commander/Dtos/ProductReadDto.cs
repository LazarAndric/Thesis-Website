using System.ComponentModel.DataAnnotations;
using Commander.Models;
using System;

namespace Commander.Dtos
{
    public class ProductReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ProductCategoryId { get; set; }
        public float? Price { get; set; }
        public int Sale {get;set;}
        public string ImgUrl { get; set; }
        public float NumberOfViews { get; set; }
        public float NumberOfPurchases { get; set; }
        public DateTime DateOfCreate { get; set; }
        public bool IsShowInShop { get; set; }
    }
}