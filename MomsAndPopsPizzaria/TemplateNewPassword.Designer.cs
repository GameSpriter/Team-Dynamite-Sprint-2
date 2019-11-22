namespace MomsAndPopsPizzaria
{
    partial class TemplateNewPassword
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PasswordText = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConformPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordText = new System.Windows.Forms.Label();
            this.ErrorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Location = new System.Drawing.Point(4, 4);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(35, 13);
            this.PasswordText.TabIndex = 0;
            this.PasswordText.Text = "label1";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(4, 21);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(182, 20);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // ConformPasswordTextBox
            // 
            this.ConformPasswordTextBox.Location = new System.Drawing.Point(192, 21);
            this.ConformPasswordTextBox.Name = "ConformPasswordTextBox";
            this.ConformPasswordTextBox.Size = new System.Drawing.Size(182, 20);
            this.ConformPasswordTextBox.TabIndex = 3;
            // 
            // ConfirmPasswordText
            // 
            this.ConfirmPasswordText.AutoSize = true;
            this.ConfirmPasswordText.Location = new System.Drawing.Point(192, 4);
            this.ConfirmPasswordText.Name = "ConfirmPasswordText";
            this.ConfirmPasswordText.Size = new System.Drawing.Size(35, 13);
            this.ConfirmPasswordText.TabIndex = 2;
            this.ConfirmPasswordText.Text = "label1";
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.BackColor = System.Drawing.Color.Transparent;
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Location = new System.Drawing.Point(180, 48);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(35, 13);
            this.ErrorText.TabIndex = 4;
            this.ErrorText.Text = "label1";
            // 
            // TemplateNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.ConformPasswordTextBox);
            this.Controls.Add(this.ConfirmPasswordText);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordText);
            this.Name = "TemplateNewPassword";
            this.Size = new System.Drawing.Size(382, 72);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox ConformPasswordTextBox;
        private System.Windows.Forms.Label ConfirmPasswordText;
        private System.Windows.Forms.Label ErrorText;
    }
}
