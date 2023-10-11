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
            ProductsDG = new DataGridView();
            productBindingSource = new BindingSource(components);
            GuestLogin = new Button();
            tradeContextBindingSource = new BindingSource(components);
            ordersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderProductsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pickupPointsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rolesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            databaseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            changeTrackerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contextIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ProductsDG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tradeContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ProductsDG
            // 
            ProductsDG.AutoGenerateColumns = false;
            ProductsDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDG.Columns.AddRange(new DataGridViewColumn[] { ordersDataGridViewTextBoxColumn, orderProductsDataGridViewTextBoxColumn, pickupPointsDataGridViewTextBoxColumn, productsDataGridViewTextBoxColumn, rolesDataGridViewTextBoxColumn, usersDataGridViewTextBoxColumn, databaseDataGridViewTextBoxColumn, changeTrackerDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, contextIdDataGridViewTextBoxColumn });
            ProductsDG.DataSource = tradeContextBindingSource;
            ProductsDG.Location = new Point(1, 39);
            ProductsDG.Name = "ProductsDG";
            ProductsDG.RowTemplate.Height = 25;
            ProductsDG.Size = new Size(799, 414);
            ProductsDG.TabIndex = 0;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Classes.DataBaseClasses.Product);
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
            // tradeContextBindingSource
            // 
            tradeContextBindingSource.DataSource = typeof(Classes.DataBaseClasses.TradeContext);
            // 
            // ordersDataGridViewTextBoxColumn
            // 
            ordersDataGridViewTextBoxColumn.DataPropertyName = "Orders";
            ordersDataGridViewTextBoxColumn.HeaderText = "Orders";
            ordersDataGridViewTextBoxColumn.Name = "ordersDataGridViewTextBoxColumn";
            // 
            // orderProductsDataGridViewTextBoxColumn
            // 
            orderProductsDataGridViewTextBoxColumn.DataPropertyName = "OrderProducts";
            orderProductsDataGridViewTextBoxColumn.HeaderText = "OrderProducts";
            orderProductsDataGridViewTextBoxColumn.Name = "orderProductsDataGridViewTextBoxColumn";
            // 
            // pickupPointsDataGridViewTextBoxColumn
            // 
            pickupPointsDataGridViewTextBoxColumn.DataPropertyName = "PickupPoints";
            pickupPointsDataGridViewTextBoxColumn.HeaderText = "PickupPoints";
            pickupPointsDataGridViewTextBoxColumn.Name = "pickupPointsDataGridViewTextBoxColumn";
            // 
            // productsDataGridViewTextBoxColumn
            // 
            productsDataGridViewTextBoxColumn.DataPropertyName = "Products";
            productsDataGridViewTextBoxColumn.HeaderText = "Products";
            productsDataGridViewTextBoxColumn.Name = "productsDataGridViewTextBoxColumn";
            // 
            // rolesDataGridViewTextBoxColumn
            // 
            rolesDataGridViewTextBoxColumn.DataPropertyName = "Roles";
            rolesDataGridViewTextBoxColumn.HeaderText = "Roles";
            rolesDataGridViewTextBoxColumn.Name = "rolesDataGridViewTextBoxColumn";
            // 
            // usersDataGridViewTextBoxColumn
            // 
            usersDataGridViewTextBoxColumn.DataPropertyName = "Users";
            usersDataGridViewTextBoxColumn.HeaderText = "Users";
            usersDataGridViewTextBoxColumn.Name = "usersDataGridViewTextBoxColumn";
            // 
            // databaseDataGridViewTextBoxColumn
            // 
            databaseDataGridViewTextBoxColumn.DataPropertyName = "Database";
            databaseDataGridViewTextBoxColumn.HeaderText = "Database";
            databaseDataGridViewTextBoxColumn.Name = "databaseDataGridViewTextBoxColumn";
            databaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // changeTrackerDataGridViewTextBoxColumn
            // 
            changeTrackerDataGridViewTextBoxColumn.DataPropertyName = "ChangeTracker";
            changeTrackerDataGridViewTextBoxColumn.HeaderText = "ChangeTracker";
            changeTrackerDataGridViewTextBoxColumn.Name = "changeTrackerDataGridViewTextBoxColumn";
            changeTrackerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.HeaderText = "Model";
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextIdDataGridViewTextBoxColumn
            // 
            contextIdDataGridViewTextBoxColumn.DataPropertyName = "ContextId";
            contextIdDataGridViewTextBoxColumn.HeaderText = "ContextId";
            contextIdDataGridViewTextBoxColumn.Name = "contextIdDataGridViewTextBoxColumn";
            contextIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ModerateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GuestLogin);
            Controls.Add(ProductsDG);
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
        private DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderProductsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pickupPointsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rolesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn changeTrackerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contextIdDataGridViewTextBoxColumn;
        private BindingSource tradeContextBindingSource;
    }
}