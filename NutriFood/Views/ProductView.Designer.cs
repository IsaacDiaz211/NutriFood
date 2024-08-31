namespace NutriFood.Views
{
    partial class ProductView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.BSearch = new System.Windows.Forms.Button();
            this.BUpdate = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LName = new System.Windows.Forms.Label();
            this.LImage = new System.Windows.Forms.Label();
            this.LCategory = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBImage = new System.Windows.Forms.TextBox();
            this.TBCategory = new System.Windows.Forms.TextBox();
            this.TBPSale = new System.Windows.Forms.TextBox();
            this.TBPrice = new System.Windows.Forms.TextBox();
            this.TBSupplier = new System.Windows.Forms.TextBox();
            this.TBSMin = new System.Windows.Forms.TextBox();
            this.TBStock = new System.Windows.Forms.TextBox();
            this.BSave = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitle.Location = new System.Drawing.Point(12, 9);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(137, 31);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Productos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.LTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 52);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 398);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.TBSearch);
            this.tabPage3.Controls.Add(this.BDelete);
            this.tabPage3.Controls.Add(this.BUpdate);
            this.tabPage3.Controls.Add(this.BSearch);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(577, 324);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Lista";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.BCancel);
            this.tabPage4.Controls.Add(this.BSave);
            this.tabPage4.Controls.Add(this.TBStock);
            this.tabPage4.Controls.Add(this.TBSMin);
            this.tabPage4.Controls.Add(this.TBSupplier);
            this.tabPage4.Controls.Add(this.TBPrice);
            this.tabPage4.Controls.Add(this.TBPSale);
            this.tabPage4.Controls.Add(this.TBCategory);
            this.tabPage4.Controls.Add(this.TBImage);
            this.tabPage4.Controls.Add(this.TBName);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.la);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.LCategory);
            this.tabPage4.Controls.Add(this.LImage);
            this.tabPage4.Controls.Add(this.LName);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(577, 372);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Agregar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // BSearch
            // 
            this.BSearch.Location = new System.Drawing.Point(499, 6);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(75, 23);
            this.BSearch.TabIndex = 0;
            this.BSearch.Text = "Buscar";
            this.BSearch.UseVisualStyleBackColor = true;
            // 
            // BUpdate
            // 
            this.BUpdate.Location = new System.Drawing.Point(499, 35);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.Size = new System.Drawing.Size(75, 23);
            this.BUpdate.TabIndex = 1;
            this.BUpdate.Text = "Editar";
            this.BUpdate.UseCompatibleTextRendering = true;
            this.BUpdate.UseVisualStyleBackColor = true;
            // 
            // BDelete
            // 
            this.BDelete.Location = new System.Drawing.Point(499, 64);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(75, 23);
            this.BDelete.TabIndex = 2;
            this.BDelete.Text = "Eliminar";
            this.BDelete.UseVisualStyleBackColor = true;
            // 
            // TBSearch
            // 
            this.TBSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TBSearch.Location = new System.Drawing.Point(366, 9);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(127, 20);
            this.TBSearch.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(577, 324);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Eliminados";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(479, 281);
            this.dataGridView1.TabIndex = 4;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(23, 32);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(44, 13);
            this.LName.TabIndex = 0;
            this.LName.Text = "Nombre";
            // 
            // LImage
            // 
            this.LImage.AutoSize = true;
            this.LImage.Location = new System.Drawing.Point(23, 72);
            this.LImage.Name = "LImage";
            this.LImage.Size = new System.Drawing.Size(42, 13);
            this.LImage.TabIndex = 1;
            this.LImage.Text = "Imagen";
            // 
            // LCategory
            // 
            this.LCategory.AutoSize = true;
            this.LCategory.Location = new System.Drawing.Point(23, 114);
            this.LCategory.Name = "LCategory";
            this.LCategory.Size = new System.Drawing.Size(52, 13);
            this.LCategory.TabIndex = 2;
            this.LCategory.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Precio";
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(23, 184);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(67, 13);
            this.la.TabIndex = 5;
            this.la.Text = "Precio venta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Stock mínimo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Proveedor";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(100, 32);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(152, 20);
            this.TBName.TabIndex = 8;
            // 
            // TBImage
            // 
            this.TBImage.Location = new System.Drawing.Point(100, 69);
            this.TBImage.Name = "TBImage";
            this.TBImage.Size = new System.Drawing.Size(152, 20);
            this.TBImage.TabIndex = 9;
            // 
            // TBCategory
            // 
            this.TBCategory.Location = new System.Drawing.Point(100, 107);
            this.TBCategory.Name = "TBCategory";
            this.TBCategory.Size = new System.Drawing.Size(152, 20);
            this.TBCategory.TabIndex = 10;
            // 
            // TBPSale
            // 
            this.TBPSale.Location = new System.Drawing.Point(101, 177);
            this.TBPSale.Name = "TBPSale";
            this.TBPSale.Size = new System.Drawing.Size(152, 20);
            this.TBPSale.TabIndex = 11;
            // 
            // TBPrice
            // 
            this.TBPrice.Location = new System.Drawing.Point(100, 142);
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.Size = new System.Drawing.Size(152, 20);
            this.TBPrice.TabIndex = 12;
            // 
            // TBSupplier
            // 
            this.TBSupplier.Location = new System.Drawing.Point(100, 285);
            this.TBSupplier.Name = "TBSupplier";
            this.TBSupplier.Size = new System.Drawing.Size(152, 20);
            this.TBSupplier.TabIndex = 13;
            // 
            // TBSMin
            // 
            this.TBSMin.Location = new System.Drawing.Point(101, 250);
            this.TBSMin.Name = "TBSMin";
            this.TBSMin.Size = new System.Drawing.Size(151, 20);
            this.TBSMin.TabIndex = 14;
            // 
            // TBStock
            // 
            this.TBStock.Location = new System.Drawing.Point(100, 214);
            this.TBStock.Name = "TBStock";
            this.TBStock.Size = new System.Drawing.Size(152, 20);
            this.TBStock.TabIndex = 15;
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(20, 329);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(75, 23);
            this.BSave.TabIndex = 16;
            this.BSave.Text = "Guardar";
            this.BSave.UseVisualStyleBackColor = true;
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(142, 329);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 17;
            this.BCancel.Text = "Cancelar";
            this.BCancel.UseVisualStyleBackColor = true;
            // 
            // ProductView
            // 
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Name = "ProductView";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl TCProductos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.Label LImagen;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Label LProveedor;
        private System.Windows.Forms.Label LStockMin;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.Button BUpdate;
        private System.Windows.Forms.Button BSearch;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TBStock;
        private System.Windows.Forms.TextBox TBSMin;
        private System.Windows.Forms.TextBox TBSupplier;
        private System.Windows.Forms.TextBox TBPrice;
        private System.Windows.Forms.TextBox TBPSale;
        private System.Windows.Forms.TextBox TBCategory;
        private System.Windows.Forms.TextBox TBImage;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LCategory;
        private System.Windows.Forms.Label LImage;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Button BSave;
    }
}