using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Commander.Models;
using System;

namespace Commander.Dtos
{
    public class ProductOfUserReadDto
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ProductId { get; set; }
        public DateTime DateOfProductPurchased { get; set; }
    }
}