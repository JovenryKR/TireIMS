using LiveCharts;
using LiveCharts.Wpf.Charts.Base;
using LiveCharts.Wpf;
using MongoDB.Bson;
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
    public partial class DashboardForm : Form
    {
        private mongodb_drivers mongodb = new mongodb_drivers("tireIMS");

        public DashboardForm()
        {
            InitializeComponent();
            loadProducts();
            DailySale();
            TotalProduct();
        }

        //Stock on Hand
        private async void loadProducts()
        {
            List<Product> products = await mongodb.GetAllProducts();
            int sum = 0;

            foreach (var product in products)
            {
                sum += product.QTY;
            }

            lbl_Stock_on_hand.Text = sum.ToString();

        }

        //Daily sale
        private async void DailySale()
        {
            DateTime dateNow = DateTime.Now;

            List<Receipt> receipts = new List<Receipt>();
            receipts = await mongodb.GetDailyReceipts(dateNow);
            int sum = 0;

            foreach (var receipt in receipts)
            {
                foreach (var product in receipt.Products)
                {
                    sum += 1;
                }
            }

            lbl_daily_sale.Text = sum.ToString();
        }

        //Total Product
        private async void TotalProduct()
        {
            List<Product> products = new List<Product>();
            products = await mongodb.GetAllProducts();
            int sum = 0;

            foreach (var product in products)
            {
                sum += 1;
            }
            lbl_total_product.Text = sum.ToString();
        }

    }
}
