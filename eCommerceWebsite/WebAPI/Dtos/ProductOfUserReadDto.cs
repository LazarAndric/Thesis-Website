using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAPI.Models;
using System;

namespace WebAPI.Dtos
{
    public class ProductOfUserReadDto
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ProductId { get; set; }
        public DateTime DateOfProductPurchased { get; set; }
    }
}