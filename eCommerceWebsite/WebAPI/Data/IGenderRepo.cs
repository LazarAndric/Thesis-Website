using System.Collections.Generic;
using WebAPI.Models;
using WebAPI.Data;

namespace WebAPI.Data
{
    public interface IGenderRepo
    {
        bool SaveChanges();

        IEnumerable<Gender> GetAllGenders();
        Gender GetGenderById(int id);
        void CreateGender(Gender gender);
        void UpdateGender(Gender gender);
        void DeleteGender(Gender gender);
    }
}