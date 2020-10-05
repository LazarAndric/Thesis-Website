using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class SqlGenderRepo : IGenderRepo
    {
        private Context _context;

        public SqlGenderRepo(Context context)
        {
            _context = context;
        }

        public void CreateGender(Gender gender)
        {
            if(gender==null)
            {
                throw new ArgumentNullException(nameof(gender));
            }
            _context.Genders.Add(gender);
        }

        public void DeleteGender(Gender gender)
        {
            if(gender == null)
            {
                throw new ArgumentNullException(nameof(gender));
            }
            _context.Genders.Remove(gender);
        }

        public IEnumerable<Gender> GetAllGenders()
        {
            return _context.Genders.ToList(); 
        }

        public Gender GetGenderById(int id)
        {
            return _context.Genders.FirstOrDefault(p=> p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()>=0);
        }

        public void UpdateGender(Gender gender)
        {
            //Nothing
        }
    }
}