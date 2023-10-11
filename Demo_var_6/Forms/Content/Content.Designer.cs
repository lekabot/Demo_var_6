namespace Demo_var_6.Forms
{
    partial class Content
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
            Finder = new TextBox();
            AscendingSort = new RadioButton();
            DescendingSort = new RadioButton();
            Quntity = new Label();
            ManufacturerComboBox = new ComboBox();
            SuspendLayout();
            // 
            // Finder
            // 
            Finder.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Finder.ForeColor = Color.FromArgb(73, 140, 81);
            Finder.Location = new Point(309, 12);
            Finder.Name = "Finder";
            Finder.Size = new Size(196, 26);
            Finder.TabIndex = 0;
            Finder.TextChanged += Finder_TextChanged;
            // 
            // AscendingSort
            // 
            AscendingSort.AutoSize = true;
            AscendingSort.ForeColor = Color.FromArgb(73, 140, 81);
            AscendingSort.Location = new Point(526, 13);
            AscendingSort.Name = "AscendingSort";
            AscendingSort.Size = new Size(183, 19);
            AscendingSort.TabIndex = 1;
            AscendingSort.TabStop = true;
            AscendingSort.Text = "Сортировка по возрастанию";
            AscendingSort.UseVisualStyleBackColor = true;
            AscendingSort.CheckedChanged += AscendingSort_CheckedChanged;
            // 
            // DescendingSort
            // 
            DescendingSort.AutoSize = true;
            DescendingSort.ForeColor = Color.FromArgb(73, 140, 81);
            DescendingSort.Location = new Point(526, 38);
            DescendingSort.Name = "DescendingSort";
            DescendingSort.Size = new Size(169, 19);
            DescendingSort.TabIndex = 2;
            DescendingSort.TabStop = true;
            DescendingSort.Text = "Сортировка по убыванию";
            DescendingSort.UseVisualStyleBackColor = true;
            DescendingSort.CheckedChanged += DescendingSort_CheckedChanged;
            // 
            // Quntity
            // 
            Quntity.AutoSize = true;
            Quntity.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Quntity.ForeColor = Color.FromArgb(73, 140, 81);
            Quntity.Location = new Point(12, 15);
            Quntity.Name = "Quntity";
            Quntity.Size = new Size(0, 23);
            Quntity.TabIndex = 3;
            // 
            // ManufacturerComboBox
            // 
            ManufacturerComboBox.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ManufacturerComboBox.ForeColor = Color.FromArgb(73, 140, 81);
            ManufacturerComboBox.FormattingEnabled = true;
            ManufacturerComboBox.Location = new Point(96, 12);
            ManufacturerComboBox.Name = "ManufacturerComboBox";
            ManufacturerComboBox.Size = new Size(196, 26);
            ManufacturerComboBox.TabIndex = 4;
            ManufacturerComboBox.SelectedIndexChanged += ManufacturerComboBox_SelectedIndexChanged;
            // 
            // Content
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(820, 450);
            Controls.Add(ManufacturerComboBox);
            Controls.Add(Quntity);
            Controls.Add(DescendingSort);
            Controls.Add(AscendingSort);
            Controls.Add(Finder);
            Name = "Content";
            Text = "Content";
            Load += Content_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Finder;
        private RadioButton AscendingSort;
        private RadioButton DescendingSort;
        private Label Quntity;
        private ComboBox ManufacturerComboBox;
    }
}