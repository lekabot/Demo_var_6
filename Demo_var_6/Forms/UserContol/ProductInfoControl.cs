using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_var_6.Forms.Capcha.UserContol
{
    public partial class ProductInfoControl : UserControl
    {
        public ProductInfoControl()
        {
            InitializeComponent();
        }

        public string ProductArticleNumber { get; set; }

        public Image ProductImage
        {
            get { return ProductImageEL.Image; }
            set { ProductImageEL.Image = value; }
        }

        public string ProductTitle
        {
            get { return Title.Text; }
            set { Title.Text = value; }
        }

        public string ProductDescription
        {
            get { return Description.Text; }
            set { Description.Text = value; }
        }

        public string ProductManufacturer
        {
            get { return Manufacturer.Text; }
            set { Manufacturer.Text = value; }
        }

        public string ProductCost
        {
            get { return Cost.Text; }
            set { Cost.Text = value.ToString(); }
        }

        public int ProductQuantity
        {
            get { return int.Parse(Quantity.Text); }
            set { Quantity.Text = value.ToString(); }
        }

    }
}
