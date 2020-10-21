using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;
using WebAPI.Dtos;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data
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
            var list = _context.Products.ToList();
            foreach(Product product in list)
            {
                var category= _context.Categories.FirstOrDefault(p=> p.Id == product.CategoryId);
                product.Category=category;
            }
            return _context.Products.ToList(); 
        }
        public List<Product> GetAllProductOfPriceRange(FilterForPriceSearchDto filterForPrice, List<Product> products)
        {
            List<Product> finalList = new List<Product>();
            if(filterForPrice!=null)
            {
                foreach(Product product in products)
                {
                    if(product.Price>=filterForPrice.PriceFrom && product.Price<=filterForPrice.PriceTo)
                        finalList.Add(product);
                }
            }
            else return null;
            return finalList; 
        }
        public List<Product> BackPaging(int skip,int skipLast, List<Product> products)
        {
            var count=products.Count();
            if(skipLast>count)
                skipLast=count;
            var maxItem=count-skipLast;
            var items= products.Skip(skip).ToList();
            var items2= items.SkipLast(maxItem).ToList();
            return items2.ToList();
        }
        public List<Product> GetAllProductOfCategory(FilterForCategorySearchDto filterForCategory, List<Product> productList)
        {
            if(filterForCategory==null || filterForCategory.Id==null)
                return null;
            List<Product> finalList = new List<Product>();
            foreach(Product product in productList)
                foreach(int id in filterForCategory.Id)
                    if(product.CategoryId.Equals(id))
                        finalList.Add(product);
            return finalList;
        }
        public List<int> GetAllProductsOfCategory(List<Product> productList)
        {
            List<int> finalList = new List<int>();
            foreach(Product product in productList)
            {
                finalList.Add((int)product.CategoryId);
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
            var products=_context.Products.ToList();
            if(products.Count==0)
                return null;
            var list= (IEnumerable<Product>)products;
            var maxPrice= list.First().Price;
            foreach(var product in list)
                if(product.Price > maxPrice)
                    maxPrice=product.Price;
            return maxPrice;
        }
        public float? GetMinPriceOfProducts()
        {
            var products=_context.Products.ToList();
            if(products.Count==0)
                return null;
            var list= (IEnumerable<Product>)products;
            var minPrice =list.First().Price;
            foreach(var product in list)
                if(product.Price < minPrice)
                    minPrice=product.Price;
            return minPrice;
        }

        public int GetLegthOfProductList(Category category, List<ProductReadDto> productList)
        {
            int countOfProducts=0;
            foreach(var product in productList)
                if(category.Id.Equals(product.CategoryId))
                    countOfProducts++;
            return countOfProducts;
        }

        public List<Product> SortProductsByName(List<Product> products, bool isAsc)
        {
            var list=(IEnumerable<Product>)products;
            if(isAsc)
                return list.OrderBy(p => p.Name).ToList();
                
            else return list.OrderByDescending(p => p.Name).ToList();
        }
        public List<Product> SortProductsByPrice(List<Product> products, bool isAsc)
        {
            var list=(IEnumerable<Product>)products;
            if(isAsc)
                return list.OrderBy(p => p.Price).ToList();
            else return list.OrderByDescending(p => p.Price).ToList();
        }
        public List<Product> SortProductsByViews(List<Product> products, bool isAsc)
        {
            var list=(IEnumerable<Product>)products;
            if(isAsc)
                return list.OrderBy(p => p.NumberOfViews).ToList();
            else return list.OrderByDescending(p => p.NumberOfViews).ToList();
        }

        public Product GetMostPurchasesProduct()
        {
            var items=_context.Products.ToList();
            int max=items[2].NumberOfPurchases;
            Product product=new Product();
            product=items[2];
            foreach(var item in items)
                if(item.NumberOfPurchases>max)
                {
                    max=item.NumberOfPurchases;
                    product=item;
                }
            return product;
        }

        public Product GetMostPopularProduct()
        {
            var items=_context.Products.ToList();
            Product product=new Product();
            int max=items[1].NumberOfViews;
            product=items[1];
            foreach(var item in items)
                if(item.NumberOfViews>max)
                {
                    max=item.NumberOfViews;
                    product=item;
                }
            return product;
        }

        public Product GetLatestProduct()
        {
            var items=_context.Products.ToList();
            Product product=new Product();
            DateTime date=(DateTime)items[0].DateOfCreate;
            product=items[0];
            foreach(var item in items)
                if(item.DateOfCreate>date)
                {
                    date=(DateTime)item.DateOfCreate;
                    product=item;
                }

            return product;
        }
    }
}