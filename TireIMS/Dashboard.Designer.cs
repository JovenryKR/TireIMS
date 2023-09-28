namespace TireIMS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel_control = new Panel();
            picb_close_all = new PictureBox();
            dashboardTxt = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            del_btn_menu = new Button();
            update_btn_menu = new Button();
            btn_insert_menu = new Button();
            btn_sell_menu = new Button();
            btn_dashboard = new Button();
            Dashboard_panel = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picb_close_all).BeginInit();
            panel2.SuspendLayout();
            Dashboard_panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel_control
            // 
            panel_control.BackColor = Color.Black;
            panel_control.Controls.Add(picb_close_all);
            panel_control.Dock = DockStyle.Top;
            panel_control.Location = new Point(0, 0);
            panel_control.Name = "panel_control";
            panel_control.Size = new Size(1013, 59);
            panel_control.TabIndex = 0;
            // 
            // picb_close_all
            // 
            picb_close_all.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            picb_close_all.BackColor = Color.Red;
            picb_close_all.Image = (Image)resources.GetObject("picb_close_all.Image");
            picb_close_all.Location = new Point(974, 12);
            picb_close_all.Name = "picb_close_all";
            picb_close_all.Size = new Size(27, 30);
            picb_close_all.SizeMode = PictureBoxSizeMode.StretchImage;
            picb_close_all.TabIndex = 0;
            picb_close_all.TabStop = false;
            picb_close_all.Click += picb_close_all_Click;
            // 
            // dashboardTxt
            // 
            dashboardTxt.AutoSize = true;
            dashboardTxt.BackColor = Color.Transparent;
            dashboardTxt.FlatStyle = FlatStyle.Flat;
            dashboardTxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dashboardTxt.ForeColor = Color.Black;
            dashboardTxt.Location = new Point(7, 8);
            dashboardTxt.Name = "dashboardTxt";
            dashboardTxt.Size = new Size(130, 25);
            dashboardTxt.TabIndex = 1;
            dashboardTxt.Text = "DASHBOARD";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dashboardTxt);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(del_btn_menu);
            panel2.Controls.Add(update_btn_menu);
            panel2.Controls.Add(btn_insert_menu);
            panel2.Controls.Add(btn_sell_menu);
            panel2.Controls.Add(btn_dashboard);
            panel2.Location = new Point(0, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(145, 467);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 422);
            panel1.Name = "panel1";
            panel1.Size = new Size(145, 45);
            panel1.TabIndex = 4;
            // 
            // del_btn_menu
            // 
            del_btn_menu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            del_btn_menu.FlatAppearance.BorderSize = 0;
            del_btn_menu.FlatStyle = FlatStyle.Popup;
            del_btn_menu.Image = (Image)resources.GetObject("del_btn_menu.Image");
            del_btn_menu.ImageAlign = ContentAlignment.MiddleLeft;
            del_btn_menu.Location = new Point(0, 313);
            del_btn_menu.Name = "del_btn_menu";
            del_btn_menu.Size = new Size(142, 48);
            del_btn_menu.TabIndex = 1;
            del_btn_menu.Text = "Delete Menu";
            del_btn_menu.UseVisualStyleBackColor = true;
            del_btn_menu.Click += btn_del_menu;
            // 
            // update_btn_menu
            // 
            update_btn_menu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            update_btn_menu.FlatAppearance.BorderSize = 0;
            update_btn_menu.FlatStyle = FlatStyle.Popup;
            update_btn_menu.Image = (Image)resources.GetObject("update_btn_menu.Image");
            update_btn_menu.ImageAlign = ContentAlignment.MiddleLeft;
            update_btn_menu.Location = new Point(0, 257);
            update_btn_menu.Name = "update_btn_menu";
            update_btn_menu.Size = new Size(142, 48);
            update_btn_menu.TabIndex = 3;
            update_btn_menu.Text = "Update Menu";
            update_btn_menu.UseVisualStyleBackColor = true;
            update_btn_menu.Click += btn_update_menu;
            // 
            // btn_insert_menu
            // 
            btn_insert_menu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_insert_menu.FlatAppearance.BorderSize = 0;
            btn_insert_menu.FlatStyle = FlatStyle.Popup;
            btn_insert_menu.ForeColor = SystemColors.ControlText;
            btn_insert_menu.Image = (Image)resources.GetObject("btn_insert_menu.Image");
            btn_insert_menu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_insert_menu.Location = new Point(0, 196);
            btn_insert_menu.Name = "btn_insert_menu";
            btn_insert_menu.Size = new Size(142, 48);
            btn_insert_menu.TabIndex = 2;
            btn_insert_menu.Text = "Insert Menu";
            btn_insert_menu.UseVisualStyleBackColor = true;
            btn_insert_menu.Click += btn_insert_menu_Click;
            // 
            // btn_sell_menu
            // 
            btn_sell_menu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_sell_menu.FlatAppearance.BorderSize = 0;
            btn_sell_menu.FlatStyle = FlatStyle.Popup;
            btn_sell_menu.Image = (Image)resources.GetObject("btn_sell_menu.Image");
            btn_sell_menu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sell_menu.Location = new Point(0, 137);
            btn_sell_menu.Name = "btn_sell_menu";
            btn_sell_menu.Size = new Size(142, 48);
            btn_sell_menu.TabIndex = 1;
            btn_sell_menu.Text = "Sell Menu";
            btn_sell_menu.UseVisualStyleBackColor = true;
            btn_sell_menu.Click += btn_sell_menu_Click;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatStyle = FlatStyle.Popup;
            btn_dashboard.Image = (Image)resources.GetObject("btn_dashboard.Image");
            btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.Location = new Point(0, 77);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(142, 48);
            btn_dashboard.TabIndex = 0;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = true;
            btn_dashboard.Click += btn_dashboard_menu;
            // 
            // Dashboard_panel
            // 
            Dashboard_panel.Anchor = AnchorStyles.Top;
            Dashboard_panel.BackColor = Color.White;
            Dashboard_panel.Controls.Add(panel4);
            Dashboard_panel.Location = new Point(159, 59);
            Dashboard_panel.Name = "Dashboard_panel";
            Dashboard_panel.Size = new Size(854, 424);
            Dashboard_panel.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(-1, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 431);
            panel4.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 484);
            panel3.Name = "panel3";
            panel3.Size = new Size(1013, 45);
            panel3.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(148, 62);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 421);
            panel5.TabIndex = 6;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1013, 529);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(Dashboard_panel);
            Controls.Add(panel2);
            Controls.Add(panel_control);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel_control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picb_close_all).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Dashboard_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_control;
        private Panel panel2;
        private Panel Dashboard_panel;
        private PictureBox picb_close_all;
        private Button btn_sell_menu;
        private Button btn_dashboard;
        private Button del_btn_menu;
        private Button update_btn_menu;
        private Button btn_insert_menu;
        private Panel panel1;
        private Panel panel3;
        private Label dashboardTxt;
        private Panel panel4;
        private Panel panel5;
    }
}