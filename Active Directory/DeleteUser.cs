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
    public partial class DeleteUser : Form
    {
        string username;
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                username = tb_user.Text;

                if (username != tb_confirmusername.Text)
                {
                    throw new ArgumentException("Please confirm the right username!");
                }
                else
                {
                    System.Diagnostics.Process.Start("cmd", "/c " + "net user "+ username +" /delete /domain");   
                }
            }
            catch(Exception ex)
            {
                Error error = new Error(ex.ToString());
                error.Show();
            }
        }
    }
}