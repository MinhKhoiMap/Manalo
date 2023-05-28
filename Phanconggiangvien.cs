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
    public partial class Phanconggiangvien : Form
    {
        BindingSource PhanCongListBindSource = new BindingSource();
        public Phanconggiangvien()
        {
            InitializeComponent();
            LoadPhanCong();
            LoadGridPhanCong();
        }
        public void LoadGridPhanCong()
        {
            TeachingGrid.DataSource = PhanCongListBindSource;
            textBox1.DataBindings.Add(new Binding("Text", TeachingGrid.DataSource, "Id", true, DataSourceUpdateMode.Never));
            textBox2.DataBindings.Add(new Binding("Text", TeachingGrid.DataSource, "Ten", true, DataSourceUpdateMode.Never));
            textBox4.DataBindings.Add(new Binding("Text", TeachingGrid.DataSource, "Email", true, DataSourceUpdateMode.Never));
            textBox3.DataBindings.Add(new Binding("Text", TeachingGrid.DataSource, "MaMonHoc", true, DataSourceUpdateMode.Never));

            textBox6.DataBindings.Add(new Binding("Text", TeachingGrid.DataSource, "Sdt", true, DataSourceUpdateMode.Never));
            textBox7.DataBindings.Add(new Binding("Text", TeachingGrid.DataSource, "Monhoc", true, DataSourceUpdateMode.Never));
            textBox9.DataBindings.Add(new Binding("Text", TeachingGrid.DataSource, "Malop", true, DataSourceUpdateMode.Never));

        }

        public void LoadPhanCong()
        {
           PhanCongListBindSource.DataSource = PhanCongDAO.Instance.GetALLPhanCong();
        }

        private void Phanconggiangvien_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string magv = textBox1.Text;
            string malop = textBox9.Text;
            string mon = textBox3.Text;
            if (PhanCongDAO.Instance.SuaPhanCong(magv,mon,malop))
            {
                LoadPhanCong();
            }

        }

        private void DeleteTeaching_Click(object sender, EventArgs e)
        {
           
            string malop = textBox9.Text;
         
            if (PhanCongDAO.Instance.XoaPhanCong( malop))
            {
                LoadPhanCong();
            }

        }

        private void AddTeachButt_Click(object sender, EventArgs e)
        {
            string magv = textBox1.Text;
            string malop = textBox9.Text;
            string mon = textBox3.Text;
            if (PhanCongDAO.Instance.AddPhanCong(magv, mon, malop))
            {
                LoadPhanCong();
            }
        }
    }
}
