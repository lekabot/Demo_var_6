namespace Demo_var_6.Forms
{
    partial class ModerateForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModerateForm));
            ProductsDG = new DataGridView();
            productArticleNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            measuremenUnitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maximumDiscountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            manufacturerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            currentDiscountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityInStockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            photoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderProductsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            tradeContextBindingSource = new BindingSource(components);
            GuestLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductsDG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tradeContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ProductsDG
            // 
            ProductsDG.AutoGenerateColumns = false;
            ProductsDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDG.Columns.AddRange(new DataGridViewColumn[] { productArticleNumberDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, measuremenUnitDataGridViewTextBoxColumn, costDataGridViewTextBoxColumn, maximumDiscountDataGridViewTextBoxColumn, manufacturerDataGridViewTextBoxColumn, supplierDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, currentDiscountDataGridViewTextBoxColumn, quantityInStockDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, photoDataGridViewTextBoxColumn, orderProductsDataGridViewTextBoxColumn });
            ProductsDG.DataSource = productBindingSource;
            ProductsDG.Location = new Point(1, 39);
            ProductsDG.Name = "ProductsDG";
            ProductsDG.RowTemplate.Height = 25;
            ProductsDG.Size = new Size(799, 414);
            ProductsDG.TabIndex = 0;
            ProductsDG.CellContentClick += ProductsDG_CellContentClick;
            // 
            // productArticleNumberDataGridViewTextBoxColumn
            // 
            productArticleNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductArticleNumber";
            productArticleNumberDataGridViewTextBoxColumn.HeaderText = "ProductArticleNumber";
            productArticleNumberDataGridViewTextBoxColumn.Name = "productArticleNumberDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // measuremenUnitDataGridViewTextBoxColumn
            // 
            measuremenUnitDataGridViewTextBoxColumn.DataPropertyName = "MeasuremenUnit";
            measuremenUnitDataGridViewTextBoxColumn.HeaderText = "MeasuremenUnit";
            measuremenUnitDataGridViewTextBoxColumn.Name = "measuremenUnitDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            costDataGridViewTextBoxColumn.HeaderText = "Cost";
            costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // maximumDiscountDataGridViewTextBoxColumn
            // 
            maximumDiscountDataGridViewTextBoxColumn.DataPropertyName = "MaximumDiscount";
            maximumDiscountDataGridViewTextBoxColumn.HeaderText = "MaximumDiscount";
            maximumDiscountDataGridViewTextBoxColumn.Name = "maximumDiscountDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // currentDiscountDataGridViewTextBoxColumn
            // 
            currentDiscountDataGridViewTextBoxColumn.DataPropertyName = "CurrentDiscount";
            currentDiscountDataGridViewTextBoxColumn.HeaderText = "CurrentDiscount";
            currentDiscountDataGridViewTextBoxColumn.Name = "currentDiscountDataGridViewTextBoxColumn";
            // 
            // quantityInStockDataGridViewTextBoxColumn
            // 
            quantityInStockDataGridViewTextBoxColumn.DataPropertyName = "QuantityInStock";
            quantityInStockDataGridViewTextBoxColumn.HeaderText = "QuantityInStock";
            quantityInStockDataGridViewTextBoxColumn.Name = "quantityInStockDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewTextBoxColumn
            // 
            photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            // 
            // orderProductsDataGridViewTextBoxColumn
            // 
            orderProductsDataGridViewTextBoxColumn.DataPropertyName = "OrderProducts";
            orderProductsDataGridViewTextBoxColumn.HeaderText = "OrderProducts";
            orderProductsDataGridViewTextBoxColumn.Name = "orderProductsDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Classes.DataBaseClasses.Product);
            // 
            // tradeContextBindingSource
            // 
            tradeContextBindingSource.DataSource = typeof(Classes.DataBaseClasses.TradeContext);
            // 
            // GuestLogin
            // 
            GuestLogin.BackColor = Color.FromArgb(73, 140, 81);
            GuestLogin.FlatStyle = FlatStyle.Flat;
            GuestLogin.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            GuestLogin.ForeColor = Color.White;
            GuestLogin.Location = new Point(700, 5);
            GuestLogin.Name = "GuestLogin";
            GuestLogin.Size = new Size(88, 28);
            GuestLogin.TabIndex = 7;
            GuestLogin.Text = "Back";
            GuestLogin.UseVisualStyleBackColor = false;
            GuestLogin.Click += GuestLogin_Click;
            // 
            // ModerateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GuestLogin);
            Controls.Add(ProductsDG);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModerateForm";
            Text = "Back";
            Load += ModerateForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProductsDG).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tradeContextBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductsDG;
        private BindingSource productBindingSource;
        private Button GuestLogin;
        private BindingSource tradeContextBindingSource;
        private DataGridViewTextBoxColumn productArticleNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn measuremenUnitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maximumDiscountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentDiscountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityInStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderProductsDataGridViewTextBoxColumn;
    }
}