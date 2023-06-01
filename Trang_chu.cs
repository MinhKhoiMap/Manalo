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
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public static Form2 Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Form2();
                }
                return instance;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }
    }
}
