using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class FilterForSizeReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Legth { get; set; }
    }
}