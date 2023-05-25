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
        public Diemsosinhvien()
        {
            InitializeComponent();
            LoadDiem();
        }

        public void LoadDiem()
        {
            DataTable a = DataProvider.Instance.ExecuteQuery("exec  XemDiemSinhVienALL");
            DiemGrid.DataSource = a;
        }
    }
    }

