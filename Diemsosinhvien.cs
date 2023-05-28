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
    public partial class Diemsosinhvien : Form
    {
        BindingSource DiemListBindSource = new BindingSource();
        public Diemsosinhvien()
        {
            InitializeComponent();
            LoadDiem();
            LoadViewDiem();
        }

        public void LoadViewDiem()
        {
            DiemGrid.DataSource = DiemListBindSource;
            textBox5.DataBindings.Add(new Binding("Text", DiemGrid.DataSource, "MSSV", true, DataSourceUpdateMode.Never));
            textBox4.DataBindings.Add(new Binding("Text", DiemGrid.DataSource, "Id", true, DataSourceUpdateMode.Never));
            textBox1.DataBindings.Add(new Binding("Text", DiemGrid.DataSource, "Tenhs", true, DataSourceUpdateMode.Never));
            textBox2.DataBindings.Add(new Binding("Text", DiemGrid.DataSource, "Monhoc", true, DataSourceUpdateMode.Never));
            textBox3.DataBindings.Add(new Binding("Text", DiemGrid.DataSource, "DiemSo", true, DataSourceUpdateMode.Never));
            textBox6.DataBindings.Add(new Binding("Text", DiemGrid.DataSource, "MaMonHoc", true, DataSourceUpdateMode.Never));
        }
        public void LoadDiem()
        {
            DiemListBindSource.DataSource=DiemDAO.Instance.GetALLDiem();
            
        }

        private void Diemsosinhvien_Load(object sender, EventArgs e)
        {

        }

        private void UpdataButt_Click(object sender, EventArgs e)
        {
            string ma = textBox4.Text;
            string diem = textBox3.Text;
            string mon = textBox6.Text;
            if (DiemDAO.Instance.SuaDiem(ma,diem,mon))
            {
                LoadDiem();
            }

        }

        private void DeleButt_Click(object sender, EventArgs e)
        {

            string ma = textBox4.Text;
           

            if (DiemDAO.Instance.XoaDiem(ma))
            {
                LoadDiem();
            }

        }

        private void AddButt_Click(object sender, EventArgs e)
        {
            string mact = textBox4.Text;
            string mssv = textBox5.Text;
            string mon = textBox6.Text;
            double diem = Double.Parse(textBox3.Text);
            if (DiemDAO.Instance.ThemDiem(mact,mssv,diem,mon))
            {
                LoadDiem();
            }


        }
    }
    }

