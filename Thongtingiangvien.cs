using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAAn
{
    public partial class Thongtingiangvien : Form
    {
        BindingSource GiangVienListBindSource = new BindingSource();
        public Thongtingiangvien()
        {
            InitializeComponent();
            LoadGVien();
            LoadGridGiangVien();
        }
        public Thongtingiangvien(Right right, string mangd)
        {
            InitializeComponent();
            try
            {
                LoadGVien(mangd);
                LoadGridGiangVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Button AddGVien_TTGV
        {
            get => AddGVien;
        }

        public Button UpdateGvien_TTGV
        {
            get => UpdateGvien;
        }

        public Button DeleGvien_TTGV
        {
            get => DeleGvien;
        }

        public void LoadGVien()
        {
            GiangVienListBindSource.DataSource = GiangVienDAO.Instance.GetALLGiangVien();
        }
        public void LoadGVien(string mangd)
        {
            List<GiangVien> GVList = GiangVienDAO.Instance.GetGiangVien(mangd);
            GiangVienListBindSource.DataSource = GVList;
        }
        public void LoadGridGiangVien()
        {
            GVienGrid.DataSource = GiangVienListBindSource;
            textBox1.DataBindings.Add(new Binding("Text", GVienGrid.DataSource, "Id", true, DataSourceUpdateMode.Never));
            textBox2.DataBindings.Add(new Binding("Text", GVienGrid.DataSource, "Ten", true, DataSourceUpdateMode.Never));
            textBox4.DataBindings.Add(new Binding("Text", GVienGrid.DataSource, "Email", true, DataSourceUpdateMode.Never));
            //textBox3.DataBindings.Add(new Binding("Text", GVienGrid.DataSource, "Manguoidung", true, DataSourceUpdateMode.Never));
            textBox6.DataBindings.Add(new Binding("Text", GVienGrid.DataSource, "Sdt", true, DataSourceUpdateMode.Never));

            textBox3.Hide();
            label3.Hide();
        }
        private void Thongtingiangvien_Load(object sender, EventArgs e)
        {

        }

        private void AddGVien_Click(object sender, EventArgs e)
        {
            string magv = textBox1.Text;
            string ten = textBox2.Text;
            string email = textBox4.Text;
            string sdt = textBox6.Text;
            string mngd = textBox3.Text;
            if (GiangVienDAO.Instance.AddGv(magv, ten, sdt, email, mngd))
            {
                LoadGVien(); ;
            }
        }

        private void DeleGvien_Click(object sender, EventArgs e)
        {
            string magv = textBox1.Text;

            if (GiangVienDAO.Instance.XoaGv(magv))
            {
                LoadGVien(); ;
            }

        }

        private void UpdateGvien_Click(object sender, EventArgs e)
        {
            string magv = textBox1.Text;
            string ten = textBox2.Text;
            string email = textBox4.Text;
            string sdt = textBox6.Text;
            string mngd = textBox3.Text;
            if (GiangVienDAO.Instance.SuaGv(magv, ten, sdt, email, mngd))
            {
                LoadGVien(); ;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
