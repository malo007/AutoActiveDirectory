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
                if (tb_user.Text != tb_confirmusername.Text)
                {
                    
                    throw new ArgumentException("Bitte Username strimt nicht überein");
                }
                else
                {
                    System.Diagnostics.Process.Start("cmd", "/c " + "net user "+ username +" /delete");
                    
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

