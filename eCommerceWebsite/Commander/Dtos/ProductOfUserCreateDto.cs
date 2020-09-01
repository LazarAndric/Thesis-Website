using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Commander.Models;
using System;

namespace Commander.Dtos
{
    public class ProductOfUserCreateDto
    {
        [Required]
        public int? UserId { get; set; }
        [Required]
        public int? ProductId { get; set; }
        public DateTime DateOfProductPurchased { get; set; }
    }
}