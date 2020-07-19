using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class Context :DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt){}

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories {get; set;}
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOfUser> ProductsOfUsers { get; set; }
    }
}