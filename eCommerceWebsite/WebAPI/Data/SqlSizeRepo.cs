using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class SqlSizeRepo : ISizeRepo
    {
        private Context _context;

        public SqlSizeRepo(Context context)
        {
            _context = context;
        }

        public void CreateSize(Size size)
        {
            if(size==null)
            {
                throw new ArgumentNullException(nameof(size));
            }
            _context.Sizes.Add(size);
        }

        public void DeleteSize(Size size)
        {
            if(size == null)
            {
                throw new ArgumentNullException(nameof(size));
            }
            _context.Sizes.Remove(size);
        }

        public IEnumerable<Size> GetAllSizes()
        {
            return _context.Sizes.ToList(); 
        }

        public Size GetSizeById(int id)
        {
            return _context.Sizes.FirstOrDefault(p=> p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()>=0);
        }

        public void UpdateSize(Size Size)
        {
            //Nothing
        }
    }
}