using System.Collections.Generic;
using Commander.Models;
using Commander.Data;
using Commander.Dtos;

namespace Commander.Data
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
        List<SizeOfProduct> GetAllProductsOfSize(FilterForSizeSearchDto sizeFilter);
    }
}