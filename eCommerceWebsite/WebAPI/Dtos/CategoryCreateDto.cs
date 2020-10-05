using System.ComponentModel.DataAnnotations;
using WebAPI.Models;

namespace WebAPI.Dtos
{
    public class CategoryCreateDto
    {
        [Required]
        [MaxLength]
        public string Name { get; set; }
    }
}