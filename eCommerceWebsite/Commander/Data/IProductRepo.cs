using System.Collections.Generic;
using Commander.Models;
using Commander.Dtos;

namespace Commander.Data
{
    public interface IProductRepo
    {
        bool SaveChanges();

        List<Product> GetAllProduct();
        Product GetProductById(int id);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        List<int> GetAllProductsOfCategory(List<Product> productList);
        float? GetMaxPriceOfProducts(List<Product> products);
        float? GetMinPriceOfProducts(List<Product> products);
        int GetLegthOfProductList(Category category, List<Product> productList);
        List<Product> GetAllProductOfPriceRange(FilterForPriceSearchDto filterForPrice);
        List<Product> GetAllProductOfCategory(FilterForCategorySearchDto filterForCategory, List<Product> productList);
        List<Product> GetAllProductOfGender(List<GenderOfProduct> genderOfProducts, List<Product> productList);
        List<Product> GetAllProductOfSize(List<SizeOfProduct> sizeOfProducts, List<Product> productList);
        public IEnumerable<Product> SortProductsByViews(List<Product> products, bool isAsc);
        public IEnumerable<Product> SortProductsByName(List<Product> products, bool isAsc);
        public IEnumerable<Product> SortProductsByPrice(List<Product> products, bool isAsc);
    }
}