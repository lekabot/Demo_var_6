using Demo_var_6.Classes.DataBaseClasses;

namespace Demo_var_6.Forms
{
    public partial class ModerateForm : Form
    {
        public ModerateForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ModerateForm_Load(object sender, EventArgs e)
        {
            using (var dbContext = new TradeContext())
            {
                var products = dbContext.Products.ToList();
                ProductsDG.DataSource = products;
            }
        }

        private void GuestLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Content content = new Content("Администратор");
            content.Show();
        }

        private void ProductsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
