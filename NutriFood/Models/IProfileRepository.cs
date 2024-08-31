using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFood.Models
{
    public interface IProfileRepository
    {
        void Add(ProfileModel profile);
        void Update(ProfileModel profile);
        void Delete(ProfileModel profile);
    }
}
