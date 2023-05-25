namespace DOAAn
{
    partial class Nganh
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
            this.NganhDataView = new System.Windows.Forms.DataGridView();
            this.AddNganh = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NganhDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // NganhDataView
            // 
            this.NganhDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NganhDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.NganhDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NganhDataView.Location = new System.Drawing.Point(-4, -2);
            this.NganhDataView.Name = "NganhDataView";
            this.NganhDataView.RowHeadersWidth = 51;
            this.NganhDataView.RowTemplate.Height = 29;
            this.NganhDataView.Size = new System.Drawing.Size(1063, 266);
            this.NganhDataView.TabIndex = 0;
            // 
            // AddNganh
            // 
            this.AddNganh.Location = new System.Drawing.Point(366, 296);
            this.AddNganh.Name = "AddNganh";
            this.AddNganh.Size = new System.Drawing.Size(94, 29);
            this.AddNganh.TabIndex = 1;
            this.AddNganh.Text = "Thêm";
            this.AddNganh.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(514, 296);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(94, 29);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Sửa";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(662, 296);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(94, 29);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // Nganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 356);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddNganh);
            this.Controls.Add(this.NganhDataView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Nganh";
            this.Text = "Nganh";
            this.Load += new System.EventHandler(this.Nganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NganhDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView NganhDataView;
        private Button AddNganh;
        private Button UpdateButton;
        private Button DeleteButton;
    }
}