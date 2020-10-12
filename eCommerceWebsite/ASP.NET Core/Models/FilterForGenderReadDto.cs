
using System.Collections.Generic;

public class GendersFilter
    {
        public List<FilterForGenderReadDto> GenderList { get; set; }
    }
    public class FilterForGenderReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
    }