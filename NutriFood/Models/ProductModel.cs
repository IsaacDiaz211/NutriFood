using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFood.Models
{
    public class ProductModel
    {
        private int id_product;
        private string name;
        private string image;
        private int category_id;
        private float price;
        private float sale_price;
        private int stock;
        private int stock_min;
        private int units_sold;
        private int supplier_id;
        private string deleted;

        public int Id_product
        { get { return id_product; } set { id_product = value; } }

        public string Name
        { get { return name; } set { name = value; } }

        public string Image
        { get { return image; } set { image = value; } }

        public int CategoryId
        { get { return category_id; } set { category_id = value; } }

        public float Price
        {  get { return price; } set { price = value; } }

        public float SalePrice
        { get { return sale_price; } set { sale_price = value; } }

        public int Stock
        { get { return stock; } set { stock = value; } }

        public int Stock_min
        { get { return stock_min; } set { stock_min = value; } }

        public int Units_sold
        { get { return units_sold; } set { units_sold = value; } }

        public int SupplierId
        {  get { return supplier_id; } set { supplier_id = value; } }

        public string Deleted
        {  get { return deleted; } set { deleted = value; } }


    }
}
