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
    public partial class FormMain2 : Form
    {
        private Form currentChildForm;
        public FormMain2()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

       

     

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {

        }

     
        private void FormMain_Load_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Trangchu2());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlilophoc2());

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Thongtingiangvienq2());
        }
    }
}
