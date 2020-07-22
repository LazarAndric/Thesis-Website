using System;
using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    public class SqlGendersOfProductRepo : IGendersOfProductRepo
    {
        private Context _context;

        public SqlGendersOfProductRepo(Context context)
        {
            _context = context;
        }

        public void CreateGendersOfProduct(GenderOfProduct gendersOfProduct)
        {
            if(gendersOfProduct==null)
            {
                throw new ArgumentNullException(nameof(gendersOfProduct));
            }
            _context.GendersOfProducts.Add(gendersOfProduct);
        }

        public void DeleteGendersOfProduct(GenderOfProduct gendersOfProduct)
        {
            if(gendersOfProduct == null)
            {
                throw new ArgumentNullException(nameof(gendersOfProduct));
            }
            _context.GendersOfProducts.Remove(gendersOfProduct);
        }

        public IEnumerable<GenderOfProduct> GetAllGendersOfProduct()
        {
            return _context.GendersOfProducts.ToList(); 
        }

        public GenderOfProduct GetGendersOfProductById(int id)
        {
            return _context.GendersOfProducts.FirstOrDefault(p=> p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()>=0);
        }

        public void UpdateGendersOfProduct(GenderOfProduct gendersOfProduct)
        {
            //Nothing
        }
    }
}