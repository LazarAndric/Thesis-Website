using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

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
        public int? ProductCategoryId { get; set; }

        [ForeignKey("ProductCategoryId")]
        public Category ProductCategory { get; set; }
        [Required]
        public float? Price { get; set; }
        // [Required]
        // public int Quantity{get; set;}
        [Range(0,100)]
        public int? Sale {get;set;}
        public string ImgUrl { get; set; }
        public float NumberOfViews { get; set; }
        public float NumberOfPurchases { get; set; }
        public DateTime DateOfCreate { get; set; }
        public bool IsShowInShop { get; set; }
    }
}