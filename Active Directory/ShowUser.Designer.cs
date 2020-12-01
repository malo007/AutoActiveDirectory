namespace Active_Directory
{
    partial class ShowUser
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
            this.btn_ShowUser = new System.Windows.Forms.Button();
            this.btn_ShowAllUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(161, 133);
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
            this.label_Username.Location = new System.Drawing.Point(115, 28);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(83, 20);
            this.label_Username.TabIndex = 10;
            this.label_Username.Text = "Username";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(52, 51);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(221, 20);
            this.tb_user.TabIndex = 9;
            // 
            // btn_ShowUser
            // 
            this.btn_ShowUser.Location = new System.Drawing.Point(52, 77);
            this.btn_ShowUser.Name = "btn_ShowUser";
            this.btn_ShowUser.Size = new System.Drawing.Size(222, 50);
            this.btn_ShowUser.TabIndex = 8;
            this.btn_ShowUser.Text = "Show this User";
            this.btn_ShowUser.UseVisualStyleBackColor = true;
            this.btn_ShowUser.Click += new System.EventHandler(this.btn_ShowUser_Click);
            // 
            // btn_ShowAllUser
            // 
            this.btn_ShowAllUser.Location = new System.Drawing.Point(280, 77);
            this.btn_ShowAllUser.Name = "btn_ShowAllUser";
            this.btn_ShowAllUser.Size = new System.Drawing.Size(222, 50);
            this.btn_ShowAllUser.TabIndex = 12;
            this.btn_ShowAllUser.Text = "Show All User";
            this.btn_ShowAllUser.UseVisualStyleBackColor = true;
            this.btn_ShowAllUser.Click += new System.EventHandler(this.btn_ShowAllUser_Click);
            // 
            // ShowUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 205);
            this.Controls.Add(this.btn_ShowAllUser);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.btn_ShowUser);
            this.Name = "ShowUser";
            this.Text = "Show User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Button btn_ShowUser;
        private System.Windows.Forms.Button btn_ShowAllUser;
    }
}