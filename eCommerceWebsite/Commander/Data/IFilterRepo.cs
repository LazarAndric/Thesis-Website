using System.Collections.Generic;
using Commander.Models;
using Commander.Data;

namespace Commander.Data
{
    public interface IFilterRepo
    {
        bool SaveChanges();

        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void CreateCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
    }
}