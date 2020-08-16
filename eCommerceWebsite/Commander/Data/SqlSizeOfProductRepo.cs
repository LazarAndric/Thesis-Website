using System;
using System.Collections.Generic;
using System.Linq;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Data
{
    public class SqlSizeOfProductRepo : ISizeOfProductRepo
    {
        private Context _context;

        public SqlSizeOfProductRepo(Context context)
        {
            _context = context;
        }

        public void CreateSizeOfProduct(SizeOfProduct sizeOfProduct)
        {
            if(sizeOfProduct==null)
            {
                throw new ArgumentNullException(nameof(sizeOfProduct));
            }
            _context.SizeOfProducts.Add(sizeOfProduct);
        }

        public void DeleteSizeOfProduct(SizeOfProduct sizeOfProduct)
        {
            if(sizeOfProduct == null)
            {
                throw new ArgumentNullException(nameof(sizeOfProduct));
            }
            _context.SizeOfProducts.Remove(sizeOfProduct);
        }

        public IEnumerable<SizeOfProduct> GetAllSizeOfProducts()
        {
            return _context.SizeOfProducts.ToList(); 
        }

        public List<SizeOfProduct> GetAllProductsOfSize(FilterForSizeSearchDto sizeFilter)
        {
            if(sizeFilter==null)
                return null;
            List<SizeOfProduct> sizeOfProducts = new List<SizeOfProduct>();
            foreach(SizeOfProduct sizeOf in _context.SizeOfProducts)
                if(sizeOf.SizeId.Equals(sizeFilter.Id))
                    sizeOfProducts.Add(sizeOf);
            return sizeOfProducts;
        }
        public List<SizeOfProduct> GetAllProductsOfSize(List<Product> listOfProduct)
        {
            List<SizeOfProduct> sizeOfProducts = new List<SizeOfProduct>();
            foreach(Product product in listOfProduct)
                foreach(SizeOfProduct size in _context.SizeOfProducts)
                    if(size.ProductId.Equals(product.Id))
                        if(!sizeOfProducts.Contains(size))
                            sizeOfProducts.Add(size);
            return sizeOfProducts;
        }

        public SizeOfProduct GetSizeOfProductById(int id)
        {
            return _context.SizeOfProducts.FirstOrDefault(p=> p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()>=0);
        }

        public void UpdateSizeOfProduct(SizeOfProduct SizeOfProduct)
        {
            //Nothing
        }
    }
}