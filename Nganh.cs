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
    public partial class Nganh : Form
    {
        public Nganh()
        {
            InitializeComponent();
            LoadNganh();
        }
        public void LoadNganh()
        {
            DataTable a = DataProvider.Instance.ExecuteQuery("exec  XemNganh");
            NganhDataView.DataSource = a;
        }
        private void Nganh_Load(object sender, EventArgs e)
        {

        }
    }
}
