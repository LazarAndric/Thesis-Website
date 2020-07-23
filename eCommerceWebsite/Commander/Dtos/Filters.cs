using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class Filters
    {
        [Required]
        public FilterForPrice PriceFilter { get; set; }
        [Required]
        public FilterForCategory CategoryFilter { get; set; }
        [Required]
        public FilterForGender GenderFilter { get; set; }
    }
}