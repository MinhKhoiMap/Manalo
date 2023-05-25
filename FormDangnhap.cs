using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Configuration;
namespace DOAAn
{
    public partial class FormDangnhap : Form
    {
        /*method*/

        public FormDangnhap()
        {
            InitializeComponent();
            label_Loi.Hide();
        }
        private Form cformChild;
        private void OpenChildForm(Form childForm)
        {
            if (cformChild != null)
            {
                cformChild.Close();
            }
            cformChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_khung.Controls.Add(childForm);
            panel_khung.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        /*method*/

        public Right CheckLog(string name,string pass) {
            Right right = RightDAO.Instance.GetQuyen(name,pass );
            return right;   
            /*Trả về quyền tương ứng, nếu tài khoản không đúng thì trả về quyền với các thuộc tính -1*/
        }


        /*event*/

        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = NameInput.Text;
            string matkhau = PassInput.Text;

            if (tentk.Trim() == "") { panel_khung.Location = new Point(0, 35); label_Loi.Show(); }
            else if (matkhau.Trim() == "") { panel_khung.Location = new Point(0, 35); label_Loi.Show(); }
            /**/
            if (CheckLog(tentk, matkhau).RightNum!=-1)
            {
                Right TempRight =CheckLog(tentk, matkhau);
              
                string modifiedConnectionString = TempRight.Connect.Replace("Data Source= ", $"Data Source={ConfigurationManager.AppSettings["ServerAddress"]}");
                /*modifiedConnectionString thay địa chỉ của chuỗi connect thành địa chỉ trong tệp config*/
                 TempRight.Connect=modifiedConnectionString;
                /*cập nhật cho chuỗi connect tương đương quyền cho người dùng sau khi đăng nhập*/
                label_Loi.Hide();
                this.Hide();
                string old = DataProvider.Instance.old();
                DataProvider.Instance.ChangeString(TempRight.Connect); 
                
             FormMain2 formChinh = new FormMain2();
                formChinh.ShowDialog();
                DataProvider.Instance.ChangeString(old);
                this.Show();
            }
            else { label_Loi.Show(); }

        }

        private void label_Loi_Click(object sender, EventArgs e)
        {
            label_Loi.Hide();
            panel_khung.Location = new Point(0, 7);
        }

        private void FormDangnhap_Load(object sender, EventArgs e)
        {

        }

    
        /*event*/

    }
}
