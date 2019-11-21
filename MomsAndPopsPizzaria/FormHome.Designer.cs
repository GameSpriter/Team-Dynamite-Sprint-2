namespace MomsAndPopsPizzaria
{
    partial class FormHome
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
            this.MenuButton = new System.Windows.Forms.Button();
            this.pageTemplate1 = new MomsAndPopsPizzaria.PageTemplate();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(121, 227);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(558, 271);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(75, 23);
            this.MenuButton.TabIndex = 1;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            // 
            // pageTemplate1
            // 
            this.pageTemplate1.Location = new System.Drawing.Point(0, -1);
            this.pageTemplate1.Margin = new System.Windows.Forms.Padding(0);
            this.pageTemplate1.Name = "pageTemplate1";
            this.pageTemplate1.Size = new System.Drawing.Size(1280, 720);
            this.pageTemplate1.TabIndex = 2;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.pageTemplate1);
            this.Name = "HomeForm";
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button MenuButton;
        private PageTemplate pageTemplate1;
    }
}