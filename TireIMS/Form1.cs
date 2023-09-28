namespace TireIMS
{
    public partial class Form1 : Form
    {
        private mongodb_drivers mongodb = new mongodb_drivers("tireIMS");
        private bool isDragging = false;
        private Point offset;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_MouseEnter(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.Black;
            btn_login.ForeColor = Color.White;
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.BackColor = SystemColors.ButtonFace;
            btn_login.ForeColor = Color.Black;
        }

        private void picb_close_MouseEnter(object sender, EventArgs e)
        {
            picb_close.BackColor = Color.Red;
        }

        private void picb_close_MouseLeave(object sender, EventArgs e)
        {
            picb_close.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void picb_close_Click(object sender, EventArgs e)
        {
            List<Form> list = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                list.Add(form);
            }

            foreach (Form form in list)
            {
                form.Close();
            }
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            string username = txtb_username.Text;
            string password = txtb_password.Text;
            bool isCredintialGood = mongodb.CheckCredentials(username, password);
            if (isCredintialGood)
            {
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password please try again");
            }
        }

        private void txtb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = txtb_username.Text;
                string password = txtb_password.Text;
                bool isCredintialGood = mongodb.CheckCredentials(username, password);
                if (isCredintialGood)
                {
                    Dashboard dashboard = new Dashboard();
                    this.Hide();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Wrong username or password please try again");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.MouseDown += (s, args) =>
            {
                if (args.Button == MouseButtons.Left)
                {
                    isDragging = true;
                    offset = new Point(args.X, args.Y);
                }
            };

            this.MouseMove += (s, args) =>
            {
                if (isDragging)
                {
                    Point newLocation = this.PointToScreen(new Point(args.X, args.Y));
                    newLocation.Offset(-offset.X, -offset.Y);
                    this.Location = newLocation;
                }
            };

            this.MouseUp += (s, args) =>
            {
                if (args.Button == MouseButtons.Left)
                {
                    isDragging = false;
                }
            };
        }
    }
}