using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace DOAAn
{
    public partial class SinhVienTrangChu : Form
    {
        public SinhVienTrangChu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           LopHoc formChinh = new LopHoc();
            formChinh.ShowDialog();
            
            this.Show();
        }

        private void SinhVienTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinSinhVien formChinh = new ThongTinSinhVien();
            formChinh.ShowDialog();

            this.Show();
        }
    }
}
