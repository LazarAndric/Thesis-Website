using System.Collections.Generic;
using Commander.Models;
using Commander.Data;

namespace Commander.Data
{
    public interface IGendersOfProductRepo
    {
        bool SaveChanges();

        IEnumerable<GenderOfProduct> GetAllGendersOfProduct();
        GenderOfProduct GetGendersOfProductById(int id);
        void CreateGendersOfProduct(GenderOfProduct gendersOfProduct);
        void UpdateGendersOfProduct(GenderOfProduct gendersOfProduct);
        void DeleteGendersOfProduct(GenderOfProduct gendersOfProduct);
    }
}