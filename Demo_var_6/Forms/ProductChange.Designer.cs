namespace Demo_var_6.Forms
{
    partial class ProductChange
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
            Title = new TextBox();
            Description = new TextBox();
            Manufacturer = new TextBox();
            Cost = new TextBox();
            Quantity = new TextBox();
            ProductImageEL = new PictureBox();
            GuestLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductImageEL).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(376, 102);
            Title.Name = "Title";
            Title.Size = new Size(403, 45);
            Title.TabIndex = 1;
            Title.TextChanged += Title_TextChanged;
            // 
            // Description
            // 
            Description.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Description.Location = new Point(376, 153);
            Description.Name = "Description";
            Description.Size = new Size(403, 45);
            Description.TabIndex = 2;
            Description.TextChanged += Description_TextChanged;
            // 
            // Manufacturer
            // 
            Manufacturer.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Manufacturer.Location = new Point(376, 204);
            Manufacturer.Name = "Manufacturer";
            Manufacturer.Size = new Size(403, 45);
            Manufacturer.TabIndex = 3;
            Manufacturer.TextChanged += Manufacturer_TextChanged;
            // 
            // Cost
            // 
            Cost.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Cost.Location = new Point(376, 255);
            Cost.Name = "Cost";
            Cost.Size = new Size(403, 45);
            Cost.TabIndex = 4;
            Cost.TextChanged += Cost_TextChanged;
            // 
            // Quantity
            // 
            Quantity.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Quantity.Location = new Point(376, 306);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(403, 45);
            Quantity.TabIndex = 5;
            Quantity.TextChanged += Quantity_TextChanged;
            // 
            // ProductImageEL
            // 
            ProductImageEL.Image = Properties.Resources.E345R4;
            ProductImageEL.Location = new Point(10, 28);
            ProductImageEL.Name = "ProductImageEL";
            ProductImageEL.Size = new Size(194, 170);
            ProductImageEL.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductImageEL.TabIndex = 6;
            ProductImageEL.TabStop = false;
            ProductImageEL.Click += ProductImageEL_Click;
            // 
            // GuestLogin
            // 
            GuestLogin.BackColor = Color.FromArgb(73, 140, 81);
            GuestLogin.FlatStyle = FlatStyle.Flat;
            GuestLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GuestLogin.ForeColor = Color.White;
            GuestLogin.Location = new Point(628, 12);
            GuestLogin.Name = "GuestLogin";
            GuestLogin.Size = new Size(160, 37);
            GuestLogin.TabIndex = 8;
            GuestLogin.Text = "Back";
            GuestLogin.UseVisualStyleBackColor = false;
            GuestLogin.Click += GuestLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(293, 105);
            label1.Name = "label1";
            label1.Size = new Size(77, 38);
            label1.TabIndex = 9;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(210, 156);
            label2.Name = "label2";
            label2.Size = new Size(160, 38);
            label2.TabIndex = 10;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(178, 207);
            label3.Name = "label3";
            label3.Size = new Size(192, 38);
            label3.TabIndex = 11;
            label3.Text = "Manufacturer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(297, 258);
            label4.Name = "label4";
            label4.Size = new Size(73, 38);
            label4.TabIndex = 12;
            label4.Text = "Cost";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(240, 309);
            label5.Name = "label5";
            label5.Size = new Size(130, 38);
            label5.TabIndex = 13;
            label5.Text = "Quantity";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(73, 140, 81);
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(376, 385);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(160, 37);
            SaveButton.TabIndex = 14;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // ProductChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GuestLogin);
            Controls.Add(ProductImageEL);
            Controls.Add(Quantity);
            Controls.Add(Cost);
            Controls.Add(Manufacturer);
            Controls.Add(Description);
            Controls.Add(Title);
            Name = "ProductChange";
            Text = "Product";
            Load += Product_Load;
            ((System.ComponentModel.ISupportInitialize)ProductImageEL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Title;
        private TextBox Description;
        private TextBox Manufacturer;
        private TextBox Cost;
        private TextBox Quantity;
        private PictureBox ProductImageEL;
        private Button GuestLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button SaveButton;
    }
}