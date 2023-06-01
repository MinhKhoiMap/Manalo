namespace DOAAn
{
    partial class Thongtingiangvien
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
            GVienGrid = new DataGridView();
            AddGVien = new Button();
            UpdateGvien = new Button();
            DeleGvien = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)GVienGrid).BeginInit();
            SuspendLayout();
            // 
            // GVienGrid
            // 
            GVienGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GVienGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GVienGrid.Location = new Point(-2, 0);
            GVienGrid.Name = "GVienGrid";
            GVienGrid.RowHeadersWidth = 51;
            GVienGrid.RowTemplate.Height = 29;
            GVienGrid.Size = new Size(1146, 235);
            GVienGrid.TabIndex = 0;
            // 
            // AddGVien
            // 
            AddGVien.Location = new Point(279, 432);
            AddGVien.Name = "AddGVien";
            AddGVien.Size = new Size(94, 29);
            AddGVien.TabIndex = 1;
            AddGVien.Text = "Thêm";
            AddGVien.UseVisualStyleBackColor = true;
            AddGVien.Click += AddGVien_Click;
            // 
            // UpdateGvien
            // 
            UpdateGvien.Location = new Point(454, 432);
            UpdateGvien.Name = "UpdateGvien";
            UpdateGvien.Size = new Size(94, 29);
            UpdateGvien.TabIndex = 2;
            UpdateGvien.Text = "Sửa";
            UpdateGvien.UseVisualStyleBackColor = true;
            UpdateGvien.Click += UpdateGvien_Click;
            // 
            // DeleGvien
            // 
            DeleGvien.Location = new Point(622, 432);
            DeleGvien.Name = "DeleGvien";
            DeleGvien.Size = new Size(94, 29);
            DeleGvien.TabIndex = 3;
            DeleGvien.Text = "Xóa";
            DeleGvien.UseVisualStyleBackColor = true;
            DeleGvien.Click += DeleGvien_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(574, 281);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 32;
            label5.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(527, 325);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 31;
            label4.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 325);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 29;
            label2.Text = "Họ tên :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 271);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 28;
            label1.Text = "Mã giảng viên:";
            label1.Click += label1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(633, 325);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 27;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(633, 274);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 25;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(357, 322);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(357, 271);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 22;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(998, 432);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 33;
            textBox3.Visible = false;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(998, 409);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 34;
            label3.Text = "Mã người dùng:";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // Thongtingiangvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 490);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(DeleGvien);
            Controls.Add(UpdateGvien);
            Controls.Add(AddGVien);
            Controls.Add(GVienGrid);
            Margin = new Padding(2);
            Name = "Thongtingiangvien";
            Text = "Thongtingiangvien";
            Load += Thongtingiangvien_Load;
            ((System.ComponentModel.ISupportInitialize)GVienGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GVienGrid;
        private Button AddGVien;
        private Button UpdateGvien;
        private Button DeleGvien;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox textBox6;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label3;
    }
}