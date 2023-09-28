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
    public partial class DeleteForm : Form
    {

        private mongodb_drivers mongodb = new mongodb_drivers("tireIMS");

        public DeleteForm()
        {
            InitializeComponent();
        }

        //Clear list items
        private void clearItems()
        {
            txtb_size_delete.Text = "";
            txtb_brand_delete.Text = "";
            txtb_pattern_delete.Text = "";
            txtb_price_delete.Text = "";
            txtb_quantity_delete.Text = "";
        }

        private Product universalProduct = null;
        private async void btn_search_delete(object sender, EventArgs e)
        {
            string size = txtb_size_delete.Text;
            Product oldProduct = await mongodb.SearchProduct(size);
            if (oldProduct != null)
            {
                universalProduct = oldProduct;
                txtb_brand_delete.Text = oldProduct.Brand;
                txtb_pattern_delete.Text = oldProduct.Pattern;
                txtb_price_delete.Text = oldProduct.Price.ToString();
                txtb_quantity_delete.Text = oldProduct.QTY.ToString();
            }
            else
            {
                MessageBox.Show("There is no Product in database");
            }
        }

        private async void btn_delete_form(object sender, EventArgs e)
        {
            if (universalProduct != null)
            {
                await mongodb.DeleteProduct(universalProduct);
                Console.WriteLine(universalProduct);
                clearItems();
            }
        }

        private void mouseHover_search_btn_delete(object sender, EventArgs e)
        {
            picbox_search_update.BackColor = Color.DarkRed;
        }

        private void mouseLeave_search_btn_delete(object sender, EventArgs e)
        {
            picbox_search_update.BackColor = SystemColors.Control;

        }
    }
}
