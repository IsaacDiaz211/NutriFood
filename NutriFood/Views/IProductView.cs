using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriFood.Views
{
    public interface IProductView
    {
        string Id_product { get; set; }
        string Name { get; set; }
        string Image { get; set; }
        string CategoryId { get; set; }
        string Price { get; set; }
        string Sale_price { get; set; }
        string Stock { get; set; }
        string Stock_min { get; set; }
        string Units_sold { get; set; }
        string Supplier_id { get; set; }
        string Deleted { get; set; }

        string SearchValue { get; set; }
        bool IsDeleted { get; set; }
        bool IsSuccessful { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler UpdateEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProductListBindingSource(BindingSource productList);
        void Show();

    }
}
