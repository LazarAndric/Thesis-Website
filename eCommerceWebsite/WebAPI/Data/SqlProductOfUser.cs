using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class SqlProductOfUser : IProductOfUserRepo
    {
        private Context _context;
        public SqlProductOfUser(Context context)
        {
            _context=context;            
        }
        public void CreateProductOfUser(ProductOfUser productOfUser)
        {
            if(productOfUser==null)
            {
                throw new ArgumentException(nameof(ProductOfUser));
            }
            _context.ProductsOfUsers.Add(productOfUser);
        }

        public void DeleteProductOfUser(ProductOfUser productOfUser)
        {
            if(productOfUser==null)
            {
                throw new ArgumentException(nameof(ProductOfUser));
            }
            _context.ProductsOfUsers.Remove(productOfUser);
        }

        public IEnumerable<ProductOfUser> GetAllProductOfUsers()
        {
            return _context.ProductsOfUsers.ToList();
        }

        public IEnumerable<ProductOfUser> GetProductsOfUserById(int id)
        {
            List<ProductOfUser> products= new List<ProductOfUser>();
            var listOfProductsOfUsers=GetAllProductOfUsers();
            foreach(ProductOfUser product in listOfProductsOfUsers)
                if(product.UserId==id)
                {
                    products.Add(product);
                }
            if(products==null)
            {
                throw new ArgumentException(nameof(ProductOfUser));
            }
            return products;
        }

        public ProductOfUser GetProductOfUserById(int id)
        {
            return _context.ProductsOfUsers.FirstOrDefault(p=> p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()>=0);
        }

        public void UpdateProductOfUser(ProductOfUser productOfUser)
        {
            //Nothing
        }
    }
}