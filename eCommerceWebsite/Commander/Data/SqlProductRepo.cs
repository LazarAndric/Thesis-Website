using System;
using System.Collections.Generic;
using System.Linq;
using Commander.Models;
using Commander.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class SqlProductRepo : IProductRepo
    {
        private Context _context;

        public SqlProductRepo(Context context)
        {
            _context = context;
        }

        public void CreateProduct(Product product)
        {
            if(product==null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            _context.Products.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            if(product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            _context.Products.Remove(product);
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return _context.Products.ToList(); 
        }
        public List<Product> GetAllProductOfPriceRange(FilterForPrice filterForPrice)
        {
            List<Product> finalList = new List<Product>();
            foreach(Product product in _context.Products)
            {
                if(product.Price>filterForPrice.PriceFrom && product.Price<filterForPrice.PriceTo)
                    finalList.Add(product);
            }
            return finalList; 
        }
        public List<Product> GetAllProductOfCategory(FilterForCategory filterForCategory, List<Product> productList)
        {
            List<Product> finalList = new List<Product>();
            foreach(Product product in productList)
            {
                if(product.ProductCategoryId.Equals(filterForCategory.Id))
                    finalList.Add(product);
            }
            return finalList;
        }

        public List<Product> GetAllProductOfGender(List<GenderOfProduct> genderOfProducts, List<Product> productList)
        {
            List<Product> finalList = new List<Product>();
            foreach(Product product in productList)
            {
                foreach(GenderOfProduct genderOfProduct in genderOfProducts)
                {
                    if(product.Id.Equals(genderOfProduct.ProductId))
                        finalList.Add(product);
                }
            }
            return finalList;
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p=> p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()>=0);
        }

        public void UpdateProduct(Product product)
        {
            //Nothing
        }
    }
}