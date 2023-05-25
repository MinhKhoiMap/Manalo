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
        public Danhsachsinhvien()
        {
            InitializeComponent();
            LoadSinhVien();
        }

        public void LoadSinhVien()
        {
            DataTable a = DataProvider.Instance.ExecuteQuery("exec XemSinhVien");
           SinhVienGrid.DataSource = a;
        }
        private void Danhsachsinhvien_Load(object sender, EventArgs e)
        {

        }
    }
}
