using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutriFood.Models;
using NutriFood.Views;
using NutriFood.Repositories;

namespace NutriFood.Presenters
{
    public class MainPresenter
    {
        private IMainForm mainForm;
        private readonly string sqlConnection;

        public MainPresenter(IMainForm mainForm, string sqlConnection)
        {
            this.mainForm = mainForm;
            this.sqlConnection = sqlConnection;
            this.mainForm.ShowProductView += ShowProductView;
        }

        private void ShowProductView(object sender, EventArgs e)
        {
            IProductView view = ProductView.GetInstance((MainForm)mainForm);
            IProductRepository repository = new ProductRepository(sqlConnection);
            new ProductPresenter(view, repository);
        }
    }
}
