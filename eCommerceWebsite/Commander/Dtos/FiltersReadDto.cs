using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class FiltersReadDto
    {
        public FilterForPriceReadDto PriceFilter { get; set; }
        public FilterForCategoriesReadDto CategoriesFilter { get; set; }
        public FilterForGenderReadDto GenderFilter { get; set; }
        public FilterForSizeReadDto SizeFilter { get; set; }
    }
}