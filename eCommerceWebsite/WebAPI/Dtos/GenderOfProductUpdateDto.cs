using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace WebAPI.Models
{
    public class GenderOfProductUpdateDto
    {
        [Required]
        public int? ProductId { get; set; }
        [Required]
        public int? GenderId { get; set; }
    }
}