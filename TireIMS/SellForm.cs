using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;


namespace TireIMS
{
    public partial class SellForm : Form
    {
        private mongodb_drivers mongodb = new mongodb_drivers("tireIMS");

        public SellForm()
        {
            InitializeComponent();
            load_all_product();
            dgv_cart.ReadOnly = true;
            dgv_sell_menu.ReadOnly = true;
        }

        List<Product> cart = new List<Product>();


        private async void btn_search_sell_Click(object sender, EventArgs e)
        {
            string size = txtb_size_sell.Text;
            List<Product> products = await mongodb.SearchProductToList(size);

            dgv_sell_menu.DataSource = products;
        }

        private async void load_all_product()
        {
            List<Product> products = await mongodb.GetAllProducts();
            dgv_sell_menu.DataSource = products;

        }

        private void dgv_sell_menu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_sell_menu.Rows[e.RowIndex];
                Product selectedProduct = (Product)selectedRow.DataBoundItem;
                cart.Add(selectedProduct);
                //MessageBox.Show($"You selected product with ID: {selectedProduct}");
                dgv_cart.DataSource = null;
                dgv_cart.DataSource = cart;
            }
        }

        private void dgv_cart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_cart.CurrentRow != null)
            {
                int rowIndex = dgv_cart.CurrentRow.Index;

                if (rowIndex >= 0 && rowIndex < dgv_cart.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgv_cart.Rows[rowIndex];
                    Product selectedProduct = (Product)selectedRow.DataBoundItem;

                    cart.Remove(selectedProduct);

                    dgv_cart.DataSource = null;
                    dgv_cart.DataSource = cart;
                }
            }
        }

        private async void btn_sell_Click(object sender, EventArgs e)
        {
            Dictionary<ObjectId, int> productQtyUpdate = new Dictionary<ObjectId, int>();
            List<float> list = new List<float>();
            float sum;

            foreach (var item in cart)
            {
                if (item.QTY > 0)
                {
                    if (!productQtyUpdate.ContainsKey(item.Id))
                    {
                        productQtyUpdate.Add(item.Id, item.QTY - 1);
                    }
                    else
                    {
                        productQtyUpdate[item.Id] = productQtyUpdate[item.Id] - 1;
                    }
                    list.Add(item.Price);
                }
                else
                {

                    MessageBox.Show($"{item.Size} is not in stock");
                    cart.Clear();
                    return;
                }
            }
            sum = list.Sum();

            Receipt receipt = new Receipt();
            receipt.Products = cart;
            receipt.TotalAmount = sum;
            receipt.PurchaseDate = DateTime.Now;

            await mongodb.DecrementProductQty(productQtyUpdate);
            await mongodb.CreateReceipt(receipt);
            MessageBox.Show(sum.ToString());
            dgv_sell_menu.DataSource = null;
            dgv_cart.DataSource = null;
            cart.Clear();
            load_all_product();
        }

        private void lbl_delete_Click(object sender, EventArgs e)
        {
            cart.Clear();
            dgv_cart.DataSource = null;
        }
    }
}
