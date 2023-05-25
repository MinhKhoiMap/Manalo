namespace DOAAn
{
    partial class Phanconggiangvien
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
            this.TeachingGrid = new System.Windows.Forms.DataGridView();
            this.AddTeachButt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DeleteTeaching = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TeachingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TeachingGrid
            // 
            this.TeachingGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeachingGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TeachingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachingGrid.Location = new System.Drawing.Point(-1, -2);
            this.TeachingGrid.Name = "TeachingGrid";
            this.TeachingGrid.RowHeadersWidth = 51;
            this.TeachingGrid.RowTemplate.Height = 29;
            this.TeachingGrid.Size = new System.Drawing.Size(1190, 281);
            this.TeachingGrid.TabIndex = 0;
            // 
            // AddTeachButt
            // 
            this.AddTeachButt.Location = new System.Drawing.Point(303, 309);
            this.AddTeachButt.Name = "AddTeachButt";
            this.AddTeachButt.Size = new System.Drawing.Size(94, 29);
            this.AddTeachButt.TabIndex = 1;
            this.AddTeachButt.Text = "Thêm";
            this.AddTeachButt.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(501, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DeleteTeaching
            // 
            this.DeleteTeaching.Location = new System.Drawing.Point(696, 309);
            this.DeleteTeaching.Name = "DeleteTeaching";
            this.DeleteTeaching.Size = new System.Drawing.Size(94, 29);
            this.DeleteTeaching.TabIndex = 3;
            this.DeleteTeaching.Text = "Xóa";
            this.DeleteTeaching.UseVisualStyleBackColor = true;
            // 
            // Phanconggiangvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 383);
            this.Controls.Add(this.DeleteTeaching);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddTeachButt);
            this.Controls.Add(this.TeachingGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Phanconggiangvien";
            this.Text = "Phanconggiangvien";
            this.Load += new System.EventHandler(this.Phanconggiangvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeachingGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView TeachingGrid;
        private Button AddTeachButt;
        private Button button2;
        private Button DeleteTeaching;
    }
}