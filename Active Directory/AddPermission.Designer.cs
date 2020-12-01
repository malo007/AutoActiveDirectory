namespace Active_Directory
{
    partial class AddPermission
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
            this.label_Group = new System.Windows.Forms.Label();
            this.tb_Group = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label_Username = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Group
            // 
            this.label_Group.AutoSize = true;
            this.label_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Group.Location = new System.Drawing.Point(143, 90);
            this.label_Group.Name = "label_Group";
            this.label_Group.Size = new System.Drawing.Size(54, 20);
            this.label_Group.TabIndex = 19;
            this.label_Group.Text = "Group";
            // 
            // tb_Group
            // 
            this.tb_Group.Location = new System.Drawing.Point(61, 113);
            this.tb_Group.Name = "tb_Group";
            this.tb_Group.Size = new System.Drawing.Size(221, 20);
            this.tb_Group.TabIndex = 18;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(60, 195);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(222, 50);
            this.btn_Back.TabIndex = 17;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(130, 44);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(83, 20);
            this.label_Username.TabIndex = 16;
            this.label_Username.Text = "Username";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(61, 67);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(221, 20);
            this.tb_user.TabIndex = 15;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(60, 139);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(222, 50);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // AddLocalPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 285);
            this.Controls.Add(this.label_Group);
            this.Controls.Add(this.tb_Group);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.btn_Add);
            this.Name = "AddLocalPermission";
            this.Text = "AddLocalPermission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Group;
        private System.Windows.Forms.TextBox tb_Group;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Button btn_Add;
    }
}