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
    public partial class ShowUser : Form
    {
        public ShowUser()
        {
            InitializeComponent();
        }

        private void btn_ShowUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_user.Text != "")
                {
                    System.Diagnostics.Process.Start("cmd", "/k " + "net user " + tb_user.Text );
                }
                else
                {
                    throw new ArgumentException("Please insert user!");


                }
            }
            catch (Exception ex)
            {
                Error error = new Error(ex.ToString());
                error.Show();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ShowAllUser_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/k " + "net user");
        }
    }
}
