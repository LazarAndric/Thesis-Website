using System.ComponentModel.DataAnnotations;
using WebAPI.Models;

namespace WebAPI.Dtos
{
    public class CategoryReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}