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
    public partial class ShowUserInGroup : Form
    {
        public ShowUserInGroup()
        {
            InitializeComponent();
        }



        private void btn_Add_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/k " + "net group " + tb_Group.Text);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
