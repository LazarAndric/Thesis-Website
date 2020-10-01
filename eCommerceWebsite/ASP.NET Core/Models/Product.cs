using System;

public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description{get;set;}
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public float? Price { get; set; }
        // [Required]
        // public int Quantity{get; set;}
        public bool IsOnSale { get; set; }
        public int Sale {get;set;}
        public string ImgUrl { get; set; }
        public int NumberOfViews { get; set; }
        public int NumberOfPurchases { get; set; }
        public DateTime DateOfCreate { get; set; }
        public bool IsShowInShop { get; set; }
    }