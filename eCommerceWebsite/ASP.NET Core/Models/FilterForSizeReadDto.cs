using System.Collections.Generic;

public class FilterSizes
    {
        public List<FilterForSizeReadDto> sizesFilterList { get; set; }
    }
    
    public class FilterForSizeReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
    }