using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class FilterForPriceSearchDto
    {
        public float PriceFrom { get; set; }
        public float PriceTo { get; set; }
    }
}