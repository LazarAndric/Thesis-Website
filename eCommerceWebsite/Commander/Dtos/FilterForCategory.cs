using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class FilterForCategory
    {
        [Required]
        public int Id { get; set; }
    }
}