using System.ComponentModel.DataAnnotations;
using System;
using Commander.Models;

namespace Commander.Dtos
{
    public class ProductCreateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public float? Price { get; set; }
        [Range(0,100)]
        public int? Sale {get;set;}
        [Required]
        public string ImgUrl { get; set; }  
        public int? ProductCategoryId { get; set; }
        public DateTime DateOfCreate{get; set;}
    }
}