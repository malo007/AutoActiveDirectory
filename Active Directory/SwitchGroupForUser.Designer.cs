namespace Active_Directory
{
    partial class SwitchGroupForUser
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
            this.btn_SwitchGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_OldGroup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_NewGroup = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(240, 145);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(222, 50);
            this.btn_Back.TabIndex = 16;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(76, 9);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(83, 20);
            this.label_Username.TabIndex = 15;
            this.label_Username.Text = "Username";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(13, 32);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(221, 20);
            this.tb_user.TabIndex = 14;
            // 
            // btn_SwitchGroup
            // 
            this.btn_SwitchGroup.Location = new System.Drawing.Point(12, 145);
            this.btn_SwitchGroup.Name = "btn_SwitchGroup";
            this.btn_SwitchGroup.Size = new System.Drawing.Size(222, 50);
            this.btn_SwitchGroup.TabIndex = 13;
            this.btn_SwitchGroup.Text = "Switch Group";
            this.btn_SwitchGroup.UseVisualStyleBackColor = true;
            this.btn_SwitchGroup.Click += new System.EventHandler(this.btn_SwitchGroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Old Group";
            // 
            // tb_OldGroup
            // 
            this.tb_OldGroup.Location = new System.Drawing.Point(13, 96);
            this.tb_OldGroup.Name = "tb_OldGroup";
            this.tb_OldGroup.Size = new System.Drawing.Size(221, 20);
            this.tb_OldGroup.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "New Group";
            // 
            // tb_NewGroup
            // 
            this.tb_NewGroup.Location = new System.Drawing.Point(240, 96);
            this.tb_NewGroup.Name = "tb_NewGroup";
            this.tb_NewGroup.Size = new System.Drawing.Size(221, 20);
            this.tb_NewGroup.TabIndex = 19;
            // 
            // SwitchGroupForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 231);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_NewGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_OldGroup);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.btn_SwitchGroup);
            this.Name = "SwitchGroupForUser";
            this.Text = "SwitchGroupForUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Button btn_SwitchGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_OldGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_NewGroup;
    }
}