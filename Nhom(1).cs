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
    public partial class Nhom_1_ : Form
    {
        BindingSource NguoiDungListBindSource = new BindingSource();
        public Nhom_1_()
        {
            InitializeComponent();
            LoadNguoiDung();
            LoadGridNguoiDung();
        }
        public void LoadGridNguoiDung()
        {
            Nhom1Grid.DataSource = NguoiDungListBindSource;
            textBox1.DataBindings.Add(new Binding("Text", Nhom1Grid.DataSource, "Id", true, DataSourceUpdateMode.Never));
            textBox2.DataBindings.Add(new Binding("Text", Nhom1Grid.DataSource, "Pass", true, DataSourceUpdateMode.Never));
            textBox3.DataBindings.Add(new Binding("Text", Nhom1Grid.DataSource, "Username", true, DataSourceUpdateMode.Never));
         
        }

        public void LoadNguoiDung()
        {
            NguoiDungListBindSource.DataSource = NguoiDungDAO.Instance.getNhom1();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nhom_1__Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = textBox1.Text;
            string pass = textBox2.Text;
            string username = textBox3.Text;

            if (NguoiDungDAO.Instance.AddNguoiDung1(ma,username,pass))
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
    }
}
