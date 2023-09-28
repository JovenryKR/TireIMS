namespace TireIMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btn_login = new Button();
            txtb_password = new TextBox();
            txtb_username = new TextBox();
            panel1 = new Panel();
            picb_close = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picb_close).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btn_login);
            panel2.Controls.Add(txtb_password);
            panel2.Controls.Add(txtb_username);
            panel2.Location = new Point(29, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 331);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(105, 88);
            label1.Name = "label1";
            label1.Size = new Size(104, 45);
            label1.TabIndex = 6;
            label1.Text = "LOGIN";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(18, 204);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 156);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_login.BackColor = Color.Black;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(88, 263);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(145, 41);
            btn_login.TabIndex = 2;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            btn_login.MouseEnter += btn_login_MouseEnter;
            btn_login.MouseLeave += btn_login_MouseLeave;
            // 
            // txtb_password
            // 
            txtb_password.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtb_password.Font = new Font("Lucida Console", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_password.Location = new Point(44, 205);
            txtb_password.Name = "txtb_password";
            txtb_password.PasswordChar = '*';
            txtb_password.PlaceholderText = "Password";
            txtb_password.Size = new Size(231, 22);
            txtb_password.TabIndex = 1;
            txtb_password.TextAlign = HorizontalAlignment.Center;
            txtb_password.KeyDown += txtb_password_KeyDown;
            // 
            // txtb_username
            // 
            txtb_username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtb_username.Font = new Font("Lucida Console", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_username.Location = new Point(45, 157);
            txtb_username.Name = "txtb_username";
            txtb_username.PlaceholderText = "Username";
            txtb_username.Size = new Size(231, 22);
            txtb_username.TabIndex = 0;
            txtb_username.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(picb_close);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 389);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // picb_close
            // 
            picb_close.BackColor = Color.Red;
            picb_close.Image = (Image)resources.GetObject("picb_close.Image");
            picb_close.Location = new Point(349, 4);
            picb_close.Name = "picb_close";
            picb_close.Size = new Size(26, 25);
            picb_close.SizeMode = PictureBoxSizeMode.StretchImage;
            picb_close.TabIndex = 1;
            picb_close.TabStop = false;
            picb_close.Click += picb_close_Click;
            picb_close.MouseEnter += picb_close_MouseEnter;
            picb_close.MouseLeave += picb_close_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 389);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(455, 450);
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picb_close).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btn_login;
        private TextBox txtb_password;
        private TextBox txtb_username;
        private Panel panel1;
        private PictureBox picb_close;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
    }
}