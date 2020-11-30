﻿using System;
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
    public partial class AddLocalPermission : Form
    {
        public AddLocalPermission()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            try
            {

                if (tb_user.Text != "" && tb_Group.Text != "")
                {
                    System.Diagnostics.Process.Start("cmd", "/c " + "net localgroup " + tb_Group.Text +" "+ tb_user.Text + " /add");
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