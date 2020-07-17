using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Commander.Models
{
    public class UserProducts
    {
        public User user { get; set; }
        public List<ProductsOfUser> products{ get; set; }

    }
}