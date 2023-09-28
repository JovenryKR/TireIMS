namespace TireIMS
{
    partial class SellForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellForm));
            dgv_sell_menu = new DataGridView();
            txtb_size_sell = new TextBox();
            btn_search_sell = new Button();
            panel1 = new Panel();
            lbl_delete = new Label();
            btn_sell = new Button();
            dgv_cart = new DataGridView();
            txtb_pattern_sell = new TextBox();
            textBox2 = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_sell_menu).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_cart).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_sell_menu
            // 
            dgv_sell_menu.BackgroundColor = SystemColors.ControlLight;
            dgv_sell_menu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sell_menu.Dock = DockStyle.Bottom;
            dgv_sell_menu.Location = new Point(0, 155);
            dgv_sell_menu.MaximumSize = new Size(840, 240);
            dgv_sell_menu.MinimumSize = new Size(840, 230);
            dgv_sell_menu.Name = "dgv_sell_menu";
            dgv_sell_menu.RowTemplate.Height = 25;
            dgv_sell_menu.Size = new Size(840, 230);
            dgv_sell_menu.TabIndex = 1;
            dgv_sell_menu.CellDoubleClick += dgv_sell_menu_CellDoubleClick;
            // 
            // txtb_size_sell
            // 
            txtb_size_sell.BackColor = Color.White;
            txtb_size_sell.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_size_sell.Location = new Point(3, 12);
            txtb_size_sell.Name = "txtb_size_sell";
            txtb_size_sell.PlaceholderText = "Size";
            txtb_size_sell.Size = new Size(253, 29);
            txtb_size_sell.TabIndex = 2;
            // 
            // btn_search_sell
            // 
            btn_search_sell.BackColor = Color.FromArgb(64, 64, 64);
            btn_search_sell.FlatAppearance.BorderSize = 0;
            btn_search_sell.FlatStyle = FlatStyle.Flat;
            btn_search_sell.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_search_sell.ForeColor = Color.White;
            btn_search_sell.Location = new Point(3, 128);
            btn_search_sell.Name = "btn_search_sell";
            btn_search_sell.Size = new Size(253, 42);
            btn_search_sell.TabIndex = 3;
            btn_search_sell.Text = "Search";
            btn_search_sell.UseVisualStyleBackColor = false;
            btn_search_sell.Click += btn_search_sell_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_delete);
            panel1.Controls.Add(btn_sell);
            panel1.Controls.Add(dgv_cart);
            panel1.Location = new Point(262, 1);
            panel1.MaximumSize = new Size(576, 186);
            panel1.MinimumSize = new Size(576, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 186);
            panel1.TabIndex = 4;
            // 
            // lbl_delete
            // 
            lbl_delete.AutoSize = true;
            lbl_delete.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_delete.Location = new Point(439, 156);
            lbl_delete.Name = "lbl_delete";
            lbl_delete.Size = new Size(42, 15);
            lbl_delete.TabIndex = 8;
            lbl_delete.Text = "CLEAR";
            lbl_delete.Click += lbl_delete_Click;
            // 
            // btn_sell
            // 
            btn_sell.BackColor = Color.White;
            btn_sell.FlatAppearance.BorderSize = 0;
            btn_sell.FlatStyle = FlatStyle.Flat;
            btn_sell.ForeColor = Color.FromArgb(64, 64, 64);
            btn_sell.Image = (Image)resources.GetObject("btn_sell.Image");
            btn_sell.ImageAlign = ContentAlignment.MiddleRight;
            btn_sell.Location = new Point(499, 149);
            btn_sell.Name = "btn_sell";
            btn_sell.Size = new Size(65, 28);
            btn_sell.TabIndex = 7;
            btn_sell.Text = "SELL";
            btn_sell.TextAlign = ContentAlignment.MiddleLeft;
            btn_sell.UseVisualStyleBackColor = false;
            btn_sell.Click += btn_sell_Click;
            // 
            // dgv_cart
            // 
            dgv_cart.BackgroundColor = Color.White;
            dgv_cart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_cart.Dock = DockStyle.Left;
            dgv_cart.Location = new Point(0, 0);
            dgv_cart.MaximumSize = new Size(574, 146);
            dgv_cart.MinimumSize = new Size(574, 146);
            dgv_cart.Name = "dgv_cart";
            dgv_cart.RowTemplate.Height = 25;
            dgv_cart.Size = new Size(574, 146);
            dgv_cart.TabIndex = 1;
            dgv_cart.CellDoubleClick += dgv_cart_CellDoubleClick;
            // 
            // txtb_pattern_sell
            // 
            txtb_pattern_sell.BackColor = Color.White;
            txtb_pattern_sell.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_pattern_sell.Location = new Point(3, 47);
            txtb_pattern_sell.Name = "txtb_pattern_sell";
            txtb_pattern_sell.PlaceholderText = "Pattern";
            txtb_pattern_sell.Size = new Size(253, 29);
            txtb_pattern_sell.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(3, 82);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Brand";
            textBox2.Size = new Size(253, 29);
            textBox2.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtb_size_sell);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(btn_search_sell);
            panel2.Controls.Add(txtb_pattern_sell);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.MaximumSize = new Size(259, 186);
            panel2.MinimumSize = new Size(259, 186);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 186);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(3, 156);
            label1.Name = "label1";
            label1.Size = new Size(49, 23);
            label1.TabIndex = 9;
            label1.Text = "CART";
            // 
            // SellForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 385);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgv_sell_menu);
            MaximumSize = new Size(854, 424);
            MinimumSize = new Size(854, 424);
            Name = "SellForm";
            Text = "SellForm";
            ((System.ComponentModel.ISupportInitialize)dgv_sell_menu).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_cart).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgv_sell_menu;
        private TextBox txtb_size_sell;
        private Button btn_search_sell;
        private Panel panel1;
        private TextBox txtb_pattern_sell;
        private TextBox textBox2;
        private DataGridView dgv_cart;
        private Button btn_sell;
        private Panel panel2;
        private Label lbl_delete;
        private Label label1;
    }
}