using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using NutriFood.Models;

namespace NutriFood.Repositories
{
    public class ProductRepository: BaseRepository, IProductRepository
    {
        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ProductModel product)
        { }
        public void Update(ProductModel product)
        { }
        public void Delete(int id)
        { }
        public IEnumerable<ProductModel> GetAll()
        {
            var productsList = new List<ProductModel>();
            //For the DataBase
            /*using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM Products"; //Acá modificar
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new ProductModel();
                            product.Id_product = (int)reader[0];
                            product.Name = reader[1].ToString();
                            //continuar
                            productsList.Add(product);
                        }
                    }

                }
            }*/
            return productsList;
        }
        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var productsList = new List<ProductModel>();
            int prodId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productName = value;
            //For the DataBase
            /*using (var connection = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM Products" +
                                    "where Id_product ... "; //Acá modificar
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = prodId; //Agregar nombre

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new ProductModel();
                            product.Id_product = (int)reader[0];
                            product.Name = reader[1].ToString();
                            //continuar
                            productsList.Add(product);
                        }
                    }

                }
            }*/
            return productsList;
        }
    }
}
