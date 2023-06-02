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
    public partial class QuyenSinhVien : Form
    {
        public QuyenSinhVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TraoQuyenDAO.Instance.SinhVienXemTHongTIN(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TraoQuyenDAO.Instance.SinhVienXemTHongTIN(0);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TraoQuyenDAO.Instance.SinhVienXemLopHov(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TraoQuyenDAO.Instance.SinhVienXemLopHov(0);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            TraoQuyenDAO.Instance.SinhVienDangKyLop(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TraoQuyenDAO.Instance.SinhVienDangKyLop(1);

        }
    }
}
