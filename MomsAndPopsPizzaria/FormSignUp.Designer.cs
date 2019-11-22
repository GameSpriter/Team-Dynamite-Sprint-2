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
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordText = new System.Windows.Forms.Label();
            this.TermsOfServiceCheckBox = new System.Windows.Forms.CheckBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.PreferedAddressText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateOfBirthText
            // 
            this.DateOfBirthText.AutoSize = true;
            this.DateOfBirthText.Location = new System.Drawing.Point(454, 284);
            this.DateOfBirthText.Name = "DateOfBirthText";
            this.DateOfBirthText.Size = new System.Drawing.Size(35, 13);
            this.DateOfBirthText.TabIndex = 2;
            this.DateOfBirthText.Text = "label1";
            // 
            // DateOfBirthPicker
            // 
            this.DateOfBirthPicker.CustomFormat = "";
            this.DateOfBirthPicker.Location = new System.Drawing.Point(457, 301);
            this.DateOfBirthPicker.Name = "DateOfBirthPicker";
            this.DateOfBirthPicker.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirthPicker.TabIndex = 3;
            this.DateOfBirthPicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FirstLastNameUserControl
            // 
            this.FirstLastNameUserControl.BackColor = System.Drawing.Color.Gainsboro;
            this.FirstLastNameUserControl.Location = new System.Drawing.Point(104, 277);
            this.FirstLastNameUserControl.Name = "FirstLastNameUserControl";
            this.FirstLastNameUserControl.Size = new System.Drawing.Size(312, 81);
            this.FirstLastNameUserControl.TabIndex = 1;
            // 
            // pageTemplate1
            // 
            this.pageTemplate1.Location = new System.Drawing.Point(0, 0);
            this.pageTemplate1.Margin = new System.Windows.Forms.Padding(0);
            this.pageTemplate1.Name = "pageTemplate1";
            this.pageTemplate1.Size = new System.Drawing.Size(1280, 720);
            this.pageTemplate1.TabIndex = 0;
            // 
            // addressTemplate1
            // 
            this.addressTemplate1.BackColor = System.Drawing.Color.Gainsboro;
            this.addressTemplate1.Location = new System.Drawing.Point(104, 392);
            this.addressTemplate1.Name = "addressTemplate1";
            this.addressTemplate1.Size = new System.Drawing.Size(391, 114);
            this.addressTemplate1.TabIndex = 4;
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.AutoSize = true;
            this.PhoneNumberText.Location = new System.Drawing.Point(104, 509);
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Size = new System.Drawing.Size(35, 13);
            this.PhoneNumberText.TabIndex = 5;
            this.PhoneNumberText.Text = "label1";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(104, 526);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(117, 20);
            this.PhoneNumberTextBox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(254, 526);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(117, 20);
            this.PasswordTextBox.TabIndex = 8;
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Location = new System.Drawing.Point(254, 509);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(35, 13);
            this.PasswordText.TabIndex = 7;
            this.PasswordText.Text = "label1";
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(413, 526);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(117, 20);
            this.ConfirmPasswordTextBox.TabIndex = 10;
            // 
            // ConfirmPasswordText
            // 
            this.ConfirmPasswordText.AutoSize = true;
            this.ConfirmPasswordText.Location = new System.Drawing.Point(413, 509);
            this.ConfirmPasswordText.Name = "ConfirmPasswordText";
            this.ConfirmPasswordText.Size = new System.Drawing.Size(35, 13);
            this.ConfirmPasswordText.TabIndex = 9;
            this.ConfirmPasswordText.Text = "label1";
            // 
            // TermsOfServiceCheckBox
            // 
            this.TermsOfServiceCheckBox.AutoSize = true;
            this.TermsOfServiceCheckBox.Location = new System.Drawing.Point(714, 460);
            this.TermsOfServiceCheckBox.Name = "TermsOfServiceCheckBox";
            this.TermsOfServiceCheckBox.Size = new System.Drawing.Size(80, 17);
            this.TermsOfServiceCheckBox.TabIndex = 11;
            this.TermsOfServiceCheckBox.Text = "checkBox1";
            this.TermsOfServiceCheckBox.UseVisualStyleBackColor = true;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(714, 484);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(75, 23);
            this.SignUpButton.TabIndex = 12;
            this.SignUpButton.Text = "button1";
            this.SignUpButton.UseVisualStyleBackColor = true;
            // 
            // PreferedAddressText
            // 
            this.PreferedAddressText.AutoSize = true;
            this.PreferedAddressText.Location = new System.Drawing.Point(107, 373);
            this.PreferedAddressText.Name = "PreferedAddressText";
            this.PreferedAddressText.Size = new System.Drawing.Size(162, 13);
            this.PreferedAddressText.TabIndex = 13;
            this.PreferedAddressText.Text = "Save a prefered delivery address";
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PreferedAddressText);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.TermsOfServiceCheckBox);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.ConfirmPasswordText);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PhoneNumberText);
            this.Controls.Add(this.addressTemplate1);
            this.Controls.Add(this.DateOfBirthPicker);
            this.Controls.Add(this.DateOfBirthText);
            this.Controls.Add(this.FirstLastNameUserControl);
            this.Controls.Add(this.pageTemplate1);
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
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label ConfirmPasswordText;
        private System.Windows.Forms.CheckBox TermsOfServiceCheckBox;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label PreferedAddressText;
    }
}