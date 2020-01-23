namespace Library_dApp
{
    partial class logInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logInForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernametextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.SavesimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // UsernametextBox
            // 
            this.UsernametextBox.Location = new System.Drawing.Point(392, 49);
            this.UsernametextBox.Name = "UsernametextBox";
            this.UsernametextBox.Size = new System.Drawing.Size(100, 21);
            this.UsernametextBox.TabIndex = 2;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(392, 85);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(100, 21);
            this.PasswordtextBox.TabIndex = 2;
            // 
            // SavesimpleButton
            // 
            this.SavesimpleButton.Location = new System.Drawing.Point(289, 152);
            this.SavesimpleButton.Name = "SavesimpleButton";
            this.SavesimpleButton.Size = new System.Drawing.Size(75, 23);
            this.SavesimpleButton.TabIndex = 3;
            this.SavesimpleButton.Text = "Save";
            // 
            // CancelsimpleButton
            // 
            this.CancelsimpleButton.Location = new System.Drawing.Point(417, 152);
            this.CancelsimpleButton.Name = "CancelsimpleButton";
            this.CancelsimpleButton.Size = new System.Drawing.Size(75, 23);
            this.CancelsimpleButton.TabIndex = 3;
            this.CancelsimpleButton.Text = "Cancel";
            // 
            // logInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 261);
            this.Controls.Add(this.CancelsimpleButton);
            this.Controls.Add(this.SavesimpleButton);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.UsernametextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "logInForm";
            this.Text = "logInForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernametextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private DevExpress.XtraEditors.SimpleButton SavesimpleButton;
        private DevExpress.XtraEditors.SimpleButton CancelsimpleButton;
    }
}