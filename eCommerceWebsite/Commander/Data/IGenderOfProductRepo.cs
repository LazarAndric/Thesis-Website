using System.Collections.Generic;
using Commander.Models;
using Commander.Data;
using Commander.Dtos;

namespace Commander.Data
{
    public interface IGenderOfProductRepo
    {
        bool SaveChanges();

        List<GenderOfProduct> GetAllGenderOfProducts();
        List<GenderOfProduct> GetAllProductOfGender(FilterForGenderSearchDto genderFilter);
        GenderOfProduct GetGenderOfProductById(int id);
        void CreateGenderOfProduct(GenderOfProduct gendersOfProduct);
        void UpdateGenderOfProduct(GenderOfProduct gendersOfProduct);
        void DeleteGenderOfProduct(GenderOfProduct gendersOfProduct);
    }
}