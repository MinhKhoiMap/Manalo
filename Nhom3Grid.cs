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
    public partial class Nhom3Grid : Form
    {
        BindingSource NguoiDungListBindSource = new BindingSource();
        public Nhom3Grid()
        {
            InitializeComponent();
           LoadNguoiDung();
            LoadGridNguoiDung();
        }
        public void LoadGridNguoiDung()
        {
           Nhom3GridView.DataSource = NguoiDungListBindSource;
            textBox1.DataBindings.Add(new Binding("Text", Nhom3GridView.DataSource, "Id", true, DataSourceUpdateMode.Never));
            textBox2.DataBindings.Add(new Binding("Text", Nhom3GridView.DataSource, "Pass", true, DataSourceUpdateMode.Never));
            textBox3.DataBindings.Add(new Binding("Text", Nhom3GridView.DataSource, "Username", true, DataSourceUpdateMode.Never));
          
        }

        public void LoadNguoiDung()
        {
            NguoiDungListBindSource.DataSource = NguoiDungDAO.Instance.getNhom3();

        }
        private void Nhom3Grid_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = textBox1.Text;
            string pass = textBox2.Text;
            string username = textBox3.Text;

            if (NguoiDungDAO.Instance.AddNguoiDung3(ma, username, pass))
            {
                LoadNguoiDung();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ma = textBox1.Text;
            string pass = textBox2.Text;
            string username = textBox3.Text;

            if (NguoiDungDAO.Instance.SuaNguoiDung(ma, username, pass))
            {
                LoadNguoiDung();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ma = textBox1.Text;

            if (NguoiDungDAO.Instance.XoaNguoiDung(ma))
            {
                LoadNguoiDung();
            }
        }
    }
}
