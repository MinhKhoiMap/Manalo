using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAAn
{
    public partial class LopHoc : Form
    {
        public class RandomNumberGenerator
        {
            public static string GenerateRandomNumberAsString()
            {
                // Khởi tạo một đối tượng Random để tạo số ngẫu nhiên
                Random random = new Random();

                // Tạo số nguyên dương ngẫu nhiên có tối đa 5 chữ số
                int randomNumber = random.Next(1, 100000);

                // Chuyển đổi số nguyên thành chuỗi string
                string randomString = randomNumber.ToString();

                // Trả về chuỗi string đã chuyển đổi
                return randomString;
            }
        }
        BindingSource LopListBindSource = new BindingSource();
        public LopHoc()
        {
            InitializeComponent();
            LoadLopHoc();
            LoadGridLopHoc();
            LoadLopHocDaDangKy();
        }
        public void LoadGridLopHoc()
        {
            dataGridView1.DataSource = LopListBindSource;
            textBox1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Malop", true, DataSourceUpdateMode.Never));
            textBox2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Mamon", true, DataSourceUpdateMode.Never));
            textBox3.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Tenmonhoc", true, DataSourceUpdateMode.Never));

        }

        public void LoadLopHoc()
        {
              LopListBindSource.DataSource = LopDAO.Instance.GetLop();

        }
        public void LoadLopHocDaDangKy()
        {
            dataGridView2.DataSource = DataProvider.Instance.ExecuteQuery("XemLopDaDangKy  @msv ",new object[] { "2" });
        }
        private void LopHoc_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string malop = textBox1.Text;
            

            if (LopDAO.Instance.AddLop("2",malop,RandomNumberGenerator.GenerateRandomNumberAsString()))
            {
              LoadLopHoc();
                LoadLopHocDaDangKy();
            }
        }
    }
}
