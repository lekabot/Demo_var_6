using System.Data;
using Demo_var_6.Classes.DataBaseConnection;

namespace Demo_var_6
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBaseConnection dataBaseConnection = new DataBaseConnection();

            if (dataBaseConnection.sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Hello world");
            } else
            {
                MessageBox.Show("Go fuck yourSelf");
            }
        }
    }
}