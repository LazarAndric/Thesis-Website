using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class FilterForCategorySearchDto
    {
        [Required]
        public int Id { get; set; }
    }
}