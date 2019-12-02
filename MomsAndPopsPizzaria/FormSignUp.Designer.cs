namespace MomsAndPopsPizzaria
{
    partial class FormSignUp
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
            this.DateOfBirthText = new System.Windows.Forms.Label();
            this.DateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.FirstLastNameUserControl = new MomsAndPopsPizzaria.TemplateName();
            this.pageTemplate1 = new MomsAndPopsPizzaria.TemplatePage();
            this.addressTemplate1 = new MomsAndPopsPizzaria.TemplateAddress();
            this.PhoneNumberText = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.TermsOfServiceCheckBox = new System.Windows.Forms.CheckBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.PreferedAddressText = new System.Windows.Forms.Label();
            this.templateNewPassword1 = new MomsAndPopsPizzaria.TemplateNewPassword();
            this.SuspendLayout();
            // 
            // DateOfBirthText
            // 
            this.DateOfBirthText.AutoSize = true;
            this.DateOfBirthText.Location = new System.Drawing.Point(605, 350);
            this.DateOfBirthText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateOfBirthText.Name = "DateOfBirthText";
            this.DateOfBirthText.Size = new System.Drawing.Size(92, 17);
            this.DateOfBirthText.TabIndex = 2;
            this.DateOfBirthText.Text = "Date of Birth*";
            // 
            // DateOfBirthPicker
            // 
            this.DateOfBirthPicker.CustomFormat = "";
            this.DateOfBirthPicker.Location = new System.Drawing.Point(609, 370);
            this.DateOfBirthPicker.Margin = new System.Windows.Forms.Padding(4);
            this.DateOfBirthPicker.Name = "DateOfBirthPicker";
            this.DateOfBirthPicker.Size = new System.Drawing.Size(265, 22);
            this.DateOfBirthPicker.TabIndex = 3;
            this.DateOfBirthPicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FirstLastNameUserControl
            // 
            this.FirstLastNameUserControl.BackColor = System.Drawing.Color.Gainsboro;
            this.FirstLastNameUserControl.Location = new System.Drawing.Point(139, 341);
            this.FirstLastNameUserControl.Margin = new System.Windows.Forms.Padding(5);
            this.FirstLastNameUserControl.Name = "FirstLastNameUserControl";
            this.FirstLastNameUserControl.Size = new System.Drawing.Size(416, 100);
            this.FirstLastNameUserControl.TabIndex = 1;
            this.FirstLastNameUserControl.Load += new System.EventHandler(this.FirstLastNameUserControl_Load);
            // 
            // pageTemplate1
            // 
            this.pageTemplate1.Location = new System.Drawing.Point(0, 0);
            this.pageTemplate1.Margin = new System.Windows.Forms.Padding(0);
            this.pageTemplate1.Name = "pageTemplate1";
            this.pageTemplate1.Size = new System.Drawing.Size(1707, 886);
            this.pageTemplate1.TabIndex = 0;
            this.pageTemplate1.Load += new System.EventHandler(this.pageTemplate1_Load);
            // 
            // addressTemplate1
            // 
            this.addressTemplate1.BackColor = System.Drawing.Color.Gainsboro;
            this.addressTemplate1.Location = new System.Drawing.Point(139, 482);
            this.addressTemplate1.Margin = new System.Windows.Forms.Padding(5);
            this.addressTemplate1.Name = "addressTemplate1";
            this.addressTemplate1.Size = new System.Drawing.Size(521, 140);
            this.addressTemplate1.TabIndex = 4;
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.AutoSize = true;
            this.PhoneNumberText.Location = new System.Drawing.Point(139, 626);
            this.PhoneNumberText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Size = new System.Drawing.Size(108, 17);
            this.PhoneNumberText.TabIndex = 5;
            this.PhoneNumberText.Text = "Phone Number*";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(139, 646);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(155, 22);
            this.PhoneNumberTextBox.TabIndex = 6;
            // 
            // TermsOfServiceCheckBox
            // 
            this.TermsOfServiceCheckBox.AutoSize = true;
            this.TermsOfServiceCheckBox.Location = new System.Drawing.Point(952, 566);
            this.TermsOfServiceCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.TermsOfServiceCheckBox.Name = "TermsOfServiceCheckBox";
            this.TermsOfServiceCheckBox.Size = new System.Drawing.Size(138, 21);
            this.TermsOfServiceCheckBox.TabIndex = 11;
            this.TermsOfServiceCheckBox.Text = "I accept the ToS*";
            this.TermsOfServiceCheckBox.UseVisualStyleBackColor = true;
            this.TermsOfServiceCheckBox.CheckedChanged += new System.EventHandler(this.TermsOfServiceCheckBox_CheckedChanged);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(952, 596);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(100, 28);
            this.SignUpButton.TabIndex = 12;
            this.SignUpButton.Text = "Sign Up!";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // PreferedAddressText
            // 
            this.PreferedAddressText.AutoSize = true;
            this.PreferedAddressText.Location = new System.Drawing.Point(143, 459);
            this.PreferedAddressText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PreferedAddressText.Name = "PreferedAddressText";
            this.PreferedAddressText.Size = new System.Drawing.Size(218, 17);
            this.PreferedAddressText.TabIndex = 13;
            this.PreferedAddressText.Text = "Save a prefered delivery address";
            // 
            // templateNewPassword1
            // 
            this.templateNewPassword1.BackColor = System.Drawing.Color.Gainsboro;
            this.templateNewPassword1.Location = new System.Drawing.Point(303, 626);
            this.templateNewPassword1.Margin = new System.Windows.Forms.Padding(5);
            this.templateNewPassword1.Name = "templateNewPassword1";
            this.templateNewPassword1.Size = new System.Drawing.Size(509, 89);
            this.templateNewPassword1.TabIndex = 14;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 886);
            this.Controls.Add(this.templateNewPassword1);
            this.Controls.Add(this.PreferedAddressText);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.TermsOfServiceCheckBox);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PhoneNumberText);
            this.Controls.Add(this.addressTemplate1);
            this.Controls.Add(this.DateOfBirthPicker);
            this.Controls.Add(this.DateOfBirthText);
            this.Controls.Add(this.FirstLastNameUserControl);
            this.Controls.Add(this.pageTemplate1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSignUp";
            this.Text = "FormSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TemplatePage pageTemplate1;
        private TemplateName FirstLastNameUserControl;
        private System.Windows.Forms.Label DateOfBirthText;
        private System.Windows.Forms.DateTimePicker DateOfBirthPicker;
        private TemplateAddress addressTemplate1;
        private System.Windows.Forms.Label PhoneNumberText;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.CheckBox TermsOfServiceCheckBox;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label PreferedAddressText;
        private TemplateNewPassword templateNewPassword1;
    }
}