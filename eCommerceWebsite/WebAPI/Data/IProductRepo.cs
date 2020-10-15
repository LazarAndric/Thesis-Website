using System.Collections.Generic;
using WebAPI.Models;
using WebAPI.Dtos;

namespace WebAPI.Data
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
        List<Product> GetAllProductOfPriceRange(FilterForPriceSearchDto filterForPrice, List<Product> products);
        List<Product> GetAllProductOfCategory(FilterForCategorySearchDto filterForCategory, List<Product> productList);
        List<Product> GetAllProductOfGender(List<GenderOfProduct> genderOfProducts, List<Product> productList);
        List<Product> GetAllProductOfSize(List<SizeOfProduct> sizeOfProducts, List<Product> productList);
        public List<Product> SortProductsByViews(List<Product> products, bool isAsc);
        public List<Product> SortProductsByName(List<Product> products, bool isAsc);
        public List<Product> SortProductsByPrice(List<Product> products, bool isAsc);
        public List<Product> BackPaging(int skip,int skipLast, List<Product> products);
    }
}