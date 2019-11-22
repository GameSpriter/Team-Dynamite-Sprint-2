namespace MomsAndPopsPizzaria
{
    partial class FormLogin
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.pageTemplate1 = new MomsAndPopsPizzaria.TemplatePage();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.ForgotEmailPasswordLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(594, 303);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // pageTemplate1
            // 
            this.pageTemplate1.Location = new System.Drawing.Point(0, 0);
            this.pageTemplate1.Margin = new System.Windows.Forms.Padding(0);
            this.pageTemplate1.Name = "pageTemplate1";
            this.pageTemplate1.Size = new System.Drawing.Size(1280, 720);
            this.pageTemplate1.TabIndex = 2;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(338, 305);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(171, 20);
            this.EmailTextBox.TabIndex = 3;
            // 
            // EmailText
            // 
            this.EmailText.AutoSize = true;
            this.EmailText.Location = new System.Drawing.Point(338, 286);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(35, 13);
            this.EmailText.TabIndex = 4;
            this.EmailText.Text = "label1";
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Location = new System.Drawing.Point(338, 342);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(35, 13);
            this.PasswordText.TabIndex = 6;
            this.PasswordText.Text = "label1";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(338, 361);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(171, 20);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(594, 359);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(75, 23);
            this.SignUpButton.TabIndex = 7;
            this.SignUpButton.Text = "SignUp";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // ForgotEmailPasswordLink
            // 
            this.ForgotEmailPasswordLink.AutoSize = true;
            this.ForgotEmailPasswordLink.Location = new System.Drawing.Point(454, 432);
            this.ForgotEmailPasswordLink.Name = "ForgotEmailPasswordLink";
            this.ForgotEmailPasswordLink.Size = new System.Drawing.Size(55, 13);
            this.ForgotEmailPasswordLink.TabIndex = 8;
            this.ForgotEmailPasswordLink.TabStop = true;
            this.ForgotEmailPasswordLink.Text = "linkLabel1";
            this.ForgotEmailPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotEmailPasswordLink_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.ForgotEmailPasswordLink);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.pageTemplate1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private TemplatePage pageTemplate1;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailText;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.LinkLabel ForgotEmailPasswordLink;
    }
}