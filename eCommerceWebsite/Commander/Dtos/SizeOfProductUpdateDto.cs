using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Commander.Models
{
    public class SizeOfProductUpdateDto
    {
        [Required]
        public int? ProductId { get; set; }
        [Required]
        public int? SizeId { get; set; }
    }
}