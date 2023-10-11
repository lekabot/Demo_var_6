using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Demo_var_6.Forms
{
    public partial class ModerateForm : Form
    {
        public ModerateForm()
        {
            InitializeComponent();
        }

        private void GuestLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Content content = new Content();
            content.Show();
        }

        private void ModerateForm_Load(object sender, EventArgs e)
        {
        }
    }
}
