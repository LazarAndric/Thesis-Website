using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class FilterForGenderSearchDto
    {
        [Required]
        public float[] Id { get; set; }
    }
}