using Microsoft.Data.SqlClient;
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
using System.Configuration;
using System.Reflection;

namespace DOAAn
{
    public partial class FormNen : Form
    {
        private Right license;
        public static string group;
        public Right License { get => license; set => license = value; }

        public FormNen(Right license)
        {
            InitializeComponent();
            this.license = license;
            MessageBox.Show(license.RightNum.ToString());
            getGroup(license.RightNum.ToString());

        }
        private Form cformChild;
        private void getGroup(string manhom)
        {
            string path = license.Connect;

            MessageBox.Show(manhom);
            SqlConnection sc = new SqlConnection(path);
            sc.Open();
            SqlCommand scmd = new SqlCommand($"exec getGroupName @manhom = {manhom}", sc);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = scmd;
            DataSet ds = new DataSet();
            sda.Fill(ds, "group name");
            sc.Close();
            MessageBox.Show(ds.Tables["group name"].Rows[0]["TenNhom"].ToString());
            group = ds.Tables["group name"].Rows[0]["TenNhom"].ToString();
            string tenform = $"Form{group}";

            Type t = Type.GetType($"DOAAn.{tenform}");
            MethodInfo mi = t.GetMethod(tenform, new Type[] { typeof(Right) });
            object o = Activator.CreateInstance(t, license);
        }

        private void FormNen_Load(object sender, EventArgs e)
        {

        }
    }
}
