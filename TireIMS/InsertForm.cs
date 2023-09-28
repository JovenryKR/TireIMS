using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TireIMS
{
    public partial class InsertForm : Form
    {

        private mongodb_drivers mongodb = new mongodb_drivers("tireIMS");
        public InsertForm()
        {
            InitializeComponent();
        }

        //Clear list items
        private void clearItems()
        {
            txtb_brand_insert.Text = "";
            txtb_pattern_insert.Text = "";
            txtb_price_insert.Text = "";
            txtb_quantity_insert.Text = "";
            txtb_size_insert.Text = "";
        }

        private async void btn_addProduct_click(object sender, EventArgs e)
        {
            string size = txtb_size_insert.Text;
            string pattern = txtb_pattern_insert.Text;
            string brand = txtb_brand_insert.Text;
            float price = float.Parse(txtb_price_insert.Text);
            int quantity = int.Parse(txtb_quantity_insert.Text);



            var product = new Product
            {
                Size = size,
                Pattern = pattern,
                Brand = brand,
                Price = price,
                QTY = quantity
            };

            await mongodb.insertProduct(product);
            MessageBox.Show("Added Successfully");
            clearItems();
        }
    }
}
