using DOAAn.DAO;
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
    public partial class ThongTinSinhVien : Form
    {
        BindingSource InfoListBindSource = new BindingSource();
        string masv = null;
        public ThongTinSinhVien(string masv)
        {
            this.masv = masv;
            InitializeComponent();
            try
            {
                LoadThongTin();
                LoadGridThongTIn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadGridThongTIn()
        {
            dataGridView1.DataSource = InfoListBindSource;
            textBox1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Masv", true, DataSourceUpdateMode.Never));
            textBox2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Hoten", true, DataSourceUpdateMode.Never));
            textBox3.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Email", true, DataSourceUpdateMode.Never));
            textBox6.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Sdt", true, DataSourceUpdateMode.Never));
            textBox5.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Tenchuyennganh", true, DataSourceUpdateMode.Never));
        }

        public void LoadThongTin()
        {
            InfoListBindSource.DataSource = ThongTinCaNhanDAO.Instance.getTHonTin(masv);
        }
        private void ThongTinSinhVien_Load(object sender, EventArgs e)
        {

        }
    }
}
