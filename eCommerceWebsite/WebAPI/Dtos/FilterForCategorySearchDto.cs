using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebAPI.Dtos
{
    public class FilterForCategorySearchDto
    {
        public List<int> ChategoriesId { get; set; }
    }
}