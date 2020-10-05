using WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data
{
    public class Context :DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt){}

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories {get; set;}
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOfUser> ProductsOfUsers { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<SizeOfProduct> SizeOfProducts { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<GenderOfProduct> GendersOfProducts { get; set; }
    }
}