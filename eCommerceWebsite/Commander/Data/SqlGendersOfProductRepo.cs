using System;
using System.Collections.Generic;
using System.Linq;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Data
{
    public class SqlGendersOfProductRepo : IGenderOfProductRepo
    {
        private Context _context;

        public SqlGendersOfProductRepo(Context context)
        {
            _context = context;
        }

        public void CreateGenderOfProduct(GenderOfProduct gendersOfProduct)
        {
            if(gendersOfProduct==null)
            {
                throw new ArgumentNullException(nameof(gendersOfProduct));
            }
            _context.GendersOfProducts.Add(gendersOfProduct);
        }

        public void DeleteGenderOfProduct(GenderOfProduct gendersOfProduct)
        {
            if(gendersOfProduct == null)
            {
                throw new ArgumentNullException(nameof(gendersOfProduct));
            }
            _context.GendersOfProducts.Remove(gendersOfProduct);
        }

        public List<GenderOfProduct> GetAllGenderOfProducts()
        {
            return _context.GendersOfProducts.ToList(); 
        }

        public List<GenderOfProduct> GetAllProductOfGender(FilterForGenderSearchDto genderFilter)
        {
            List<GenderOfProduct> finalList = new List<GenderOfProduct>();
            foreach(GenderOfProduct genderOfProduct in _context.GendersOfProducts)
                foreach(int id in genderFilter.Id)
                    if(genderOfProduct.GenderId.Equals(id))
                            finalList.Add(genderOfProduct);
                        
            return finalList;
        }


        public GenderOfProduct GetGenderOfProductById(int id)
        {
            return _context.GendersOfProducts.FirstOrDefault(p=> p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()>=0);
        }

        public void UpdateGenderOfProduct(GenderOfProduct gendersOfProduct)
        {
            //Nothing
        }
    }
}