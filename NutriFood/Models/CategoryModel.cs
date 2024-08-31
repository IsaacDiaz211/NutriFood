using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFood.Models
{
    public class CategoryModel
    {
        private int id_category;
        private string name;
        private string deleted;

        public int Id_category 
        { get { return id_category; } set { id_category = value; } }

        public string Name 
        { get { return name; } set { name = value; } }

        public string Deleted
        { get { return deleted; } set { deleted = value; } }
    }
}
