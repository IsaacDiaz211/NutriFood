using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriFood.Views
{
    public partial class ProductView : Form, IProductView
    {
        private bool isSuccessful;
        private bool isDeleted;

        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPage4);
        }

        private void AssociateAndRaiseViewEvents()
        {
            BSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            //Seria conveniente agregar la tecla enter como modo de busqueda.
        }

        public string Id_product 
        {  
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public new string Name
        {
            get { return TBName.Text; }
            set { TBName.Text = value; }
        }
        public string Image
        {
            get { return TBImage.Text; }
            set { TBImage.Text = value; }
        }
        public string CategoryId
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public string Price
        {
            get { return TBPrice.Text; }
            set { TBPrice.Text = value; }
        }
        public string Sale_price
        {
            get { return TBPSale.Text; }
            set { TBPSale.Text = value; }
        }
        public string Stock
        {
            get { return TBStock.Text; }
            set { TBStock.Text = value; }
        }
        public string Stock_min
        {
            get { return TBSMin.Text; }
            set { TBSMin.Text = value; }
        }
        public string Units_sold
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public string Supplier_id
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public string Deleted
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string SearchValue
        {
            get { return TBSearch.Text; }
            set { TBSearch.Text = value; }
        }
        public bool IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProductListBindingSource(BindingSource productList)
        {
            dataGridView1.DataSource = productList;
        }
        /*public new void Show()
        {
            throw new NotImplementedException();
        }*/

        private static ProductView instance;
        public static ProductView GetInstance(Form parentContainer)
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else 
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
