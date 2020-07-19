using System;
using System.Collections.Generic;
using System.Linq;
using Commander.Models;

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