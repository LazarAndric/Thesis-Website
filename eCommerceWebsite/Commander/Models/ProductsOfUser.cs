using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class ProductsOfUser
    {
        public Product product { get; set; }
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:dd/MM/yyyy}")]
        public string DateOfProductsBought { get; set; }
    }
}