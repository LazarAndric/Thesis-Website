using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class FiltersReadDto
    {
        [Required]
        public FilterForPriceSearchDto PriceFilter { get; set; }
        [Required]
        public FilterForCategorySearchDto CategoryFilter { get; set; }
        [Required]
        public FilterForGenderSearchDto GenderFilter { get; set; }
        [Required]
        public FilterForSizeSearchDto SizeFilter { get; set; }
    }
}