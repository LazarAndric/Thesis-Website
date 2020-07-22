using System.Collections.Generic;
using Commander.Models;
using Commander.Data;

namespace Commander.Data
{
    public interface ISizeOfProductRepo
    {
        bool SaveChanges();

        IEnumerable<SizeOfProduct> GetAllSizeOfProducts();
        SizeOfProduct GetSizeOfProductById(int id);
        void CreateSizeOfProduct(SizeOfProduct sizeOfProduct);
        void UpdateSizeOfProduct(SizeOfProduct sizeOfProduct);
        void DeleteSizeOfProduct(SizeOfProduct sizeOfProduct);
    }
}