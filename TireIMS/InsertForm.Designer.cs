namespace TireIMS
{
    partial class InsertForm
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
            txtb_size_insert = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtb_pattern_insert = new TextBox();
            label3 = new Label();
            txtb_brand_insert = new TextBox();
            btn_add_insert = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            txtb_price_insert = new TextBox();
            label6 = new Label();
            txtb_quantity_insert = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtb_size_insert
            // 
            txtb_size_insert.Location = new Point(143, 101);
            txtb_size_insert.Name = "txtb_size_insert";
            txtb_size_insert.Size = new Size(194, 23);
            txtb_size_insert.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(60, 103);
            label1.Name = "label1";
            label1.Size = new Size(41, 21);
            label1.TabIndex = 1;
            label1.Text = "Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(60, 142);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 3;
            label2.Text = "Pattern";
            // 
            // txtb_pattern_insert
            // 
            txtb_pattern_insert.Location = new Point(143, 142);
            txtb_pattern_insert.Name = "txtb_pattern_insert";
            txtb_pattern_insert.Size = new Size(194, 23);
            txtb_pattern_insert.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(60, 188);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 5;
            label3.Text = "Brand";
            // 
            // txtb_brand_insert
            // 
            txtb_brand_insert.Location = new Point(143, 186);
            txtb_brand_insert.Name = "txtb_brand_insert";
            txtb_brand_insert.Size = new Size(194, 23);
            txtb_brand_insert.TabIndex = 4;
            // 
            // btn_add_insert
            // 
            btn_add_insert.BackColor = Color.FromArgb(64, 64, 64);
            btn_add_insert.FlatAppearance.BorderSize = 0;
            btn_add_insert.FlatStyle = FlatStyle.Flat;
            btn_add_insert.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add_insert.ForeColor = Color.White;
            btn_add_insert.Location = new Point(60, 328);
            btn_add_insert.MaximumSize = new Size(277, 49);
            btn_add_insert.MinimumSize = new Size(277, 49);
            btn_add_insert.Name = "btn_add_insert";
            btn_add_insert.Size = new Size(277, 49);
            btn_add_insert.TabIndex = 6;
            btn_add_insert.Text = "Add Product";
            btn_add_insert.UseVisualStyleBackColor = false;
            btn_add_insert.Click += btn_addProduct_click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 69);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(114, 19);
            label4.Name = "label4";
            label4.Size = new Size(147, 32);
            label4.TabIndex = 0;
            label4.Text = "Insert Form";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(60, 232);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 9;
            label5.Text = "Price";
            // 
            // txtb_price_insert
            // 
            txtb_price_insert.Location = new Point(143, 230);
            txtb_price_insert.Name = "txtb_price_insert";
            txtb_price_insert.Size = new Size(194, 23);
            txtb_price_insert.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(60, 276);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 11;
            label6.Text = "Quantity";
            // 
            // txtb_quantity_insert
            // 
            txtb_quantity_insert.Location = new Point(143, 278);
            txtb_quantity_insert.Name = "txtb_quantity_insert";
            txtb_quantity_insert.Size = new Size(194, 23);
            txtb_quantity_insert.TabIndex = 10;
            // 
            // InsertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(380, 424);
            Controls.Add(label6);
            Controls.Add(txtb_quantity_insert);
            Controls.Add(label5);
            Controls.Add(txtb_price_insert);
            Controls.Add(panel1);
            Controls.Add(btn_add_insert);
            Controls.Add(label3);
            Controls.Add(txtb_brand_insert);
            Controls.Add(label2);
            Controls.Add(txtb_pattern_insert);
            Controls.Add(label1);
            Controls.Add(txtb_size_insert);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(380, 424);
            MinimumSize = new Size(380, 424);
            Name = "InsertForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InsertForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtb_size_insert;
        private Label label1;
        private Label label2;
        private TextBox txtb_pattern_insert;
        private Label label3;
        private TextBox txtb_brand_insert;
        private Button btn_add_insert;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private TextBox txtb_price_insert;
        private Label label6;
        private TextBox txtb_quantity_insert;
    }
}