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
        public Chuyennganh()
        {
            InitializeComponent();
            LoadNganh();

        }

        private void Chuyennganh_Load(object sender, EventArgs e)
        {

        }
        public void LoadNganh()
        {
            DataTable a = DataProvider.Instance.ExecuteQuery("exec XemChuyenNganh");
            ChuyenNganhGrid.DataSource = a;
        }
    }
}
