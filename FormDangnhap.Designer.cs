namespace DOAAn
{
    partial class FormDangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangnhap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Loi = new System.Windows.Forms.Label();
            this.panel_khung = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.PassInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_khung.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(289, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 224);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label_Loi);
            this.panel1.Controls.Add(this.panel_khung);
            this.panel1.Location = new System.Drawing.Point(203, 207);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 400);
            this.panel1.TabIndex = 1;
            // 
            // label_Loi
            // 
            this.label_Loi.BackColor = System.Drawing.Color.LightCoral;
            this.label_Loi.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Loi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Loi.Location = new System.Drawing.Point(0, 0);
            this.label_Loi.Name = "label_Loi";
            this.label_Loi.Size = new System.Drawing.Size(389, 41);
            this.label_Loi.TabIndex = 7;
            this.label_Loi.Text = "Tài khoản hoặc mật khẩu không hợp lệ!";
            this.label_Loi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Loi.Click += new System.EventHandler(this.label_Loi_Click);
            // 
            // panel_khung
            // 
            this.panel_khung.BackColor = System.Drawing.Color.Transparent;
            this.panel_khung.Controls.Add(this.linkLabel2);
            this.panel_khung.Controls.Add(this.linkLabel1);
            this.panel_khung.Controls.Add(this.button1);
            this.panel_khung.Controls.Add(this.PassInput);
            this.panel_khung.Controls.Add(this.label2);
            this.panel_khung.Controls.Add(this.NameInput);
            this.panel_khung.Controls.Add(this.label1);
            this.panel_khung.Location = new System.Drawing.Point(0, 8);
            this.panel_khung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_khung.Name = "panel_khung";
            this.panel_khung.Size = new System.Drawing.Size(389, 365);
            this.panel_khung.TabIndex = 0;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.ForeColor = System.Drawing.Color.White;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(226, 289);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(84, 28);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Đăng ký";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(64, 289);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(154, 28);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(64, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PassInput
            // 
            this.PassInput.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassInput.Location = new System.Drawing.Point(48, 148);
            this.PassInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PassInput.Name = "PassInput";
            this.PassInput.Size = new System.Drawing.Size(286, 36);
            this.PassInput.TabIndex = 3;
            this.PassInput.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameInput.Location = new System.Drawing.Point(48, 60);
            this.NameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(286, 36);
            this.NameInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // FormDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDangnhap";
            this.Text = "FormDangnhap";
            this.Load += new System.EventHandler(this.FormDangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_khung.ResumeLayout(false);
            this.panel_khung.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel_khung;
        private TextBox NameInput;
        private Label label1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Button button1;
        private TextBox PassInput;
        private Label label2;
        private Label label_Loi;
    }
}