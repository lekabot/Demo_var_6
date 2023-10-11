namespace Demo_var_6.Forms.Capcha.UserContol
{
    partial class ProductInfoControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ProductImageEL = new PictureBox();
            Title = new Label();
            Description = new Label();
            Manufacturer = new Label();
            Cost = new Label();
            Quantity = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductImageEL).BeginInit();
            SuspendLayout();
            // 
            // ProductImageEL
            // 
            ProductImageEL.Image = Properties.Resources.E345R4;
            ProductImageEL.Location = new Point(15, 15);
            ProductImageEL.Name = "ProductImageEL";
            ProductImageEL.Size = new Size(98, 100);
            ProductImageEL.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductImageEL.TabIndex = 0;
            ProductImageEL.TabStop = false;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = SystemColors.ControlText;
            Title.ImageAlign = ContentAlignment.TopCenter;
            Title.Location = new Point(348, 10);
            Title.Name = "Title";
            Title.Size = new Size(93, 23);
            Title.TabIndex = 1;
            Title.Text = "Лакомство";
            Title.TextAlign = ContentAlignment.TopCenter;
            // 
            // Description
            // 
            Description.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Description.ForeColor = SystemColors.ControlText;
            Description.Location = new Point(141, 33);
            Description.Name = "Description";
            Description.Size = new Size(550, 31);
            Description.TabIndex = 2;
            Description.Text = "Лакомство для кошек Dreamies Подушечки с курицей, 140 г";
            // 
            // Manufacturer
            // 
            Manufacturer.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Manufacturer.ForeColor = SystemColors.ControlText;
            Manufacturer.Location = new Point(141, 64);
            Manufacturer.Name = "Manufacturer";
            Manufacturer.Size = new Size(550, 31);
            Manufacturer.TabIndex = 3;
            Manufacturer.Text = "Dreames";
            // 
            // Cost
            // 
            Cost.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cost.ForeColor = SystemColors.ControlText;
            Cost.Location = new Point(141, 95);
            Cost.Name = "Cost";
            Cost.Size = new Size(550, 33);
            Cost.TabIndex = 4;
            Cost.Text = "123";
            // 
            // Quantity
            // 
            Quantity.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Quantity.ForeColor = SystemColors.ControlText;
            Quantity.Location = new Point(697, 24);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(100, 82);
            Quantity.TabIndex = 5;
            Quantity.Text = "7";
            Quantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductInfoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(Quantity);
            Controls.Add(Cost);
            Controls.Add(Manufacturer);
            Controls.Add(Description);
            Controls.Add(Title);
            Controls.Add(ProductImageEL);
            Name = "ProductInfoControl";
            Size = new Size(800, 128);
            ((System.ComponentModel.ISupportInitialize)ProductImageEL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ProductImageEL;
        private Label Title;
        private Label Description;
        private Label Manufacturer;
        private Label Cost;
        private Label Quantity;
    }
}
