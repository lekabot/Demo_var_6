namespace Demo_var_6
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Title = new Label();
            LoginLB = new Label();
            PasswordLB = new Label();
            LoginTB = new TextBox();
            PasswordTB = new TextBox();
            SignInBT = new Button();
            GuestLogin = new Button();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.FromArgb(73, 140, 81);
            Title.Location = new Point(284, 79);
            Title.Name = "Title";
            Title.Size = new Size(254, 52);
            Title.TabIndex = 0;
            Title.Text = "Authorization";
            // 
            // LoginLB
            // 
            LoginLB.AutoSize = true;
            LoginLB.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLB.ForeColor = Color.FromArgb(73, 140, 81);
            LoginLB.Location = new Point(108, 157);
            LoginLB.Name = "LoginLB";
            LoginLB.Size = new Size(89, 38);
            LoginLB.TabIndex = 1;
            LoginLB.Text = "Login:";
            // 
            // PasswordLB
            // 
            PasswordLB.AutoSize = true;
            PasswordLB.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLB.ForeColor = Color.FromArgb(73, 140, 81);
            PasswordLB.Location = new Point(56, 240);
            PasswordLB.Name = "PasswordLB";
            PasswordLB.Size = new Size(141, 38);
            PasswordLB.TabIndex = 2;
            PasswordLB.Text = "Password:";
            // 
            // LoginTB
            // 
            LoginTB.BackColor = Color.FromArgb(118, 227, 131);
            LoginTB.BorderStyle = BorderStyle.FixedSingle;
            LoginTB.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LoginTB.Location = new Point(212, 155);
            LoginTB.Name = "LoginTB";
            LoginTB.Size = new Size(390, 45);
            LoginTB.TabIndex = 3;
            // 
            // PasswordTB
            // 
            PasswordTB.BackColor = Color.FromArgb(118, 227, 131);
            PasswordTB.BorderStyle = BorderStyle.FixedSingle;
            PasswordTB.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.Location = new Point(212, 238);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(390, 45);
            PasswordTB.TabIndex = 4;
            // 
            // SignInBT
            // 
            SignInBT.BackColor = Color.FromArgb(73, 140, 81);
            SignInBT.FlatStyle = FlatStyle.Flat;
            SignInBT.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            SignInBT.ForeColor = Color.White;
            SignInBT.Location = new Point(312, 341);
            SignInBT.Name = "SignInBT";
            SignInBT.Size = new Size(198, 52);
            SignInBT.TabIndex = 5;
            SignInBT.Text = "SignIn";
            SignInBT.UseVisualStyleBackColor = false;
            SignInBT.Click += SignInBT_Click;
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
            GuestLogin.TabIndex = 6;
            GuestLogin.Text = "Log in as a guest";
            GuestLogin.UseVisualStyleBackColor = false;
            GuestLogin.Click += GuestLogin_Click;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GuestLogin);
            Controls.Add(SignInBT);
            Controls.Add(PasswordTB);
            Controls.Add(LoginTB);
            Controls.Add(PasswordLB);
            Controls.Add(LoginLB);
            Controls.Add(Title);
            Name = "LogIn";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label LoginLB;
        private Label PasswordLB;
        private TextBox LoginTB;
        private TextBox PasswordTB;
        private Button SignInBT;
        private Button GuestLogin;
        private System.Windows.Forms.Timer timer;
    }
}