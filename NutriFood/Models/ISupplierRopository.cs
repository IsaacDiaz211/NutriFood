using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFood.Models
{
    public interface ISupplierRopository
    {
        void Add(SupplierModel supplier); 
        void Update(SupplierModel supplier);
        void Delete(SupplierModel supplier);
        IEnumerable<SupplierModel> GetAll();
        IEnumerable<SupplierModel> GetByValue(int id);
    } 
}
