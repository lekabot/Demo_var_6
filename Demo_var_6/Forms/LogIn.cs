using Demo_var_6.Classes.DataBaseClasses;
using Demo_var_6.Forms;
using Microsoft.IdentityModel.Tokens;
using PartyMonkey.Forms;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Windows.Forms.Timer;

namespace Demo_var_6
{
    public partial class LogIn : Form
    {
        private int loginAttempts;

        public LogIn()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PasswordTB.PasswordChar = '*';
            timer.Interval = 10000;
        }

        private void SignInBT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTB.Text) || string.IsNullOrWhiteSpace(PasswordTB.Text))
            {
                MessageBox.Show("You have not entered the login of password", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (CheckUserIsExist(LoginTB.Text, PasswordTB.Text))
                {
                    string userRole = GetUserRole(LoginTB.Text);
                    var nextForm = new Content(userRole);
                    nextForm.Show();
                    this.Hide();
                }
                else
                {
                    loginAttempts++;
                    MessageBox.Show("Wrong login or password", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (loginAttempts == 2)
                {
                    Capcha capcha = new Capcha();
                    capcha.Show();
                    this.Hide();
                    LoginTB.Enabled = false;
                    PasswordTB.Enabled = false;
                    SignInBT.Enabled = false;
                    timer.Start();
                }
            }
        }

        private bool CheckUserIsExist(string usernameToCheck, string passwordToCheck)
        {
            using (var dbContext = new TradeContext())
            {
                bool userExists = dbContext.Users
                    .Any(u => Equals(u.Login, usernameToCheck) && Equals(u.Password, passwordToCheck));
                return userExists;
            }
        }

        private string GetUserRole(string usernameToGet)
        {
            using (var dbContext = new TradeContext())
            {
                User user = dbContext.Users.FirstOrDefault(u => u.Login == usernameToGet);
                if (user != null)
                {
                    Role userRole = dbContext.Roles.FirstOrDefault(r => r.Id == user.Role);
                    if (userRole != null)
                    {
                        return userRole.RoleName;
                    }
                }
                return null;
            }
        }

        private void GuestLogin_Click(object sender, EventArgs e)
        {
            var nextForm = new Content();
            nextForm.Show();
            this.Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LoginTB.Enabled = true;
            PasswordTB.Enabled = true;
            SignInBT.Enabled = true;
            timer.Stop();
        }
    }
}