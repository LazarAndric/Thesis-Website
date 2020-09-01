using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class FilterForPriceReadDto
    {
        public float? MaxPriceFrom { get; set; }
        public float? MaxPriceTo { get; set; }
    }
}