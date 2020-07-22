using System.Collections.Generic;
using Commander.Models;
using Commander.Data;

namespace Commander.Data
{
    public interface IGenderOfProductRepo
    {
        bool SaveChanges();

        IEnumerable<GenderOfProduct> GetAllGenderOfProducts();
        GenderOfProduct GetGenderOfProductById(int id);
        void CreateGenderOfProduct(GenderOfProduct gendersOfProduct);
        void UpdateGenderOfProduct(GenderOfProduct gendersOfProduct);
        void DeleteGenderOfProduct(GenderOfProduct gendersOfProduct);
    }
}