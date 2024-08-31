using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutriFood.Models;
using NutriFood.Views;

namespace NutriFood.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productsBindingSource;
        IEnumerable<ProductModel> productList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddProduct;
            this.view.UpdateEvent += UpdateProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.DeleteEvent += DeleteProduct;
            this.view.CancelEvent += CancelProduct;
            LoadAllProductList();
            this.view.Show();
        }

        private void LoadAllProductList()
        {
            productList = repository.GetAll();
            productsBindingSource.DataSource = productList;
        }

        private void SearchProduct(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if(!emptyValue)
            {
                productList = repository.GetByValue(this.view.SearchValue);
            }
            else { productList = repository.GetAll(); }
            productsBindingSource.DataSource = productList;
        }

        private void AddProduct(object sender, EventArgs e)
        {

        }

        private void UpdateProduct(object sender, EventArgs e)
        {

        }

        private void SaveProduct(object sender, EventArgs e)
        {

        }

        private void DeleteProduct(object sender, EventArgs e)
        {

        }

        private void CancelProduct(object sender, EventArgs e)
        {

        }
    }
}
