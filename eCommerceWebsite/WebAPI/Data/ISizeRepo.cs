using System.Collections.Generic;
using WebAPI.Models;
using WebAPI.Data;

namespace WebAPI.Data
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