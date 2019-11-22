namespace MomsAndPopsPizzaria
{
    partial class FormUserSettings
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
            this.PreferedAddressText = new System.Windows.Forms.Label();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.TermsOfServiceCheckBox = new System.Windows.Forms.CheckBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberText = new System.Windows.Forms.Label();
            this.addressTemplate1 = new MomsAndPopsPizzaria.TemplateAddress();
            this.DateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.DateOfBirthText = new System.Windows.Forms.Label();
            this.FirstLastNameUserControl = new MomsAndPopsPizzaria.TemplateName();
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
            this.templateNewPassword1.Location = new System.Drawing.Point(254, 512);
            this.templateNewPassword1.Name = "templateNewPassword1";
            this.templateNewPassword1.Size = new System.Drawing.Size(382, 72);
            this.templateNewPassword1.TabIndex = 24;
            // 
            // PreferedAddressText
            // 
            this.PreferedAddressText.AutoSize = true;
            this.PreferedAddressText.Location = new System.Drawing.Point(134, 376);
            this.PreferedAddressText.Name = "PreferedAddressText";
            this.PreferedAddressText.Size = new System.Drawing.Size(162, 13);
            this.PreferedAddressText.TabIndex = 23;
            this.PreferedAddressText.Text = "Save a prefered delivery address";
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(741, 487);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(75, 23);
            this.SaveChangesButton.TabIndex = 22;
            this.SaveChangesButton.Text = "button1";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // TermsOfServiceCheckBox
            // 
            this.TermsOfServiceCheckBox.AutoSize = true;
            this.TermsOfServiceCheckBox.Location = new System.Drawing.Point(741, 463);
            this.TermsOfServiceCheckBox.Name = "TermsOfServiceCheckBox";
            this.TermsOfServiceCheckBox.Size = new System.Drawing.Size(80, 17);
            this.TermsOfServiceCheckBox.TabIndex = 21;
            this.TermsOfServiceCheckBox.Text = "checkBox1";
            this.TermsOfServiceCheckBox.UseVisualStyleBackColor = true;
            this.TermsOfServiceCheckBox.CheckedChanged += new System.EventHandler(this.TermsOfServiceCheckBox_CheckedChanged);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(131, 528);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(117, 20);
            this.PhoneNumberTextBox.TabIndex = 20;
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.AutoSize = true;
            this.PhoneNumberText.Location = new System.Drawing.Point(131, 512);
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Size = new System.Drawing.Size(35, 13);
            this.PhoneNumberText.TabIndex = 19;
            this.PhoneNumberText.Text = "label1";
            // 
            // addressTemplate1
            // 
            this.addressTemplate1.BackColor = System.Drawing.Color.Gainsboro;
            this.addressTemplate1.Location = new System.Drawing.Point(131, 395);
            this.addressTemplate1.Name = "addressTemplate1";
            this.addressTemplate1.Size = new System.Drawing.Size(391, 114);
            this.addressTemplate1.TabIndex = 18;
            // 
            // DateOfBirthPicker
            // 
            this.DateOfBirthPicker.CustomFormat = "";
            this.DateOfBirthPicker.Location = new System.Drawing.Point(484, 304);
            this.DateOfBirthPicker.Name = "DateOfBirthPicker";
            this.DateOfBirthPicker.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirthPicker.TabIndex = 17;
            this.DateOfBirthPicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // DateOfBirthText
            // 
            this.DateOfBirthText.AutoSize = true;
            this.DateOfBirthText.Location = new System.Drawing.Point(481, 287);
            this.DateOfBirthText.Name = "DateOfBirthText";
            this.DateOfBirthText.Size = new System.Drawing.Size(35, 13);
            this.DateOfBirthText.TabIndex = 16;
            this.DateOfBirthText.Text = "label1";
            // 
            // FirstLastNameUserControl
            // 
            this.FirstLastNameUserControl.BackColor = System.Drawing.Color.Gainsboro;
            this.FirstLastNameUserControl.Location = new System.Drawing.Point(131, 280);
            this.FirstLastNameUserControl.Name = "FirstLastNameUserControl";
            this.FirstLastNameUserControl.Size = new System.Drawing.Size(312, 81);
            this.FirstLastNameUserControl.TabIndex = 15;
            // 
            // FormUserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.templateNewPassword1);
            this.Controls.Add(this.PreferedAddressText);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.TermsOfServiceCheckBox);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PhoneNumberText);
            this.Controls.Add(this.addressTemplate1);
            this.Controls.Add(this.DateOfBirthPicker);
            this.Controls.Add(this.DateOfBirthText);
            this.Controls.Add(this.FirstLastNameUserControl);
            this.Controls.Add(this.pageTemplate1);
            this.Name = "FormUserSettings";
            this.Text = "FormUserSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TemplatePage pageTemplate1;
        private TemplateNewPassword templateNewPassword1;
        private System.Windows.Forms.Label PreferedAddressText;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.CheckBox TermsOfServiceCheckBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberText;
        private TemplateAddress addressTemplate1;
        private System.Windows.Forms.DateTimePicker DateOfBirthPicker;
        private System.Windows.Forms.Label DateOfBirthText;
        private TemplateName FirstLastNameUserControl;
    }
}