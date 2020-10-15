    public class FiltersSearchDto
    {
    public string Search { get; set; }
    public FilterForPriceSearchDto PriceFilter { get; set; }
    public FilterForCategorySearchDto CategoryFilter { get; set; }
    public FilterForGenderSearchDto GenderFilter { get; set; }
    public FilterForSizeSearchDto SizeFilter { get; set; }
    public Sort SortItems { get; set; }
    public int pageNumber { get; set; } = 1;
}