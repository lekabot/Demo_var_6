namespace PartyMonkey.Forms
{
    partial class Capcha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capcha));
            CapchaBox = new PictureBox();
            сheckButton = new Button();
            сhangeButton = new Button();
            CheckTextBox = new TextBox();
            EnterCapcha = new Label();
            ((System.ComponentModel.ISupportInitialize)CapchaBox).BeginInit();
            SuspendLayout();
            // 
            // CapchaBox
            // 
            CapchaBox.Location = new Point(373, 14);
            CapchaBox.Margin = new Padding(4, 3, 4, 3);
            CapchaBox.Name = "CapchaBox";
            CapchaBox.Size = new Size(296, 197);
            CapchaBox.TabIndex = 3;
            CapchaBox.TabStop = false;
            // 
            // сheckButton
            // 
            сheckButton.BackColor = Color.FromArgb(73, 140, 81);
            сheckButton.FlatStyle = FlatStyle.Flat;
            сheckButton.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            сheckButton.ForeColor = Color.White;
            сheckButton.Location = new Point(83, 228);
            сheckButton.Margin = new Padding(4, 3, 4, 3);
            сheckButton.Name = "сheckButton";
            сheckButton.Size = new Size(146, 40);
            сheckButton.TabIndex = 22;
            сheckButton.Text = "Check";
            сheckButton.UseVisualStyleBackColor = false;
            сheckButton.Click += сheckButton_Click;
            // 
            // сhangeButton
            // 
            сhangeButton.BackColor = Color.FromArgb(73, 140, 81);
            сhangeButton.FlatStyle = FlatStyle.Flat;
            сhangeButton.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            сhangeButton.ForeColor = Color.White;
            сhangeButton.Location = new Point(442, 228);
            сhangeButton.Margin = new Padding(4, 3, 4, 3);
            сhangeButton.Name = "сhangeButton";
            сhangeButton.Size = new Size(146, 40);
            сhangeButton.TabIndex = 23;
            сhangeButton.Text = "Change";
            сhangeButton.UseVisualStyleBackColor = false;
            сhangeButton.Click += сhangeButton_Click;
            // 
            // CheckTextBox
            // 
            CheckTextBox.BackColor = Color.FromArgb(118, 227, 131);
            CheckTextBox.BorderStyle = BorderStyle.FixedSingle;
            CheckTextBox.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CheckTextBox.ForeColor = Color.Black;
            CheckTextBox.Location = new Point(27, 143);
            CheckTextBox.Margin = new Padding(4, 3, 4, 3);
            CheckTextBox.Name = "CheckTextBox";
            CheckTextBox.Size = new Size(272, 41);
            CheckTextBox.TabIndex = 24;
            // 
            // EnterCapcha
            // 
            EnterCapcha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EnterCapcha.AutoSize = true;
            EnterCapcha.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            EnterCapcha.ForeColor = Color.FromArgb(73, 140, 81);
            EnterCapcha.Location = new Point(47, 73);
            EnterCapcha.Margin = new Padding(4, 0, 4, 0);
            EnterCapcha.Name = "EnterCapcha";
            EnterCapcha.Size = new Size(178, 30);
            EnterCapcha.TabIndex = 25;
            EnterCapcha.Text = "Enter a captcha";
            // 
            // Capcha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 301);
            Controls.Add(EnterCapcha);
            Controls.Add(CheckTextBox);
            Controls.Add(сhangeButton);
            Controls.Add(сheckButton);
            Controls.Add(CapchaBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Capcha";
            Text = "Capcha";
            Load += Capcha_Load;
            ((System.ComponentModel.ISupportInitialize)CapchaBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox CapchaBox;
        private Button сheckButton;
        private Button сhangeButton;
        private TextBox CheckTextBox;
        private Label EnterCapcha;
    }
}