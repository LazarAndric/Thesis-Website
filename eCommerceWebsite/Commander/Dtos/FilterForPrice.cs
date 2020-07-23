using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class FilterForPrice
    {
        [Required]
        public float PriceFrom { get; set; }
        [Required]
        public float PriceTo { get; set; }
    }
}