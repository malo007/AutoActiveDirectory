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
    public partial class AddUser : Form
    {
        string username;
        string password = "Test123!";

        public AddUser()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                username = tb_user.Text;

                if (username != "")
                {
                    System.Diagnostics.Process.Start("cmd", "/c " + "net user " + username + " " + password + " /add /domain");
                }
                else
                {
                  throw new ArgumentException("Please insert username!");
                }
            }
            catch(Exception ex)
            {
                Error error = new Error(ex.ToString());
                error.Show();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
