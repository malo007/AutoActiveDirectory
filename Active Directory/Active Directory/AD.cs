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
    public partial class AD : Form
    {
        public AD()
        {
            InitializeComponent();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.ShowDialog();
        }

        private void btn_AddLocalPermission_Click(object sender, EventArgs e)
        {
            AddLocalPermission addLocalPermission = new AddLocalPermission();
            addLocalPermission.ShowDialog();
        }

        private void btn_DeleteLocalPermission_Click(object sender, EventArgs e)
        {
            DeleteLocalPermission deleteLocalPermission = new DeleteLocalPermission();
            deleteLocalPermission.ShowDialog();
        }

        private void btn_AddGroup_Click(object sender, EventArgs e)
        {
            AddLocalGroup addLocalGroup = new AddLocalGroup();
            addLocalGroup.ShowDialog();
        }

        private void btn_ShowUser_Click(object sender, EventArgs e)
        {
            ShowUser showUser = new ShowUser();
            showUser.ShowDialog();
        }

        private void btn_ShowGroup_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/k " + "net group");
        }
    }
}
