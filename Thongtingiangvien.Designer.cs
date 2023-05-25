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
            this.GVienGrid = new System.Windows.Forms.DataGridView();
            this.AddGVien = new System.Windows.Forms.Button();
            this.UpdateGvien = new System.Windows.Forms.Button();
            this.DeleGvien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVienGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GVienGrid
            // 
            this.GVienGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVienGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVienGrid.Location = new System.Drawing.Point(-2, 0);
            this.GVienGrid.Name = "GVienGrid";
            this.GVienGrid.RowHeadersWidth = 51;
            this.GVienGrid.RowTemplate.Height = 29;
            this.GVienGrid.Size = new System.Drawing.Size(1146, 291);
            this.GVienGrid.TabIndex = 0;
            // 
            // AddGVien
            // 
            this.AddGVien.Location = new System.Drawing.Point(308, 310);
            this.AddGVien.Name = "AddGVien";
            this.AddGVien.Size = new System.Drawing.Size(94, 29);
            this.AddGVien.TabIndex = 1;
            this.AddGVien.Text = "Thêm";
            this.AddGVien.UseVisualStyleBackColor = true;
            // 
            // UpdateGvien
            // 
            this.UpdateGvien.Location = new System.Drawing.Point(484, 310);
            this.UpdateGvien.Name = "UpdateGvien";
            this.UpdateGvien.Size = new System.Drawing.Size(94, 29);
            this.UpdateGvien.TabIndex = 2;
            this.UpdateGvien.Text = "Sửa";
            this.UpdateGvien.UseVisualStyleBackColor = true;
            // 
            // DeleGvien
            // 
            this.DeleGvien.Location = new System.Drawing.Point(656, 310);
            this.DeleGvien.Name = "DeleGvien";
            this.DeleGvien.Size = new System.Drawing.Size(94, 29);
            this.DeleGvien.TabIndex = 3;
            this.DeleGvien.Text = "Xóa";
            this.DeleGvien.UseVisualStyleBackColor = true;
            // 
            // Thongtingiangvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 409);
            this.Controls.Add(this.DeleGvien);
            this.Controls.Add(this.UpdateGvien);
            this.Controls.Add(this.AddGVien);
            this.Controls.Add(this.GVienGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Thongtingiangvien";
            this.Text = "Thongtingiangvien";
            ((System.ComponentModel.ISupportInitialize)(this.GVienGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView GVienGrid;
        private Button AddGVien;
        private Button UpdateGvien;
        private Button DeleGvien;
    }
}