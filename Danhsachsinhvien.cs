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

namespace DOAAn
{
    public partial class Danhsachsinhvien : Form
    {
        BindingSource StudentListBindSource = new BindingSource();
        Right license = null;
        public Danhsachsinhvien()
        {
            InitializeComponent();
            LoadSinhVien();
            LoadGridSinhVien();
        }
        public Danhsachsinhvien(Right right)
        {
            InitializeComponent();
            license = right;
            LoadSinhVien(right.AccountID);
        }
        public void LoadGridSinhVien()
        {
            SinhVienGrid.DataSource = StudentListBindSource;
            textBox1.DataBindings.Add(new Binding("Text", SinhVienGrid.DataSource, "Id", true, DataSourceUpdateMode.Never));
            textBox2.DataBindings.Add(new Binding("Text", SinhVienGrid.DataSource, "Ten", true, DataSourceUpdateMode.Never));
            textBox4.DataBindings.Add(new Binding("Text", SinhVienGrid.DataSource, "Email", true, DataSourceUpdateMode.Never));
            textBox5.DataBindings.Add(new Binding("Text", SinhVienGrid.DataSource, "Machuyenganh", true, DataSourceUpdateMode.Never));
            textBox6.DataBindings.Add(new Binding("Text", SinhVienGrid.DataSource, "Sdt", true, DataSourceUpdateMode.Never));
            textBox9.DataBindings.Add(new Binding("Text", SinhVienGrid.DataSource, "MaNguoiDung", true, DataSourceUpdateMode.Never));
        }
        public void LoadSinhVien()
        {

            StudentListBindSource.DataSource = SinhVienDAO.Instance.GetALLSinhVIen();
        }
        public void LoadSinhVien(string magv)
        {
            //MessageBox.Show(FormGiangVien.Magv);
            SqlConnection sc = new SqlConnection(license.Connect);
            sc.Open();
            SqlCommand scmd = new SqlCommand($"exec getLopSVList @magv = {magv}", sc);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = scmd;
            DataSet ds = new DataSet();
            sda.Fill(ds, "sinhvien");
            sc.Close();
            SinhVienGrid.DataSource = ds;
            SinhVienGrid.DataMember = "sinhvien";
            textBox1.Hide();
            textBox2.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox9.Hide();
            label1.Hide();
            label2.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label9.Hide();
            AddSinhVien.Hide();
            UpdateSinhvien.Hide();
            DeleteSinhVien.Hide();
        }
        private void Danhsachsinhvien_Load(object sender, EventArgs e)
        {

        }

        private void SinhVienGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void AddSinhVien_Click(object sender, EventArgs e)
        {
            string massv = textBox1.Text;
            string hoten = textBox2.Text;

            string email = textBox4.Text;
            string sdt = textBox6.Text;
            string Chuyennganh = textBox5.Text;
            string manguoidung = textBox9.Text;

            if (SinhVienDAO.Instance.AddSinhVien(massv, hoten, sdt, email, manguoidung, Chuyennganh))
            {
                LoadSinhVien();
            }

        }

        private void UpdateSinhvien_Click(object sender, EventArgs e)
        {

            string massv = textBox1.Text;
            string hoten = textBox2.Text;

            string email = textBox4.Text;
            string sdt = textBox6.Text;
            string Chuyennganh = textBox5.Text;
            string manguoidung = textBox9.Text;

            if (SinhVienDAO.Instance.SuaSv(massv, hoten, sdt, email, Chuyennganh, manguoidung))
            {
                LoadSinhVien();
            }

        }

        private void DeleteSinhVien_Click(object sender, EventArgs e)
        {
            string massv = textBox1.Text;


            if (SinhVienDAO.Instance.XoaSv(massv))
            {
                LoadSinhVien();
            }

        }
    }
}
