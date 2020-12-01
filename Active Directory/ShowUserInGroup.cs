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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SwitchGroup_Click(object sender, EventArgs e)
        {
            try
            {

                if (tb_Group.Text != "")
                {
                    System.Diagnostics.Process.Start("cmd", "/k " + "net group " + tb_Group.Text);
                }
                else
                {
                    throw new ArgumentException("Please insert group name!");


                }
            }
            catch (Exception ex)
            {
                Error error = new Error(ex.ToString());
                error.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
