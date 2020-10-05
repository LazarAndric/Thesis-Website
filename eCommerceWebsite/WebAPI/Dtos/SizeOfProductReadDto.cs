using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace WebAPI.Models
{
    public class SizeOfProductReadDto
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? SizeId { get; set; }
    }
}