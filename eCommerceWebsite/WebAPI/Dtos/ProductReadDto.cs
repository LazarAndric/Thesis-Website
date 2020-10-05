using System.ComponentModel.DataAnnotations;
using WebAPI.Models;
using System;
using System.Collections.Generic;

namespace WebAPI.Dtos
{
    public class ProductReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description{get;set;}
        public Category Category { get; set; }
        public List<Size> Size {get; set;}
        public List<Gender> Genders {get; set;}
        public float? Price { get; set; }
        public bool IsOnSale { get; set; }
        public int Sale {get;set;}
        public string ImgUrl { get; set; }
        public int NumberOfViews { get; set; }
        public int NumberOfPurchases { get; set; }
        public DateTime DateOfCreate { get; set; }
        public bool IsShowInShop { get; set; }
    }
}