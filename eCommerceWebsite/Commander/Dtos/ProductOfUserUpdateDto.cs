using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Commander.Models;

namespace Commander.Dtos
{
    public class ProductOfUserUpdateDto
    {
        [Required]
        public int? UserId { get; set; }
        [Required]
        public int? ProductId { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:dd/MM/yyyy}")]
        public string DateOfProductPurchased { get; set; }
    }
}