using System.Collections.Generic;
using WebAPI.Models;
using WebAPI.Data;

namespace WebAPI.Data
{
    public interface IUserRepo
    {
        bool SaveChanges();

        User LoginUser(string email);
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}