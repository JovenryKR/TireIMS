namespace TireIMS
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            txtb_brand_update = new TextBox();
            label2 = new Label();
            txtb_pattern_update = new TextBox();
            label1 = new Label();
            txtb_size_update = new TextBox();
            picbox_search_update = new PictureBox();
            btn_add_insert = new Button();
            label6 = new Label();
            txtb_quantity_update = new TextBox();
            label7 = new Label();
            txtb_price_update = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbox_search_update).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 69);
            panel1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(114, 19);
            label4.Name = "label4";
            label4.Size = new Size(162, 32);
            label4.TabIndex = 0;
            label4.Text = "Update Form";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(48, 186);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 13;
            label3.Text = "Brand";
            // 
            // txtb_brand_update
            // 
            txtb_brand_update.Location = new Point(131, 184);
            txtb_brand_update.Name = "txtb_brand_update";
            txtb_brand_update.Size = new Size(183, 23);
            txtb_brand_update.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(48, 140);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 11;
            label2.Text = "Pattern";
            // 
            // txtb_pattern_update
            // 
            txtb_pattern_update.Location = new Point(131, 140);
            txtb_pattern_update.Name = "txtb_pattern_update";
            txtb_pattern_update.Size = new Size(183, 23);
            txtb_pattern_update.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(48, 101);
            label1.Name = "label1";
            label1.Size = new Size(41, 21);
            label1.TabIndex = 9;
            label1.Text = "Size";
            // 
            // txtb_size_update
            // 
            txtb_size_update.Location = new Point(131, 99);
            txtb_size_update.Name = "txtb_size_update";
            txtb_size_update.Size = new Size(183, 23);
            txtb_size_update.TabIndex = 8;
            // 
            // picbox_search_update
            // 
            picbox_search_update.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picbox_search_update.BackColor = Color.Transparent;
            picbox_search_update.Image = (Image)resources.GetObject("picbox_search_update.Image");
            picbox_search_update.Location = new Point(69, 333);
            picbox_search_update.Name = "picbox_search_update";
            picbox_search_update.Size = new Size(53, 39);
            picbox_search_update.SizeMode = PictureBoxSizeMode.Zoom;
            picbox_search_update.TabIndex = 18;
            picbox_search_update.TabStop = false;
            picbox_search_update.Click += search_btn_update;
            picbox_search_update.MouseLeave += mouseLeave_btn_search_update;
            picbox_search_update.MouseHover += mouseHover_btn_search_update;
            // 
            // btn_add_insert
            // 
            btn_add_insert.BackColor = Color.FromArgb(64, 64, 64);
            btn_add_insert.FlatAppearance.BorderSize = 0;
            btn_add_insert.FlatStyle = FlatStyle.Flat;
            btn_add_insert.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add_insert.ForeColor = Color.White;
            btn_add_insert.Location = new Point(133, 328);
            btn_add_insert.MaximumSize = new Size(277, 49);
            btn_add_insert.Name = "btn_add_insert";
            btn_add_insert.Size = new Size(183, 49);
            btn_add_insert.TabIndex = 19;
            btn_add_insert.Text = "Update";
            btn_add_insert.UseVisualStyleBackColor = false;
            btn_add_insert.Click += btn_updateForm;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(48, 275);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 23;
            label6.Text = "Quantity";
            // 
            // txtb_quantity_update
            // 
            txtb_quantity_update.Location = new Point(131, 277);
            txtb_quantity_update.Name = "txtb_quantity_update";
            txtb_quantity_update.Size = new Size(183, 23);
            txtb_quantity_update.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(48, 227);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 21;
            label7.Text = "Price";
            // 
            // txtb_price_update
            // 
            txtb_price_update.Location = new Point(131, 229);
            txtb_price_update.Name = "txtb_price_update";
            txtb_price_update.Size = new Size(183, 23);
            txtb_price_update.TabIndex = 20;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(380, 424);
            Controls.Add(label6);
            Controls.Add(txtb_quantity_update);
            Controls.Add(label7);
            Controls.Add(txtb_price_update);
            Controls.Add(btn_add_insert);
            Controls.Add(picbox_search_update);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(txtb_brand_update);
            Controls.Add(label2);
            Controls.Add(txtb_pattern_update);
            Controls.Add(label1);
            Controls.Add(txtb_size_update);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(380, 424);
            MinimumSize = new Size(380, 424);
            Name = "UpdateForm";
            Text = "UpdateForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbox_search_update).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private TextBox txtb_brand_update;
        private Label label2;
        private TextBox txtb_pattern_update;
        private Label label1;
        private TextBox txtb_size_update;
        private TextBox txtb_search_update;
        private PictureBox picbox_search_update;
        private Button btn_add_insert;
        private Label label6;
        private TextBox txtb_quantity_update;
        private Label label7;
        private TextBox txtb_price_update;
    }
}