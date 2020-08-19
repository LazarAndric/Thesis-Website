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
            if(genderFilter==null)
                return null;
            List<GenderOfProduct> finalList = new List<GenderOfProduct>();
            foreach(GenderOfProduct genderOfProduct in _context.GendersOfProducts)
            {
                if(genderOfProduct.GenderId.Equals(genderFilter.Id))
                    if(!finalList.Contains(genderOfProduct))
                        finalList.Add(genderOfProduct);
            }
            return finalList;
        }
        public List<int> GetAllIdOfGenders(List<Product> products)
        {
            if(products==null)
                return null;
            var finalList = new List<int>();
            foreach(GenderOfProduct genderOfProduct in _context.GendersOfProducts)
                foreach(Product product in products)
                    if(genderOfProduct.ProductId.Equals(product.Id))
                        if(!finalList.Contains((int)genderOfProduct.GenderId))
                            finalList.Add((int)genderOfProduct.GenderId);
            return finalList;
        }

        public List<int> GetAllIdOfGender(Product product)
        {
            if(product==null)
                return null;
            var finalList = new List<int>();
            foreach(GenderOfProduct genderOfProduct in _context.GendersOfProducts)
                if(genderOfProduct.ProductId.Equals(product.Id))
                    finalList.Add((int)genderOfProduct.GenderId);
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

        public int LengthOfGender(Gender gender)
        {
            int counter=0;
            if(gender!=null)
                foreach(GenderOfProduct product in _context.GendersOfProducts)
                    if(product.GenderId.Equals(gender.Id))
                        counter++;
            return counter;
        }
    }
}