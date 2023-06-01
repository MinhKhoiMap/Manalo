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
            SinhVienGrid = new DataGridView();
            AddSinhVien = new Button();
            UpdateSinhvien = new Button();
            DeleteSinhVien = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            textBox9 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)SinhVienGrid).BeginInit();
            SuspendLayout();
            // 
            // SinhVienGrid
            // 
            SinhVienGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SinhVienGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SinhVienGrid.Location = new Point(1, 0);
            SinhVienGrid.Name = "SinhVienGrid";
            SinhVienGrid.RowHeadersWidth = 51;
            SinhVienGrid.RowTemplate.Height = 29;
            SinhVienGrid.Size = new Size(1058, 228);
            SinhVienGrid.TabIndex = 0;
            SinhVienGrid.CellContentClick += SinhVienGrid_CellContentClick;
            // 
            // AddSinhVien
            // 
            AddSinhVien.Location = new Point(291, 384);
            AddSinhVien.Name = "AddSinhVien";
            AddSinhVien.Size = new Size(94, 29);
            AddSinhVien.TabIndex = 1;
            AddSinhVien.Text = "Thêm";
            AddSinhVien.UseVisualStyleBackColor = true;
            AddSinhVien.Click += AddSinhVien_Click;
            // 
            // UpdateSinhvien
            // 
            UpdateSinhvien.Location = new Point(418, 384);
            UpdateSinhvien.Name = "UpdateSinhvien";
            UpdateSinhvien.Size = new Size(94, 29);
            UpdateSinhvien.TabIndex = 2;
            UpdateSinhvien.Text = "Sửa";
            UpdateSinhvien.UseVisualStyleBackColor = true;
            UpdateSinhvien.Click += UpdateSinhvien_Click;
            // 
            // DeleteSinhVien
            // 
            DeleteSinhVien.Location = new Point(540, 384);
            DeleteSinhVien.Name = "DeleteSinhVien";
            DeleteSinhVien.Size = new Size(94, 29);
            DeleteSinhVien.TabIndex = 3;
            DeleteSinhVien.Text = "Xóa";
            DeleteSinhVien.UseVisualStyleBackColor = true;
            DeleteSinhVien.Click += DeleteSinhVien_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 245);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 296);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(101, 355);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(377, 343);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(377, 245);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 248);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 10;
            label1.Text = "Mã số :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 299);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 11;
            label2.Text = "Họ tên :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(262, 252);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 13;
            label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 362);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 14;
            label5.Text = "Email :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(243, 299);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 15;
            label6.Text = "Mã người dùng: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(243, 350);
            label9.Name = "label9";
            label9.Size = new Size(128, 20);
            label9.TabIndex = 20;
            label9.Text = "Mã chuyên ngành:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(377, 292);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 21;
            // 
            // Danhsachsinhvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1059, 425);
            Controls.Add(textBox9);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(DeleteSinhVien);
            Controls.Add(UpdateSinhvien);
            Controls.Add(AddSinhVien);
            Controls.Add(SinhVienGrid);
            Margin = new Padding(2);
            Name = "Danhsachsinhvien";
            Text = "Danhsachsinhvien";
            Load += Danhsachsinhvien_Load;
            ((System.ComponentModel.ISupportInitialize)SinhVienGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
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