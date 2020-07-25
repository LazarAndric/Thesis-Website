using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class FilterForCategoryReadDto
    {
        [Required]
        public int Id { get; set; }
    }
}