using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFood.Models
{
    public interface ICategoryRepository
    {
        void Add(CategoryModel category);
        void Update(CategoryModel category);
        void Delete(CategoryModel category);
        IEnumerable<CategoryModel> GetAll();
        IEnumerable<CategoryModel> GetByValue(int id);
    }
}
