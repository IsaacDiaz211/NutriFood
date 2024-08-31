using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFood.Models
{
    public interface IUserRepository
    {
        void Add(UserModel user);
        void Update(UserModel user);
        void Delete(UserModel user);
        IEnumerable<UserModel> GetAll();
        IEnumerable<UserModel> GetByValue(int id);
    }
}
