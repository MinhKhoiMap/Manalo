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
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SinhVienGrid
            // 
            this.SinhVienGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SinhVienGrid.Location = new System.Drawing.Point(1, 0);
            this.SinhVienGrid.Name = "SinhVienGrid";
            this.SinhVienGrid.RowHeadersWidth = 51;
            this.SinhVienGrid.RowTemplate.Height = 29;
            this.SinhVienGrid.Size = new System.Drawing.Size(1055, 324);
            this.SinhVienGrid.TabIndex = 0;
            // 
            // AddSinhVien
            // 
            this.AddSinhVien.Location = new System.Drawing.Point(291, 361);
            this.AddSinhVien.Name = "AddSinhVien";
            this.AddSinhVien.Size = new System.Drawing.Size(94, 29);
            this.AddSinhVien.TabIndex = 1;
            this.AddSinhVien.Text = "Thêm";
            this.AddSinhVien.UseVisualStyleBackColor = true;
            // 
            // UpdateSinhvien
            // 
            this.UpdateSinhvien.Location = new System.Drawing.Point(430, 361);
            this.UpdateSinhvien.Name = "UpdateSinhvien";
            this.UpdateSinhvien.Size = new System.Drawing.Size(94, 29);
            this.UpdateSinhvien.TabIndex = 2;
            this.UpdateSinhvien.Text = "Sửa";
            this.UpdateSinhvien.UseVisualStyleBackColor = true;
            // 
            // DeleteSinhVien
            // 
            this.DeleteSinhVien.Location = new System.Drawing.Point(577, 361);
            this.DeleteSinhVien.Name = "DeleteSinhVien";
            this.DeleteSinhVien.Size = new System.Drawing.Size(94, 29);
            this.DeleteSinhVien.TabIndex = 3;
            this.DeleteSinhVien.Text = "Xóa";
            this.DeleteSinhVien.UseVisualStyleBackColor = true;
            // 
            // Danhsachsinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 425);
            this.Controls.Add(this.DeleteSinhVien);
            this.Controls.Add(this.UpdateSinhvien);
            this.Controls.Add(this.AddSinhVien);
            this.Controls.Add(this.SinhVienGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Danhsachsinhvien";
            this.Text = "Danhsachsinhvien";
            this.Load += new System.EventHandler(this.Danhsachsinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView SinhVienGrid;
        private Button AddSinhVien;
        private Button UpdateSinhvien;
        private Button DeleteSinhVien;
    }
}