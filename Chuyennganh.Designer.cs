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
            this.ChuyenNganhGrid.Size = new System.Drawing.Size(878, 291);
            this.ChuyenNganhGrid.TabIndex = 0;
            // 
            // AddChuyenNganh
            // 
            this.AddChuyenNganh.Location = new System.Drawing.Point(247, 326);
            this.AddChuyenNganh.Name = "AddChuyenNganh";
            this.AddChuyenNganh.Size = new System.Drawing.Size(94, 29);
            this.AddChuyenNganh.TabIndex = 1;
            this.AddChuyenNganh.Text = "Thêm";
            this.AddChuyenNganh.UseVisualStyleBackColor = true;
            // 
            // UpdateChuyenNganh
            // 
            this.UpdateChuyenNganh.Location = new System.Drawing.Point(416, 326);
            this.UpdateChuyenNganh.Name = "UpdateChuyenNganh";
            this.UpdateChuyenNganh.Size = new System.Drawing.Size(94, 29);
            this.UpdateChuyenNganh.TabIndex = 2;
            this.UpdateChuyenNganh.Text = "Sửa";
            this.UpdateChuyenNganh.UseVisualStyleBackColor = true;
            // 
            // DeleteChuyenNganhButt
            // 
            this.DeleteChuyenNganhButt.Location = new System.Drawing.Point(577, 326);
            this.DeleteChuyenNganhButt.Name = "DeleteChuyenNganhButt";
            this.DeleteChuyenNganhButt.Size = new System.Drawing.Size(94, 29);
            this.DeleteChuyenNganhButt.TabIndex = 3;
            this.DeleteChuyenNganhButt.Text = "Xóa";
            this.DeleteChuyenNganhButt.UseVisualStyleBackColor = true;
            // 
            // Chuyennganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 396);
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

        }

        #endregion

        private DataGridView ChuyenNganhGrid;
        private Button AddChuyenNganh;
        private Button UpdateChuyenNganh;
        private Button DeleteChuyenNganhButt;
    }
}