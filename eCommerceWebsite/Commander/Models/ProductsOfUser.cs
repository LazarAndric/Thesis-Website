using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commander.Models
{
    [Table("tblUserProduct")]
    public class ProductOfUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        [Required]
        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product product { get; set; }
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:dd/MM/yyyy}")]
        public string DateOfProductPurchased { get; set; }
    }
}