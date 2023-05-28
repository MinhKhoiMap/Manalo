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
    public partial class Nganh : Form
    {
        BindingSource NganhListBindSource = new BindingSource();
        public Nganh()
        {
            InitializeComponent();
            LoadNganh();
            LoadViewNganh();
        }
        public void LoadViewNganh() {

           NganhDataView.DataSource =NganhListBindSource;
            textBox1.DataBindings.Add(new Binding("Text", NganhDataView.DataSource, "Id", true, DataSourceUpdateMode.Never));
            textBox2.DataBindings.Add(new Binding("Text", NganhDataView.DataSource, "Tennganh", true, DataSourceUpdateMode.Never));

        }
        public void LoadNganh()
        {
            NganhListBindSource.DataSource = NganhHocDAO.Instance.GetALLNganh() ;
           
        }
        private void Nganh_Load(object sender, EventArgs e)
        {

        }

        private void AddNganh_Click(object sender, EventArgs e)
        {
            string man = textBox1.Text;
            string tenchuyennganh = textBox2.Text;

      
            if (NganhHocDAO.Instance.AddNganh(man, tenchuyennganh))
            {
                LoadNganh();
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string man = textBox1.Text;
            string tenchuyennganh = textBox2.Text;


            if (NganhHocDAO.Instance.SuaNganh(man,tenchuyennganh))
            {
                LoadNganh();
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string man = textBox1.Text;
            string tenchuyennganh = textBox2.Text;


            if (NganhHocDAO.Instance.XoaNganh(man))
            {
                LoadNganh();
            }

        }
    }
}
