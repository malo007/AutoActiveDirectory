namespace Active_Directory
{
    partial class AD
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.btn_AddLocalPermission = new System.Windows.Forms.Button();
            this.btn_DeleteLocalPermission = new System.Windows.Forms.Button();
            this.btn_DeleteLocalGroup = new System.Windows.Forms.Button();
            this.btn_AddLocalGroup = new System.Windows.Forms.Button();
            this.btn_ShowGroup = new System.Windows.Forms.Button();
            this.btn_ShowUser = new System.Windows.Forms.Button();
            this.btn_SwitchGroupForUser = new System.Windows.Forms.Button();
            this.btn_ShowUserInGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(12, 63);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(261, 55);
            this.btn_AddUser.TabIndex = 0;
            this.btn_AddUser.Text = "Add User";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.Location = new System.Drawing.Point(279, 63);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(261, 55);
            this.btn_DeleteUser.TabIndex = 1;
            this.btn_DeleteUser.Text = "Delete User";
            this.btn_DeleteUser.UseVisualStyleBackColor = true;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // btn_AddLocalPermission
            // 
            this.btn_AddLocalPermission.Location = new System.Drawing.Point(12, 124);
            this.btn_AddLocalPermission.Name = "btn_AddLocalPermission";
            this.btn_AddLocalPermission.Size = new System.Drawing.Size(261, 55);
            this.btn_AddLocalPermission.TabIndex = 3;
            this.btn_AddLocalPermission.Text = "Add User to Group";
            this.btn_AddLocalPermission.UseVisualStyleBackColor = true;
            this.btn_AddLocalPermission.Click += new System.EventHandler(this.btn_AddLocalPermission_Click);
            // 
            // btn_DeleteLocalPermission
            // 
            this.btn_DeleteLocalPermission.Location = new System.Drawing.Point(279, 124);
            this.btn_DeleteLocalPermission.Name = "btn_DeleteLocalPermission";
            this.btn_DeleteLocalPermission.Size = new System.Drawing.Size(261, 55);
            this.btn_DeleteLocalPermission.TabIndex = 4;
            this.btn_DeleteLocalPermission.Text = "Delete User from Group";
            this.btn_DeleteLocalPermission.UseVisualStyleBackColor = true;
            this.btn_DeleteLocalPermission.Click += new System.EventHandler(this.btn_DeleteLocalPermission_Click);
            // 
            // btn_DeleteLocalGroup
            // 
            this.btn_DeleteLocalGroup.Location = new System.Drawing.Point(279, 185);
            this.btn_DeleteLocalGroup.Name = "btn_DeleteLocalGroup";
            this.btn_DeleteLocalGroup.Size = new System.Drawing.Size(261, 55);
            this.btn_DeleteLocalGroup.TabIndex = 6;
            this.btn_DeleteLocalGroup.Text = "Delete Group ";
            this.btn_DeleteLocalGroup.UseVisualStyleBackColor = true;
            // 
            // btn_AddLocalGroup
            // 
            this.btn_AddLocalGroup.Location = new System.Drawing.Point(12, 185);
            this.btn_AddLocalGroup.Name = "btn_AddLocalGroup";
            this.btn_AddLocalGroup.Size = new System.Drawing.Size(261, 55);
            this.btn_AddLocalGroup.TabIndex = 5;
            this.btn_AddLocalGroup.Text = "Add Group";
            this.btn_AddLocalGroup.UseVisualStyleBackColor = true;
            this.btn_AddLocalGroup.Click += new System.EventHandler(this.btn_AddGroup_Click);
            // 
            // btn_ShowGroup
            // 
            this.btn_ShowGroup.Location = new System.Drawing.Point(279, 246);
            this.btn_ShowGroup.Name = "btn_ShowGroup";
            this.btn_ShowGroup.Size = new System.Drawing.Size(261, 55);
            this.btn_ShowGroup.TabIndex = 8;
            this.btn_ShowGroup.Text = "Show Group ";
            this.btn_ShowGroup.UseVisualStyleBackColor = true;
            this.btn_ShowGroup.Click += new System.EventHandler(this.btn_ShowGroup_Click);
            // 
            // btn_ShowUser
            // 
            this.btn_ShowUser.Location = new System.Drawing.Point(12, 246);
            this.btn_ShowUser.Name = "btn_ShowUser";
            this.btn_ShowUser.Size = new System.Drawing.Size(261, 55);
            this.btn_ShowUser.TabIndex = 7;
            this.btn_ShowUser.Text = "Show User";
            this.btn_ShowUser.UseVisualStyleBackColor = true;
            this.btn_ShowUser.Click += new System.EventHandler(this.btn_ShowUser_Click);
            // 
            // btn_SwitchGroupForUser
            // 
            this.btn_SwitchGroupForUser.Location = new System.Drawing.Point(279, 307);
            this.btn_SwitchGroupForUser.Name = "btn_SwitchGroupForUser";
            this.btn_SwitchGroupForUser.Size = new System.Drawing.Size(261, 55);
            this.btn_SwitchGroupForUser.TabIndex = 10;
            this.btn_SwitchGroupForUser.Text = "Switch Group for User";
            this.btn_SwitchGroupForUser.UseVisualStyleBackColor = true;
            this.btn_SwitchGroupForUser.Click += new System.EventHandler(this.btn_SwitchGroupForUser_Click);
            // 
            // btn_ShowUserInGroup
            // 
            this.btn_ShowUserInGroup.Location = new System.Drawing.Point(12, 307);
            this.btn_ShowUserInGroup.Name = "btn_ShowUserInGroup";
            this.btn_ShowUserInGroup.Size = new System.Drawing.Size(261, 55);
            this.btn_ShowUserInGroup.TabIndex = 9;
            this.btn_ShowUserInGroup.Text = "Show User in Group";
            this.btn_ShowUserInGroup.UseVisualStyleBackColor = true;
            this.btn_ShowUserInGroup.Click += new System.EventHandler(this.btn_ShowUserInGroup_Click);
            // 
            // AD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 389);
            this.Controls.Add(this.btn_SwitchGroupForUser);
            this.Controls.Add(this.btn_ShowUserInGroup);
            this.Controls.Add(this.btn_ShowGroup);
            this.Controls.Add(this.btn_ShowUser);
            this.Controls.Add(this.btn_DeleteLocalGroup);
            this.Controls.Add(this.btn_AddLocalGroup);
            this.Controls.Add(this.btn_DeleteLocalPermission);
            this.Controls.Add(this.btn_AddLocalPermission);
            this.Controls.Add(this.btn_DeleteUser);
            this.Controls.Add(this.btn_AddUser);
            this.Name = "AD";
            this.Text = "AD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Button btn_AddLocalPermission;
        private System.Windows.Forms.Button btn_DeleteLocalPermission;
        private System.Windows.Forms.Button btn_DeleteLocalGroup;
        private System.Windows.Forms.Button btn_AddLocalGroup;
        private System.Windows.Forms.Button btn_ShowGroup;
        private System.Windows.Forms.Button btn_ShowUser;
        private System.Windows.Forms.Button btn_SwitchGroupForUser;
        private System.Windows.Forms.Button btn_ShowUserInGroup;
    }
}

