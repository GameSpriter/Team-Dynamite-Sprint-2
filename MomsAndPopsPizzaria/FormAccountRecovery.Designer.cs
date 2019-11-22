namespace MomsAndPopsPizzaria
{
    partial class FormAccountRecovery
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.RecoverEmailButton = new System.Windows.Forms.Button();
            this.RecoverPasswordButton = new System.Windows.Forms.Button();
            this.PhoneNumberText = new System.Windows.Forms.Label();
            this.EmailAddressText = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.EmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.NotificationText = new System.Windows.Forms.Label();
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
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(25, 179);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "button1";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(930, 179);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(75, 23);
            this.MenuButton.TabIndex = 2;
            this.MenuButton.Text = "button1";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // RecoverEmailButton
            // 
            this.RecoverEmailButton.Location = new System.Drawing.Point(220, 430);
            this.RecoverEmailButton.Name = "RecoverEmailButton";
            this.RecoverEmailButton.Size = new System.Drawing.Size(75, 23);
            this.RecoverEmailButton.TabIndex = 3;
            this.RecoverEmailButton.Text = "button1";
            this.RecoverEmailButton.UseVisualStyleBackColor = true;
            this.RecoverEmailButton.Click += new System.EventHandler(this.RecoverEmailButton_Click);
            // 
            // RecoverPasswordButton
            // 
            this.RecoverPasswordButton.Location = new System.Drawing.Point(574, 430);
            this.RecoverPasswordButton.Name = "RecoverPasswordButton";
            this.RecoverPasswordButton.Size = new System.Drawing.Size(75, 23);
            this.RecoverPasswordButton.TabIndex = 4;
            this.RecoverPasswordButton.Text = "button1";
            this.RecoverPasswordButton.UseVisualStyleBackColor = true;
            this.RecoverPasswordButton.Click += new System.EventHandler(this.RecoverPasswordButton_Click);
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.AutoSize = true;
            this.PhoneNumberText.Location = new System.Drawing.Point(220, 294);
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Size = new System.Drawing.Size(35, 13);
            this.PhoneNumberText.TabIndex = 5;
            this.PhoneNumberText.Text = "label1";
            // 
            // EmailAddressText
            // 
            this.EmailAddressText.AutoSize = true;
            this.EmailAddressText.Location = new System.Drawing.Point(574, 294);
            this.EmailAddressText.Name = "EmailAddressText";
            this.EmailAddressText.Size = new System.Drawing.Size(35, 13);
            this.EmailAddressText.TabIndex = 6;
            this.EmailAddressText.Text = "label2";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(223, 311);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(158, 20);
            this.PhoneNumberTextBox.TabIndex = 7;
            // 
            // EmailAddressTextBox
            // 
            this.EmailAddressTextBox.Location = new System.Drawing.Point(577, 311);
            this.EmailAddressTextBox.Name = "EmailAddressTextBox";
            this.EmailAddressTextBox.Size = new System.Drawing.Size(158, 20);
            this.EmailAddressTextBox.TabIndex = 8;
            // 
            // NotificationText
            // 
            this.NotificationText.AutoSize = true;
            this.NotificationText.ForeColor = System.Drawing.Color.Red;
            this.NotificationText.Location = new System.Drawing.Point(223, 338);
            this.NotificationText.Name = "NotificationText";
            this.NotificationText.Size = new System.Drawing.Size(35, 13);
            this.NotificationText.TabIndex = 9;
            this.NotificationText.Text = "label1";
            // 
            // FormAccountRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.NotificationText);
            this.Controls.Add(this.EmailAddressTextBox);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.EmailAddressText);
            this.Controls.Add(this.PhoneNumberText);
            this.Controls.Add(this.RecoverPasswordButton);
            this.Controls.Add(this.RecoverEmailButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.pageTemplate1);
            this.Name = "FormAccountRecovery";
            this.Text = "FormAccountRecovery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TemplatePage pageTemplate1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button RecoverEmailButton;
        private System.Windows.Forms.Button RecoverPasswordButton;
        private System.Windows.Forms.Label PhoneNumberText;
        private System.Windows.Forms.Label EmailAddressText;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox EmailAddressTextBox;
        private System.Windows.Forms.Label NotificationText;
    }
}