using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class GenderReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}