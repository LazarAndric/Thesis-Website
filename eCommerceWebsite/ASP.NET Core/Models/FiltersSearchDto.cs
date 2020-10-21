using System.Collections.Generic;

public class FiltersSearchDto
{
    public string Search { get; set; }
    public FilterForPriceSearchDto PriceFilter { get; set; }
    public FilterForCategorySearchDto CategoryFilter { get; set; }
    public FilterForGenderSearchDto GenderFilter { get; set; }
    public FilterForSizeSearchDto SizeFilter { get; set; }
    public Sort SortItems { get; set; }
    public int PageNumber { get; set; } = 1;
    public int ProductForViewId { get; set; }
    public List<int> ChategoriesId { get; set; }
}