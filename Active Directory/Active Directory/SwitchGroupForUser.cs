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
    public partial class SwitchGroupForUser : Form
    {
        public SwitchGroupForUser()
        {
            InitializeComponent();
        }

        private void btn_SwitchGroup_Click(object sender, EventArgs e)
        {
            if(tb_OldGroup.Text != "" && tb_NewGroup.Text != "")
            {
                System.Diagnostics.Process.Start("cmd", "/c " + "net group " + tb_user.Text + " "+ tb_OldGroup + " /delete /domain");
                System.Diagnostics.Process.Start("cmd", "/c " + "net group " + tb_user.Text + " " + tb_NewGroup + " /add /domain");
            }
        }
    }
}
