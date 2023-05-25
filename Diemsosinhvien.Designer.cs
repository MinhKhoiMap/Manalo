namespace DOAAn
{
    partial class Diemsosinhvien
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
            this.DiemGrid = new System.Windows.Forms.DataGridView();
            this.AddButt = new System.Windows.Forms.Button();
            this.UpdataButt = new System.Windows.Forms.Button();
            this.DeleButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DiemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DiemGrid
            // 
            this.DiemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DiemGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DiemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiemGrid.Location = new System.Drawing.Point(2, 1);
            this.DiemGrid.Name = "DiemGrid";
            this.DiemGrid.RowHeadersWidth = 51;
            this.DiemGrid.RowTemplate.Height = 29;
            this.DiemGrid.Size = new System.Drawing.Size(1048, 239);
            this.DiemGrid.TabIndex = 0;
            // 
            // AddButt
            // 
            this.AddButt.Location = new System.Drawing.Point(240, 272);
            this.AddButt.Name = "AddButt";
            this.AddButt.Size = new System.Drawing.Size(94, 29);
            this.AddButt.TabIndex = 1;
            this.AddButt.Text = "Thêm";
            this.AddButt.UseVisualStyleBackColor = true;
            // 
            // UpdataButt
            // 
            this.UpdataButt.Location = new System.Drawing.Point(434, 272);
            this.UpdataButt.Name = "UpdataButt";
            this.UpdataButt.Size = new System.Drawing.Size(94, 29);
            this.UpdataButt.TabIndex = 2;
            this.UpdataButt.Text = "Sửa";
            this.UpdataButt.UseVisualStyleBackColor = true;
            // 
            // DeleButt
            // 
            this.DeleButt.Location = new System.Drawing.Point(620, 272);
            this.DeleButt.Name = "DeleButt";
            this.DeleButt.Size = new System.Drawing.Size(94, 29);
            this.DeleButt.TabIndex = 3;
            this.DeleButt.Text = "Xóa";
            this.DeleButt.UseVisualStyleBackColor = true;
            // 
            // Diemsosinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 357);
            this.Controls.Add(this.DeleButt);
            this.Controls.Add(this.UpdataButt);
            this.Controls.Add(this.AddButt);
            this.Controls.Add(this.DiemGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Diemsosinhvien";
            this.Text = "Diemsosinhvien";
        
            ((System.ComponentModel.ISupportInitialize)(this.DiemGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DiemGrid;
        private Button AddButt;
        private Button UpdataButt;
        private Button DeleButt;
    }
}