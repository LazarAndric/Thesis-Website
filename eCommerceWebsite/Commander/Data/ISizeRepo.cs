using System.Collections.Generic;
using Commander.Models;
using Commander.Data;

namespace Commander.Data
{
    public interface ISizeRepo
    {
        bool SaveChanges();

        IEnumerable<Size> GetAllSizes();
        Size GetSizeById(int id);
        void CreateSize(Size size);
        void UpdateSize(Size size);
        void DeleteSize(Size sSize);
    }
}