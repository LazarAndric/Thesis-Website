using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class FilterForGenderReadDto
    {
        [Required]
        public float[] Id { get; set; }
    }
}