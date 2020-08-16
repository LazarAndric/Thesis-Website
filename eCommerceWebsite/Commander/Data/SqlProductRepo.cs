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

        public List<Product> GetAllProduct()
        {
            return _context.Products.ToList(); 
        }
        public List<Product> GetAllProductOfPriceRange(FilterForPriceSearchDto filterForPrice)
        {
            List<Product> finalList = new List<Product>();
            foreach(Product product in _context.Products)
            {
                if(product.Price>filterForPrice.PriceFrom && product.Price<filterForPrice.PriceTo)
                    finalList.Add(product);
            }
            return finalList; 
        }
        public List<Product> GetAllProductOfCategory(FilterForCategorySearchDto filterForCategory, List<Product> productList)
        {
            if(filterForCategory==null)
                return null;
            List<Product> finalList = new List<Product>();
            foreach(Product product in productList)
                foreach(int id in filterForCategory.Id)
                    if(product.ProductCategoryId.Equals(id))
                        finalList.Add(product);
            return finalList;
        }
        public List<int> GetAllProductsOfCategory(List<Product> productList)
        {
            List<int> finalList = new List<int>();
            foreach(Product product in productList)
            {
                finalList.Add(product.Id);
            }
            return finalList;
        }

        public List<Product> GetAllProductOfSize(List<SizeOfProduct> sizeOfProducts, List<Product> productList)
        {
            if(sizeOfProducts==null)
                return null;
            List<Product> finalList = new List<Product>();
            foreach(Product product in productList)
                foreach(SizeOfProduct sizeOf in sizeOfProducts)
                    if(product.Id.Equals(sizeOf.ProductId))
                        if(!finalList.Contains(product))
                            finalList.Add(product);
            return finalList;
        }

        public List<Product> GetAllProductOfGender(List<GenderOfProduct> genderOfProducts, List<Product> productList)
        {
            if(genderOfProducts==null)
                return null;
            List<Product> finalList = new List<Product>();
            foreach(Product product in productList)
                foreach(GenderOfProduct genderOfProduct in genderOfProducts)
                    if(product.Id.Equals(genderOfProduct.ProductId))
                        if(!finalList.Contains(product))
                            finalList.Add(product);
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
        }

        public float? GetMaxPriceOfProducts()
        {
            var maxPrice =_context.Products.First().Price;
            foreach(Product product in _context.Products)
                if(product.Price > maxPrice)
                    maxPrice=product.Price;
            return maxPrice;
        }
        public float? GetMinPriceOfProducts()
        {
            var minPrice =_context.Products.First().Price;
            foreach(Product product in _context.Products)
                if(product.Price < minPrice)
                    minPrice=product.Price;
            return minPrice;
        }

        public int GetLegthOfProductList(Category category, List<Product> productList)
        {
            int countOfProducts=0;
            foreach(Product product in productList)
                if(category.Id.Equals(product.ProductCategoryId))
                    countOfProducts++;
            return countOfProducts;
        }
    }
}