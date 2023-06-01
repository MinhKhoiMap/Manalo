using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DOAAn
{
    public partial class FormGiangVien : Form
    {
        private Form currentChildForm = null;
        private Right right;
        public string accountId
        {
            get => right.AccountID;
        }
        private void renderChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public FormGiangVien(Right right)
        {
            this.right = right;
            InitializeComponent();
        }
        private void thongtingv_btn_Click(object sender, EventArgs e)
        {
            Thongtingiangvien ttgv_form = new Thongtingiangvien(right, right.AccountID);
            ttgv_form.AddGVien_TTGV.Hide();
            ttgv_form.DeleGvien_TTGV.Hide();
            ttgv_form.UpdateGvien_TTGV.Hide();
            renderChildForm(ttgv_form);
        }

        private void trangchu_btn_Click(object sender, EventArgs e)
        {
            renderChildForm(new Form2());
        }

        private void qlysv_btn_Click(object sender, EventArgs e)
        {
            Quanlisinhvien qlsv = new Quanlisinhvien(right);
            renderChildForm(qlsv);
        }
    }
}
