using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class FilterForPriceSearchDto
    {
        [Required]
        public float PriceFrom { get; set; }
        [Required]
        public float PriceTo { get; set; }
    }
}