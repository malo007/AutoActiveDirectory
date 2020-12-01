namespace Active_Directory
{
    partial class DeleteUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Back = new System.Windows.Forms.Button();
            this.label_Username = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label_ConfirmUsername = new System.Windows.Forms.Label();
            this.tb_confirmusername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(75, 188);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(222, 50);
            this.btn_Back.TabIndex = 11;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(139, 37);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(83, 20);
            this.label_Username.TabIndex = 10;
            this.label_Username.Text = "Username";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(76, 60);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(221, 20);
            this.tb_user.TabIndex = 9;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(75, 132);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(222, 50);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label_ConfirmUsername
            // 
            this.label_ConfirmUsername.AutoSize = true;
            this.label_ConfirmUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ConfirmUsername.Location = new System.Drawing.Point(112, 83);
            this.label_ConfirmUsername.Name = "label_ConfirmUsername";
            this.label_ConfirmUsername.Size = new System.Drawing.Size(142, 20);
            this.label_ConfirmUsername.TabIndex = 13;
            this.label_ConfirmUsername.Text = "Confirm Username";
            // 
            // tb_confirmusername
            // 
            this.tb_confirmusername.Location = new System.Drawing.Point(76, 106);
            this.tb_confirmusername.Name = "tb_confirmusername";
            this.tb_confirmusername.Size = new System.Drawing.Size(221, 20);
            this.tb_confirmusername.TabIndex = 12;
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 256);
            this.Controls.Add(this.label_ConfirmUsername);
            this.Controls.Add(this.tb_confirmusername);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.btn_Delete);
            this.Name = "DeleteUser";
            this.Text = "Delete User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label_ConfirmUsername;
        private System.Windows.Forms.TextBox tb_confirmusername;
    }
}