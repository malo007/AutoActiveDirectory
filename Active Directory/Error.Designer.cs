namespace Active_Directory
{
    partial class Error
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
            this.tb_Messege = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Messege
            // 
            this.tb_Messege.Location = new System.Drawing.Point(12, 12);
            this.tb_Messege.Multiline = true;
            this.tb_Messege.Name = "tb_Messege";
            this.tb_Messege.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Messege.Size = new System.Drawing.Size(541, 213);
            this.tb_Messege.TabIndex = 0;
            this.tb_Messege.TextChanged += new System.EventHandler(this.tb_Messege_TextChanged);
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 237);
            this.Controls.Add(this.tb_Messege);
            this.Name = "Error";
            this.Tag = "";
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Messege;
    }
}