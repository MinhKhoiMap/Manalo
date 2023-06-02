using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace DOAAn
{
    public partial class FormSinhVien : Form
    {
        Right license = null;
        string masv = null;
        public FormSinhVien()
        {
            InitializeComponent();
        }
        private void mappingMaSV()
        {
            SqlConnection sc = new SqlConnection(license.Connect);
            sc.Open();
            SqlCommand scmd = new SqlCommand($"exec getMaSV @mangd = {license.AccountID}", sc);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = scmd;
            DataSet ds = new DataSet();
            sda.Fill(ds, "masv");
            sc.Close();
            this.masv = ds.Tables["masv"].Rows[0]["MaSinhVien"].ToString();
        }
        public FormSinhVien(Right right)
        {
            license = right;
            mappingMaSV();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LopHoc formChinh = new LopHoc(masv);
            formChinh.ShowDialog();
            this.Show();
        }

        private void SinhVienTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinSinhVien formChinh = new ThongTinSinhVien(masv);
            formChinh.ShowDialog();
            this.Show();
        }
    }
}
