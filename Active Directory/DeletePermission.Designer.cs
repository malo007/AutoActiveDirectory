namespace Active_Directory
{
    partial class DeletePermission
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
            this.tb_User = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Group
            // 
            this.label_Group.AutoSize = true;
            this.label_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Group.Location = new System.Drawing.Point(155, 117);
            this.label_Group.Name = "label_Group";
            this.label_Group.Size = new System.Drawing.Size(54, 20);
            this.label_Group.TabIndex = 19;
            this.label_Group.Text = "Group";
            // 
            // tb_Group
            // 
            this.tb_Group.Location = new System.Drawing.Point(77, 140);
            this.tb_Group.Name = "tb_Group";
            this.tb_Group.Size = new System.Drawing.Size(221, 20);
            this.tb_Group.TabIndex = 18;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(76, 222);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(222, 50);
            this.btn_Back.TabIndex = 17;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(140, 71);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(83, 20);
            this.label_Username.TabIndex = 16;
            this.label_Username.Text = "Username";
            // 
            // tb_User
            // 
            this.tb_User.Location = new System.Drawing.Point(77, 94);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(221, 20);
            this.tb_User.TabIndex = 15;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(76, 166);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(222, 50);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // DeletePermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 342);
            this.Controls.Add(this.label_Group);
            this.Controls.Add(this.tb_Group);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.tb_User);
            this.Controls.Add(this.btn_Delete);
            this.Name = "DeletePermission";
            this.Text = "Delete Permission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Group;
        private System.Windows.Forms.TextBox tb_Group;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.Button btn_Delete;
    }
}