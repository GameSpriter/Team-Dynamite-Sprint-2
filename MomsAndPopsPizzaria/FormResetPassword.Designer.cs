namespace MomsAndPopsPizzaria
{
    partial class FormResetPassword
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
            this.pageTemplate1 = new MomsAndPopsPizzaria.TemplatePage();
            this.templateNewPassword1 = new MomsAndPopsPizzaria.TemplateNewPassword();
            this.ResetPasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pageTemplate1
            // 
            this.pageTemplate1.Location = new System.Drawing.Point(0, 0);
            this.pageTemplate1.Margin = new System.Windows.Forms.Padding(0);
            this.pageTemplate1.Name = "pageTemplate1";
            this.pageTemplate1.Size = new System.Drawing.Size(1280, 720);
            this.pageTemplate1.TabIndex = 0;
            // 
            // templateNewPassword1
            // 
            this.templateNewPassword1.BackColor = System.Drawing.Color.Gainsboro;
            this.templateNewPassword1.Location = new System.Drawing.Point(334, 382);
            this.templateNewPassword1.Name = "templateNewPassword1";
            this.templateNewPassword1.Size = new System.Drawing.Size(382, 72);
            this.templateNewPassword1.TabIndex = 1;
            // 
            // ResetPasswordButton
            // 
            this.ResetPasswordButton.Location = new System.Drawing.Point(490, 460);
            this.ResetPasswordButton.Name = "ResetPasswordButton";
            this.ResetPasswordButton.Size = new System.Drawing.Size(75, 23);
            this.ResetPasswordButton.TabIndex = 2;
            this.ResetPasswordButton.Text = "button1";
            this.ResetPasswordButton.UseVisualStyleBackColor = true;
            this.ResetPasswordButton.Click += new System.EventHandler(this.ResetPasswordButton_Click);
            // 
            // FormResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.ResetPasswordButton);
            this.Controls.Add(this.templateNewPassword1);
            this.Controls.Add(this.pageTemplate1);
            this.Name = "FormResetPassword";
            this.Text = "FormResetPassword";
            this.ResumeLayout(false);

        }

        #endregion

        private TemplatePage pageTemplate1;
        private TemplateNewPassword templateNewPassword1;
        private System.Windows.Forms.Button ResetPasswordButton;
    }
}