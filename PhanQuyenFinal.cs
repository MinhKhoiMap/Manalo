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
    public partial class PhanQuyenFinal : Form
    {
        public PhanQuyenFinal()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            QuyenSinhVien form = new QuyenSinhVien();
            form.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            QuyenGiangVien quyenGiangVien = new QuyenGiangVien();
            quyenGiangVien.ShowDialog();
        }
    }
}
