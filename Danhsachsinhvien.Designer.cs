namespace DOAAn
{
    partial class Danhsachsinhvien
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
            this.SinhVienGrid = new System.Windows.Forms.DataGridView();
            this.AddSinhVien = new System.Windows.Forms.Button();
            this.UpdateSinhvien = new System.Windows.Forms.Button();
            this.DeleteSinhVien = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SinhVienGrid
            // 
            this.SinhVienGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SinhVienGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SinhVienGrid.Location = new System.Drawing.Point(1, 0);
            this.SinhVienGrid.Name = "SinhVienGrid";
            this.SinhVienGrid.RowHeadersWidth = 51;
            this.SinhVienGrid.RowTemplate.Height = 29;
            this.SinhVienGrid.Size = new System.Drawing.Size(1058, 228);
            this.SinhVienGrid.TabIndex = 0;
            this.SinhVienGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SinhVienGrid_CellContentClick);
            // 
            // AddSinhVien
            // 
            this.AddSinhVien.Location = new System.Drawing.Point(291, 384);
            this.AddSinhVien.Name = "AddSinhVien";
            this.AddSinhVien.Size = new System.Drawing.Size(94, 29);
            this.AddSinhVien.TabIndex = 1;
            this.AddSinhVien.Text = "Thêm";
            this.AddSinhVien.UseVisualStyleBackColor = true;
            this.AddSinhVien.Click += new System.EventHandler(this.AddSinhVien_Click);
            // 
            // UpdateSinhvien
            // 
            this.UpdateSinhvien.Location = new System.Drawing.Point(418, 384);
            this.UpdateSinhvien.Name = "UpdateSinhvien";
            this.UpdateSinhvien.Size = new System.Drawing.Size(94, 29);
            this.UpdateSinhvien.TabIndex = 2;
            this.UpdateSinhvien.Text = "Sửa";
            this.UpdateSinhvien.UseVisualStyleBackColor = true;
            this.UpdateSinhvien.Click += new System.EventHandler(this.UpdateSinhvien_Click);
            // 
            // DeleteSinhVien
            // 
            this.DeleteSinhVien.Location = new System.Drawing.Point(540, 384);
            this.DeleteSinhVien.Name = "DeleteSinhVien";
            this.DeleteSinhVien.Size = new System.Drawing.Size(94, 29);
            this.DeleteSinhVien.TabIndex = 3;
            this.DeleteSinhVien.Text = "Xóa";
            this.DeleteSinhVien.UseVisualStyleBackColor = true;
            this.DeleteSinhVien.Click += new System.EventHandler(this.DeleteSinhVien_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 296);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(101, 355);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(377, 343);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 27);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(377, 245);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 27);
            this.textBox6.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã số :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Họ tên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã người dùng: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(243, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mã chuyên ngành:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(377, 292);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(125, 27);
            this.textBox9.TabIndex = 21;
            // 
            // Danhsachsinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 425);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeleteSinhVien);
            this.Controls.Add(this.UpdateSinhvien);
            this.Controls.Add(this.AddSinhVien);
            this.Controls.Add(this.SinhVienGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Danhsachsinhvien";
            this.Text = "Danhsachsinhvien";
            this.Load += new System.EventHandler(this.Danhsachsinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView SinhVienGrid;
        private Button AddSinhVien;
        private Button UpdateSinhvien;
        private Button DeleteSinhVien;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label9;
        private TextBox textBox9;
    }
}