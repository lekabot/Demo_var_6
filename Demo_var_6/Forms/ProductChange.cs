using Demo_var_6.Classes.DataBaseClasses;
using System;
using System.IO;
using System.Windows.Forms;

namespace Demo_var_6.Forms
{
    public partial class ProductChange : Form
    {
        private string ProductArticleNumber { get; set; }
        private Product originalProduct;

        public ProductChange(string productArticleNumber)
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            ProductArticleNumber = productArticleNumber;
            originalProduct = null;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            using (var dbContext = new TradeContext())
            {
                originalProduct = dbContext.Products.FirstOrDefault(p => p.ProductArticleNumber == ProductArticleNumber);
                if (originalProduct != null)
                {
                    ProductImageEL.Image = LoadImageFromPath(originalProduct.Photo);
                    Title.Text = originalProduct.Title;
                    Description.Text = originalProduct.Description;
                    Manufacturer.Text = originalProduct.Manufacturer;
                    Cost.Text = originalProduct.Cost.ToString();
                    Quantity.Text = originalProduct.QuantityInStock.ToString();

                    if (!string.IsNullOrEmpty(originalProduct.Photo) && File.Exists(originalProduct.Photo))
                    {
                        ProductImageEL.Image = LoadImageFromPath(originalProduct.Photo);
                    }
                    else
                    {
                        ProductImageEL.Image = LoadImageFromPath("D:\\AAProjects\\C#\\Demo_var_6\\Demo_var_6\\Images\\NonPicture\\pugaka.jpg");
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {
            if (originalProduct != null)
            {
                TextBox textBox = (TextBox)sender;
                originalProduct.Title = textBox.Text;
            }
        }

        private void Description_TextChanged(object sender, EventArgs e)
        {
            if (originalProduct != null)
            {
                TextBox textBox = (TextBox)sender;
                originalProduct.Description = textBox.Text;
            }
        }

        private void Manufacturer_TextChanged(object sender, EventArgs e)
        {
            if (originalProduct != null)
            {
                TextBox textBox = (TextBox)sender;
                originalProduct.Manufacturer = textBox.Text;
            }
        }

        private void Cost_TextChanged(object sender, EventArgs e)
        {
            if (originalProduct != null)
            {
                TextBox textBox = (TextBox)sender;
                if (decimal.TryParse(textBox.Text, out decimal cost))
                {
                    originalProduct.Cost = cost;
                }
            }
        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {
            if (originalProduct != null)
            {
                TextBox textBox = (TextBox)sender;
                if (int.TryParse(textBox.Text, out int quantity))
                {
                    originalProduct.QuantityInStock = quantity;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (var dbContext = new TradeContext())
            {
                if (originalProduct != null)
                {
                    dbContext.Products.Update(originalProduct);
                    dbContext.SaveChanges();
                }
            }
        }

        private Image LoadImageFromPath(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    return Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}");
                }
            }
            return null;
        }

        private void GuestLogin_Click(object sender, EventArgs e)
        {
            Content content = new Content("Администратор");
            content.Show();
            this.Hide();
        }

        private void ProductImageEL_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Выберите изображение";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    if (originalProduct != null)
                    {
                        originalProduct.Photo = imagePath;
                    }

                    ProductImageEL.Image = LoadImageFromPath(imagePath);
                }
            }
        }

    }
}
