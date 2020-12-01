using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Active_Directory
{
    public partial class Error : Form
    {
        public Error(string Messege)
        {
            InitializeComponent();
            tb_Messege.Text = Messege;
        }

        private void tb_Messege_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
