using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    [Table("tblProduct")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength]
        public string Name { get; set; }
        [MaxLength]
        public string Description{get;set;}
        [Required]
        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        [Required]
        public float? Price { get; set; }
        public bool IsOnSale { get; set; }
        [Range(0,100)]
        public int Sale {get;set;}
        public string ImgUrl { get; set; }
        public int NumberOfViews { get; set; }
        public int NumberOfPurchases { get; set; }
        public DateTime? DateOfCreate { get; set; }

        public bool IsShowInShop { get; set; }
    }
}