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
            this.PasswordText.Location = new System.Drawing.Point(5, 5);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(74, 17);
            this.PasswordText.TabIndex = 0;
            this.PasswordText.Text = "Password*";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(5, 26);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(241, 22);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // ConformPasswordTextBox
            // 
            this.ConformPasswordTextBox.Location = new System.Drawing.Point(256, 26);
            this.ConformPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConformPasswordTextBox.Name = "ConformPasswordTextBox";
            this.ConformPasswordTextBox.Size = new System.Drawing.Size(241, 22);
            this.ConformPasswordTextBox.TabIndex = 3;
            // 
            // ConfirmPasswordText
            // 
            this.ConfirmPasswordText.AutoSize = true;
            this.ConfirmPasswordText.Location = new System.Drawing.Point(256, 5);
            this.ConfirmPasswordText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConfirmPasswordText.Name = "ConfirmPasswordText";
            this.ConfirmPasswordText.Size = new System.Drawing.Size(126, 17);
            this.ConfirmPasswordText.TabIndex = 2;
            this.ConfirmPasswordText.Text = "Confirm Password*";
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.BackColor = System.Drawing.Color.Transparent;
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Location = new System.Drawing.Point(240, 59);
            this.ErrorText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(79, 17);
            this.ErrorText.TabIndex = 4;
            this.ErrorText.Text = "* Required ";
            // 
            // TemplateNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.ConformPasswordTextBox);
            this.Controls.Add(this.ConfirmPasswordText);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TemplateNewPassword";
            this.Size = new System.Drawing.Size(509, 89);
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
