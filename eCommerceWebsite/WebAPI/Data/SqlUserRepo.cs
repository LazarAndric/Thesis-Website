using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class SqlUserRepo : IUserRepo 
    {
        private Context _context;

        public SqlUserRepo(Context context)
        {
            _context = context;
        }

        public User LoginUser(string email)
        {
            return _context.Users.FirstOrDefault(x => x.EMail.ToLower().Equals(email.ToLower()));
        }
        
        public void CreateUser(User usr)
        {
            if(usr==null)
            {
                throw new ArgumentNullException(nameof(usr));
            }
            _context.Users.Add(usr);
        }

        public void DeleteUser(User usr)
        {
            if(usr == null)
            {
                throw new ArgumentNullException(nameof(usr));
            }
            _context.Users.Remove(usr);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList(); 
        }

        public User GetUserById(int id)
        { 
            return _context.Users.FirstOrDefault(p=> p.Id == id);
        }

        public bool SaveChanges()
        {
        return (_context.SaveChanges()>=0);
        }

        public void UpdateUser(User user)
        {
            //Nothing
        }
    }
}