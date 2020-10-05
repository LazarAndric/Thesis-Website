using System.Collections.Generic;
using WebAPI.Models;
using WebAPI.Data;

namespace WebAPI.Data
{
    public interface IProductOfUserRepo
    {
        bool SaveChanges();

        IEnumerable<ProductOfUser> GetAllProductOfUsers();
        ProductOfUser GetProductOfUserById(int id);
        IEnumerable<ProductOfUser> GetProductsOfUserById(int id);
        void CreateProductOfUser(ProductOfUser productOfUser);
        void UpdateProductOfUser(ProductOfUser productOfUser);
        void DeleteProductOfUser(ProductOfUser productOfUser);
    }
    
}
