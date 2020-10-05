using System.ComponentModel.DataAnnotations;

namespace WebAPI.Dtos
{
    public class FilterForPriceSearchDto
    {
        public float PriceFrom { get; set; }
        public float PriceTo { get; set; }
    }
}