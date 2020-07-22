using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Commander.Models
{
    public class GenderOfProductReadDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int? ProductId { get; set; }
        [Required]
        public int? GenderId { get; set; }
    }
}