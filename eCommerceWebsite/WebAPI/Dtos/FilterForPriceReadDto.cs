using System.ComponentModel.DataAnnotations;

namespace WebAPI.Dtos
{
    public class FilterForPriceReadDto
    {
        public float? MaxPriceFrom { get; set; }
        public float? MaxPriceTo { get; set; }
    }
}