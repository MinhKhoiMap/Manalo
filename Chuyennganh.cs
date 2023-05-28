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
    public partial class Chuyennganh : Form
    {
        BindingSource ChuyenNganhListBindSource = new BindingSource();
        public Chuyennganh()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            LoadChuyenNganh();
            LoadViewChuyenNganh();
        }
        public void LoadViewChuyenNganh()
        {

           ChuyenNganhGrid.DataSource = ChuyenNganhListBindSource;
            textBox1.DataBindings.Add(new Binding("Text", ChuyenNganhGrid.DataSource, "Id", true, DataSourceUpdateMode.Never));
            textBox2.DataBindings.Add(new Binding("Text", ChuyenNganhGrid.DataSource, "Tenchuyennganh", true, DataSourceUpdateMode.Never));
            textBox3.DataBindings.Add(new Binding("Text", ChuyenNganhGrid.DataSource, "Tennganh", true, DataSourceUpdateMode.Never));
            textBox4.DataBindings.Add(new Binding("Text", ChuyenNganhGrid.DataSource, "MaNganh", true, DataSourceUpdateMode.Never));
        }
        private void Chuyennganh_Load(object sender, EventArgs e)
        {

        }
        public void LoadChuyenNganh()
        {
            ChuyenNganhListBindSource.DataSource = ChuyenNganhDAO.Instance.GetALLNganh();

        }

        private void AddChuyenNganh_Click(object sender, EventArgs e)
        {
            string macn=textBox1.Text;
            string tenchuyennganh = textBox2.Text ;
            
            string manganh = textBox4.Text;
            if (ChuyenNganhDAO.Instance.AddChuyenNganh(macn, tenchuyennganh, manganh))
            {
                LoadChuyenNganh();
            }
           
            
        }

        private void UpdateChuyenNganh_Click(object sender, EventArgs e)
        {
            string macn = textBox1.Text;
            string tenchuyennganh = textBox2.Text;

            string manganh = textBox4.Text;
            if (ChuyenNganhDAO.Instance.SuaChuyenNganh(macn, tenchuyennganh, manganh))
            {
                LoadChuyenNganh();
            }
        }

        private void DeleteChuyenNganhButt_Click(object sender, EventArgs e)
        {
            string macn = textBox1.Text;
         
            if (ChuyenNganhDAO.Instance.XoaChuyenNganh(macn))
            {
                LoadChuyenNganh();
            }
        }
    }
}
