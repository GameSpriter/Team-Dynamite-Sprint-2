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
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(639, 518);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(145, 38);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login/Sign Up";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // pageTemplate1
            // 
            this.pageTemplate1.BackColor = System.Drawing.Color.White;
            this.pageTemplate1.Location = new System.Drawing.Point(0, 0);
            this.pageTemplate1.Margin = new System.Windows.Forms.Padding(0);
            this.pageTemplate1.Name = "pageTemplate1";
            this.pageTemplate1.Size = new System.Drawing.Size(1707, 886);
            this.pageTemplate1.TabIndex = 2;
            this.pageTemplate1.Load += new System.EventHandler(this.pageTemplate1_Load);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(451, 375);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(227, 22);
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // EmailText
            // 
            this.EmailText.AutoSize = true;
            this.EmailText.Location = new System.Drawing.Point(451, 352);
            this.EmailText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(111, 17);
            this.EmailText.TabIndex = 4;
            this.EmailText.Text = "Username/Email";
            this.EmailText.Click += new System.EventHandler(this.EmailText_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Location = new System.Drawing.Point(451, 421);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(69, 17);
            this.PasswordText.TabIndex = 6;
            this.PasswordText.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(451, 444);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(227, 22);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.Text = " ";
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 846);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.pageTemplate1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}