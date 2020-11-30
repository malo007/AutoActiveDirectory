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
    public partial class DeleteLocalPermission : Form
    {
        public DeleteLocalPermission()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {

                if (tb_User.Text != "" && tb_Group.Text != "")
                {
                    System.Diagnostics.Process.Start("cmd", "/c " + "net localgroup " + tb_Group.Text + " " + tb_User.Text + " /delete");
                }
                else
                {
                    throw new ArgumentException("Bitte geben sie was in den zeilen ein!");
                }
            }
            catch (Exception ex)
            {
                Error error = new Error(ex.ToString());
                error.Show();
            }
        }
    }
}
