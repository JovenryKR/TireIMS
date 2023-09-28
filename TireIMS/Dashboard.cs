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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        private void picb_close_all_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Close();
            login.Show();
        }

        private Form active_form = null;

        private void ActiveForm(Form currentForm)
        {
            if (active_form != null)
            {
                active_form.Close();
            }

            active_form = currentForm;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.None;
            currentForm.StartPosition = FormStartPosition.CenterScreen;

            int x = (Dashboard_panel.Width - currentForm.Width) / 2;
            int y = (Dashboard_panel.Height - currentForm.Height) / 2;

            // Set the form's location
            currentForm.Location = new Point(x, y);

            Dashboard_panel.Controls.Add(currentForm);
            currentForm.Show();
        }

        private void btn_insert_menu_Click(object sender, EventArgs e)
        {
            if (active_form == null || active_form.GetType() != typeof(InsertForm))
            {
                ActiveForm(new InsertForm());
            }
        }

        private void btn_update_menu(object sender, EventArgs e)
        {
            if (active_form == null || active_form.GetType() != typeof(UpdateForm))
            {
                ActiveForm(new UpdateForm());
            }
        }

        private void btn_del_menu(object sender, EventArgs e)
        {
            if (active_form == null || active_form.GetType() != typeof(DeleteForm))
            {
                ActiveForm(new DeleteForm());
            }
        }

        private void btn_dashboard_menu(object sender, EventArgs e)
        {
            if (active_form == null || active_form.GetType() != typeof(DashboardForm))
            {
                ActiveForm(new DashboardForm());
            }
        }

        private void btn_sell_menu_Click(object sender, EventArgs e)
        {
            if (active_form == null || active_form.GetType() != typeof(SellForm))
            {
                ActiveForm(new SellForm());
            }
        }
    }
}
