using System.Collections.Generic;
using Commander.Models;
using Commander.Data;

namespace Commander.Data
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