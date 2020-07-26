using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class FiltersReadDto
    {
        public FilterForPriceSearchDto PriceFilter { get; set; }
        public FilterForCategorySearchDto CategoryFilter { get; set; }
        public FilterForGenderSearchDto GenderFilter { get; set; }
        public FilterForSizeSearchDto SizeFilter { get; set; }
    }
}