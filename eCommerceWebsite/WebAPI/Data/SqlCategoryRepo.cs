using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class SqlCategoryRepo : ICategoryRepo
    {
        private Context _context;

        public SqlCategoryRepo(Context context)
        {
            _context = context;
        }

        public void CreateCategory(Category category)
        {
            if(category==null)
            {
                throw new ArgumentNullException(nameof(category));
            }
            _context.Categories.Add(category);
        }

        public void DeleteCategory(Category category)
        {
            if(category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }
            _context.Categories.Remove(category);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList(); 
        }

        public Category GetCategoryById(int id)
        {
            Console.WriteLine(id);
            if(id==0)
                return null;
            return _context.Categories.FirstOrDefault(p=> p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()>=0);
        }

        public void UpdateCategory(Category category)
        {
            //Nothing
        }
    }
}