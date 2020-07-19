using System.ComponentModel.DataAnnotations;
using Commander.Models;

namespace Commander.Dtos
{
    public class CategoryCreateDto
    {
        [Required]
        [MaxLength]
        public string Name { get; set; }
    }
}