using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class FilterForPriceReadDto
    {
        public float PriceFrom { get; set; }
        public float PriceTo { get; set; }
        public float MaxPriceFrom { get; set; }
        public float MaxPriceTo { get; set; }
    }
}