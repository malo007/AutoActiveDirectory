namespace Active_Directory
{
    partial class AddUser
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(61, 76);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(222, 50);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(61, 50);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(221, 20);
            this.tb_user.TabIndex = 1;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(124, 27);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(83, 20);
            this.label_Username.TabIndex = 4;
            this.label_Username.Text = "Username";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(61, 132);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(222, 50);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 193);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.btn_Add);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Button btn_Back;
    }
}