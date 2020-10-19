using System.Collections.Generic;
using WebAPI.Models;
using WebAPI.Data;
using WebAPI.Dtos;

namespace WebAPI.Data
{
    public interface ISizeOfProductRepo
    {
        bool SaveChanges();

        IEnumerable<SizeOfProduct> GetAllSizeOfProducts();
        SizeOfProduct GetSizeOfProductById(int id);
        int LengthOfSize(Size size, List<Product> products);
        void CreateSizeOfProduct(SizeOfProduct sizeOfProduct);
        void UpdateSizeOfProduct(SizeOfProduct sizeOfProduct);
        void DeleteSizeOfProduct(SizeOfProduct sizeOfProduct);
        List<int> GetAllIdOfSize(List<Product> products);
        List<int> GetAllProductIdsOfSize(Product product);
        List<SizeOfProduct> GetAllProductsOfSize(FilterForSizeSearchDto sizeFilter);
    }
}