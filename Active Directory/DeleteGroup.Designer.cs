namespace Active_Directory
{
    partial class DeleteGroup
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Group
            // 
            this.label_Group.AutoSize = true;
            this.label_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Group.Location = new System.Drawing.Point(143, 38);
            this.label_Group.Name = "label_Group";
            this.label_Group.Size = new System.Drawing.Size(54, 20);
            this.label_Group.TabIndex = 25;
            this.label_Group.Text = "Group";
            // 
            // tb_Group
            // 
            this.tb_Group.Location = new System.Drawing.Point(65, 61);
            this.tb_Group.Name = "tb_Group";
            this.tb_Group.Size = new System.Drawing.Size(221, 20);
            this.tb_Group.TabIndex = 24;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(64, 143);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(222, 50);
            this.btn_Back.TabIndex = 23;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(64, 87);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(222, 50);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // DeleteLocalGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 243);
            this.Controls.Add(this.label_Group);
            this.Controls.Add(this.tb_Group);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Delete);
            this.Name = "DeleteLocalGroup";
            this.Text = "DeleteLocalGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Group;
        private System.Windows.Forms.TextBox tb_Group;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Delete;
    }
}