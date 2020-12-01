namespace Active_Directory
{
    partial class AddGroup
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label_Group
            // 
            this.label_Group.AutoSize = true;
            this.label_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Group.Location = new System.Drawing.Point(133, 49);
            this.label_Group.Name = "label_Group";
            this.label_Group.Size = new System.Drawing.Size(54, 20);
            this.label_Group.TabIndex = 25;
            this.label_Group.Text = "Group";
            // 
            // tb_Group
            // 
            this.tb_Group.Location = new System.Drawing.Point(51, 72);
            this.tb_Group.Name = "tb_Group";
            this.tb_Group.Size = new System.Drawing.Size(221, 20);
            this.tb_Group.TabIndex = 24;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(50, 154);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(222, 50);
            this.btn_Back.TabIndex = 23;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(50, 98);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(222, 50);
            this.btn_Add.TabIndex = 20;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 255);
            this.Controls.Add(this.label_Group);
            this.Controls.Add(this.tb_Group);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Add);
            this.Name = "AddGroup";
            this.Text = "Add Group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Group;
        private System.Windows.Forms.TextBox tb_Group;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Add;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}