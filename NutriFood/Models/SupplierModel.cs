using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFood.Models
{
    public class SupplierModel
    {
        private int id_supplier;
        private string name;
        private string email;
        private string telephone;
        private string cellphone;
        private string deleted;

        public int Id_supplier
        { get { return id_supplier; } set { id_supplier = value; } }

        public string Name
        { get { return name; } set { name = value; } }

        public string Email
        { get { return email; } set { email = value; } }

        public string Telephone
        {  get { return telephone; } set { telephone = value; } }

        public string Cellphone
        {  get { return cellphone; } set { cellphone = value; } }

        public string Deleted
        { get { return deleted; } set { deleted = value; } }

    }
}
