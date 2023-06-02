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
    public partial class QuyenGiangVien : Form
    {
        public QuyenGiangVien()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TraoQuyenDAO.Instance.XemDanhSachSV(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TraoQuyenDAO.Instance.XemDanhSachSV(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TraoQuyenDAO.Instance.XemTTGV(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TraoQuyenDAO.Instance.XemTTGV(false);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TraoQuyenDAO.Instance.XemDiemSV(true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TraoQuyenDAO.Instance.XemDiemSV(false);
        }
    }
}
