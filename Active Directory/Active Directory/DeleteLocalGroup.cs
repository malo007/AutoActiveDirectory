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
    public partial class DeleteLocalGroup : Form
    {
        public DeleteLocalGroup()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {

                if (tb_Group.Text != "")
                {
                    System.Diagnostics.Process.Start("cmd", "/c " + "net localgroup " + tb_Group.Text + " /delete");
                }
                else
                {
                    throw new ArgumentException("Bitte Gruppe eingeben");


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
    }
}
