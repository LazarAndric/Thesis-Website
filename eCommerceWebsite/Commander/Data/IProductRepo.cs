using System.Collections.Generic;
using Commander.Models;
using Commander.Dtos;

namespace Commander.Data
{
    public interface IProductRepo
    {
        bool SaveChanges();

        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int id);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        List<Product> GetAllProductOfPriceRange(FilterForPriceSearchDto filterForPrice);
        List<Product> GetAllProductOfCategory(FilterForCategorySearchDto filterForCategory, List<Product> productList);
        List<Product> GetAllProductOfGender(List<GenderOfProduct> genderOfProducts, List<Product> productList);
        List<Product> GetAllProductOfSize(List<SizeOfProduct> sizeOfProducts, List<Product> productList);
    }
}