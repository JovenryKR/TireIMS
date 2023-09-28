using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TireIMS
{
    public partial class UpdateForm : Form
    {
        private mongodb_drivers mongodb = new mongodb_drivers("tireIMS");

        public UpdateForm()
        {
            InitializeComponent();
        }

        private Product universalProduct = null;

        //Clear list items
        private void clearItems()
        {
            txtb_size_update.Text = "";
            txtb_brand_update.Text = "";
            txtb_pattern_update.Text = "";
            txtb_price_update.Text = "";
            txtb_quantity_update.Text = "";
        }

        private async void search_btn_update(object sender, EventArgs e)
        {
            string size = txtb_size_update.Text;
            Product oldProduct = await mongodb.SearchProduct(size);
            if (oldProduct != null)
            {
                universalProduct = oldProduct;
                txtb_brand_update.Text = oldProduct.Brand;
                txtb_pattern_update.Text = oldProduct.Pattern;
                txtb_price_update.Text = oldProduct.Price.ToString();
                txtb_quantity_update.Text = oldProduct.QTY.ToString();

            }
            else
            {
                MessageBox.Show("There is no Product in database");
            }
        }

        private async void btn_updateForm(object sender, EventArgs e)
        {
            string size = txtb_size_update.Text;
            string pattern = txtb_pattern_update.Text;
            string brand = txtb_brand_update.Text;
            float price = float.Parse(txtb_price_update.Text);
            int qty = int.Parse(txtb_quantity_update.Text);

            if (universalProduct != null)
            {
                Product updatedProduct = new Product
                {
                    Size = size,
                    Pattern = pattern,
                    Brand = brand,
                    Price = price,
                    QTY = qty
                };
                await mongodb.Updateproduct(universalProduct, updatedProduct);
                MessageBox.Show("Update Successfully");
                clearItems();
            }
            else
            {
                MessageBox.Show("Update Error");
            }
        }

        private void mouseHover_btn_search_update(object sender, EventArgs e)
        {
            picbox_search_update.BackColor = Color.DarkRed;
        }

        private void mouseLeave_btn_search_update(object sender, EventArgs e)
        {
            picbox_search_update.BackColor = SystemColors.Control;
        }
    }
}
