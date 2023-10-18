using Demo_var_6.Classes.DataBaseClasses;
using Demo_var_6.Forms.Capcha.UserContol;
using System.Data;

namespace Demo_var_6.Forms
{
    public partial class Content : Form
    {
        private List<Product> displayedProducts;
        private List<Product> allProducts;
        private int totalProductsCount;
        private int displayedProductsCount;

        string Role { get; set; }

        public Content(string role)
        {
            Role = role;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public Content()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void Content_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
            LoadProducts();
            PopulateManufacturersComboBox();
        }

        private void LoadAllProducts()
        {
            using (var dbContext = new TradeContext())
            {
                allProducts = dbContext.Products.ToList();
            }
        }

        private void LoadProducts()
        {
            using (var dbContext = new TradeContext())
            {
                displayedProducts = dbContext.Products.ToList();
                totalProductsCount = allProducts.Count;
                allProducts = dbContext.Products.ToList();
                displayedProducts = allProducts;
                DisplayProducts(displayedProducts);
            }
        }

        private void Finder_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = Finder.Text.ToLower();
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadProducts();
            }
            else
            {
                displayedProducts = allProducts
                    .Where(product =>
                        product.Title.ToLower().Contains(searchTerm) ||
                        product.Description.ToLower().Contains(searchTerm) ||
                        product.Manufacturer.ToLower().Contains(searchTerm) ||
                        product.Category.ToLower().Contains(searchTerm))
                    .ToList();

                DisplayProducts(displayedProducts);
            }
        }

        private void AscendingSort_CheckedChanged(object sender, EventArgs e)
        {
            SortData(true);
        }

        private void DescendingSort_CheckedChanged(object sender, EventArgs e)
        {
            SortData(false);
        }

        private void SortData(bool ascending)
        {
            if (ascending)
            {
                displayedProducts = displayedProducts.OrderBy(product => product.Manufacturer).ToList();
            }
            else
            {
                displayedProducts = displayedProducts.OrderByDescending(product => product.Manufacturer).ToList();
            }

            DisplayProducts(displayedProducts);
        }

        private void DisplayProducts(List<Product> products)
        {
            ClearSearchResults();
            int yOffset = 80;

            foreach (var product in products)
            {
                ProductInfoControl productControl = CreateProductControl(product);
                productControl.Location = new Point(0, yOffset);
                Controls.Add(productControl);
                if (Role == "Администратор")
                {
                    productControl.Click += ProductControl_Click;
                }
                yOffset += productControl.Height + 1;
            }
            displayedProductsCount = products.Count;
            UpdateProductsCountLabel();
        }

        private ProductInfoControl CreateProductControl(Product product)
        {
            ProductInfoControl productControl = new ProductInfoControl
            {
                ProductArticleNumber = product.ProductArticleNumber,
                ProductTitle = product.Title,
                ProductDescription = product.Description,
                ProductManufacturer = product.Manufacturer,
                ProductQuantity = product.QuantityInStock,

            };

            string priceText = string.Format("{0:F2} ₽", product.Cost);
            productControl.ProductCost = priceText;

            if (product.QuantityInStock <= 0)
            {
                productControl.BackColor = Color.Gray;
            }

            if (!string.IsNullOrEmpty(product.Photo) && File.Exists(product.Photo))
            {
                productControl.ProductImage = LoadImageFromPath(product.Photo);
            }
            else
            {
                productControl.ProductImage = LoadImageFromPath("D:\\AAProjects\\C#\\Demo_var_6\\Demo_var_6\\Images\\NonPicture\\pugaka.jpg");
            }

            return productControl;
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

        private void ClearSearchResults()
        {
            foreach (Control control in this.Controls.OfType<ProductInfoControl>().ToList())
            {
                this.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void UpdateProductsCountLabel()
        {
            Quntity.Text = $"{displayedProductsCount} из {totalProductsCount}";
        }

        private void PopulateManufacturersComboBox()
        {
            using (var dbContext = new TradeContext())
            {
                var manufacturers = dbContext.Products.Select(product => product.Manufacturer).Distinct().ToList();
                ManufacturerComboBox.Items.Clear();
                ManufacturerComboBox.Items.Add("Все производители");
                ManufacturerComboBox.Items.AddRange(manufacturers.ToArray());
            }
        }

        private void ManufacturerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedManufacturer = ManufacturerComboBox.SelectedItem.ToString();
            if (selectedManufacturer == "Все производители")
            {
                LoadProducts();
            }
            else
            {
                LoadProductsByManufacturer(selectedManufacturer);
            }
        }

        private void LoadProductsByManufacturer(string manufacturer)
        {
            using (var dbContext = new TradeContext())
            {
                displayedProducts = dbContext.Products
                    .Where(product => product.Manufacturer == manufacturer)
                    .ToList();

                DisplayProducts(displayedProducts);
            }
        }

        private void ProductControl_Click(object sender, EventArgs e)
        {
            ProductInfoControl clickedControl = (ProductInfoControl)sender;
            string productArticleNumber = clickedControl.ProductArticleNumber;
            ProductChange product = new ProductChange(productArticleNumber);
            product.Show();
            this.Hide();
        }
    }
}
