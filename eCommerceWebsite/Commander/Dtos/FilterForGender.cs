using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class FilterForGender
    {
        [Required]
        public float[] Id { get; set; }
    }
}