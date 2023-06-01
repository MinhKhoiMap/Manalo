namespace DOAAn
{
    partial class FormGiangVien
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            informationToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            qlysv_btn = new Button();
            thongtingv_btn = new Button();
            trangchu_btn = new Button();
            panelDesktop = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 85);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoDOAN;
            pictureBox1.Location = new Point(546, 7);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem });
            menuStrip1.Location = new Point(1180, 25);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(58, 26);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem, informationToolStripMenuItem });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(52, 24);
            userToolStripMenuItem.Text = "User";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(181, 26);
            logOutToolStripMenuItem.Text = "Log Out";
            // 
            // informationToolStripMenuItem
            // 
            informationToolStripMenuItem.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            informationToolStripMenuItem.Size = new Size(181, 26);
            informationToolStripMenuItem.Text = "Information";
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(qlysv_btn);
            panel2.Controls.Add(thongtingv_btn);
            panel2.Controls.Add(trangchu_btn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 85);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1184, 49);
            panel2.TabIndex = 4;
            // 
            // qlysv_btn
            // 
            qlysv_btn.Dock = DockStyle.Left;
            qlysv_btn.FlatAppearance.BorderSize = 0;
            qlysv_btn.FlatStyle = FlatStyle.Flat;
            qlysv_btn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            qlysv_btn.ForeColor = Color.White;
            qlysv_btn.Location = new Point(396, 0);
            qlysv_btn.Margin = new Padding(2);
            qlysv_btn.Name = "qlysv_btn";
            qlysv_btn.Size = new Size(220, 49);
            qlysv_btn.TabIndex = 2;
            qlysv_btn.Text = "Quản lú sinh viên";
            qlysv_btn.UseVisualStyleBackColor = true;
            qlysv_btn.Click += qlysv_btn_Click;
            // 
            // thongtingv_btn
            // 
            thongtingv_btn.Dock = DockStyle.Left;
            thongtingv_btn.FlatAppearance.BorderSize = 0;
            thongtingv_btn.FlatStyle = FlatStyle.Flat;
            thongtingv_btn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            thongtingv_btn.ForeColor = Color.White;
            thongtingv_btn.Location = new Point(176, 0);
            thongtingv_btn.Margin = new Padding(2);
            thongtingv_btn.Name = "thongtingv_btn";
            thongtingv_btn.Size = new Size(220, 49);
            thongtingv_btn.TabIndex = 1;
            thongtingv_btn.Text = "Thông tin giảng viên";
            thongtingv_btn.UseVisualStyleBackColor = true;
            thongtingv_btn.Click += thongtingv_btn_Click;
            // 
            // trangchu_btn
            // 
            trangchu_btn.Dock = DockStyle.Left;
            trangchu_btn.FlatAppearance.BorderSize = 0;
            trangchu_btn.FlatStyle = FlatStyle.Flat;
            trangchu_btn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            trangchu_btn.ForeColor = Color.White;
            trangchu_btn.Location = new Point(0, 0);
            trangchu_btn.Margin = new Padding(2);
            trangchu_btn.Name = "trangchu_btn";
            trangchu_btn.Size = new Size(176, 49);
            trangchu_btn.TabIndex = 0;
            trangchu_btn.Text = "Trang chủ";
            trangchu_btn.UseVisualStyleBackColor = true;
            trangchu_btn.Click += trangchu_btn_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelDesktop.Dock = DockStyle.Bottom;
            panelDesktop.Location = new Point(0, 134);
            panelDesktop.Margin = new Padding(2);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1184, 525);
            panelDesktop.TabIndex = 5;
            // 
            // FormGiangVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 659);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panelDesktop);
            IsMdiContainer = true;
            Name = "FormGiangVien";
            Text = "FormGV";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem informationToolStripMenuItem;
        private Panel panel2;
        private Button thongtingv_btn;
        private Button trangchu_btn;
        private Panel panelDesktop;
        private Button qlysv_btn;
    }
}