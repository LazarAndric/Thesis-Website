using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class FilterForSizeSearchDto
    {
        [Required]
        public int[] Id { get; set; }
    }
}