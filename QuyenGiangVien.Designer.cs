namespace DOAAn
{
    partial class QuyenGiangVien
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
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            button7 = new Button();
            button8 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(524, 160);
            button3.Name = "button3";
            button3.Size = new Size(145, 29);
            button3.TabIndex = 14;
            button3.Text = "Không cho phép";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(332, 160);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 13;
            button4.Text = "Cho phép";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(58, 160);
            label2.Name = "label2";
            label2.Size = new Size(204, 25);
            label2.TabIndex = 12;
            label2.Text = "Xem sinh viên lớp dạy:";
            // 
            // button2
            // 
            button2.Location = new Point(524, 85);
            button2.Name = "button2";
            button2.Size = new Size(145, 29);
            button2.TabIndex = 11;
            button2.Text = "Không cho phép";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(332, 85);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Cho phép";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 85);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 9;
            label1.Text = "Xem thông tin cá nhân:";
            // 
            // button7
            // 
            button7.Location = new Point(524, 234);
            button7.Name = "button7";
            button7.Size = new Size(145, 29);
            button7.TabIndex = 20;
            button7.Text = "Không cho phép";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(332, 234);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 19;
            button8.Text = "Cho phép";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(58, 234);
            label4.Name = "label4";
            label4.Size = new Size(183, 25);
            label4.TabIndex = 18;
            label4.Text = "Xem điểm sinh viên:";
            // 
            // QuyenGiangVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "QuyenGiangVien";
            Text = "NhomQuyenGiangVien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button4;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button7;
        private Button button8;
        private Label label4;
    }
}