using System.Collections.Generic;
using WebAPI.Models;
using WebAPI.Data;

namespace WebAPI.Data
{
    public interface ICategoryRepo
    {
        bool SaveChanges();

        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void CreateCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
    }
}