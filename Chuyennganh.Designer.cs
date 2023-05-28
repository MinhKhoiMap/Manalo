namespace DOAAn
{
    partial class Chuyennganh
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
            this.ChuyenNganhGrid = new System.Windows.Forms.DataGridView();
            this.AddChuyenNganh = new System.Windows.Forms.Button();
            this.UpdateChuyenNganh = new System.Windows.Forms.Button();
            this.DeleteChuyenNganhButt = new System.Windows.Forms.Button();
            this.ts = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChuyenNganhGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ChuyenNganhGrid
            // 
            this.ChuyenNganhGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ChuyenNganhGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ChuyenNganhGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChuyenNganhGrid.Location = new System.Drawing.Point(0, 0);
            this.ChuyenNganhGrid.Name = "ChuyenNganhGrid";
            this.ChuyenNganhGrid.RowHeadersWidth = 51;
            this.ChuyenNganhGrid.RowTemplate.Height = 29;
            this.ChuyenNganhGrid.Size = new System.Drawing.Size(919, 216);
            this.ChuyenNganhGrid.TabIndex = 0;
            // 
            // AddChuyenNganh
            // 
            this.AddChuyenNganh.Location = new System.Drawing.Point(238, 345);
            this.AddChuyenNganh.Name = "AddChuyenNganh";
            this.AddChuyenNganh.Size = new System.Drawing.Size(94, 29);
            this.AddChuyenNganh.TabIndex = 1;
            this.AddChuyenNganh.Text = "Thêm";
            this.AddChuyenNganh.UseVisualStyleBackColor = true;
            this.AddChuyenNganh.Click += new System.EventHandler(this.AddChuyenNganh_Click);
            // 
            // UpdateChuyenNganh
            // 
            this.UpdateChuyenNganh.Location = new System.Drawing.Point(407, 345);
            this.UpdateChuyenNganh.Name = "UpdateChuyenNganh";
            this.UpdateChuyenNganh.Size = new System.Drawing.Size(94, 29);
            this.UpdateChuyenNganh.TabIndex = 2;
            this.UpdateChuyenNganh.Text = "Sửa";
            this.UpdateChuyenNganh.UseVisualStyleBackColor = true;
            this.UpdateChuyenNganh.Click += new System.EventHandler(this.UpdateChuyenNganh_Click);
            // 
            // DeleteChuyenNganhButt
            // 
            this.DeleteChuyenNganhButt.Location = new System.Drawing.Point(572, 345);
            this.DeleteChuyenNganhButt.Name = "DeleteChuyenNganhButt";
            this.DeleteChuyenNganhButt.Size = new System.Drawing.Size(94, 29);
            this.DeleteChuyenNganhButt.TabIndex = 3;
            this.DeleteChuyenNganhButt.Text = "Xóa";
            this.DeleteChuyenNganhButt.UseVisualStyleBackColor = true;
            this.DeleteChuyenNganhButt.Click += new System.EventHandler(this.DeleteChuyenNganhButt_Click);
            // 
            // ts
            // 
            this.ts.AutoSize = true;
            this.ts.Location = new System.Drawing.Point(259, 264);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(130, 20);
            this.ts.TabIndex = 4;
            this.ts.Text = "Tên chuyên ngành:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 27);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(395, 261);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 27);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(706, 262);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(208, 27);
            this.textBox3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã chuyên ngành:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên ngành:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(395, 303);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(203, 27);
            this.textBox4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã ngành:";
            // 
            // Chuyennganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.DeleteChuyenNganhButt);
            this.Controls.Add(this.UpdateChuyenNganh);
            this.Controls.Add(this.AddChuyenNganh);
            this.Controls.Add(this.ChuyenNganhGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Chuyennganh";
            this.Text = "Chuyennganh";
            this.Load += new System.EventHandler(this.Chuyennganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChuyenNganhGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView ChuyenNganhGrid;
        private Button AddChuyenNganh;
        private Button UpdateChuyenNganh;
        private Button DeleteChuyenNganhButt;
        private Label ts;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private TextBox textBox4;
        private Label label3;
    }
}