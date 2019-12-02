namespace MomsAndPopsPizzaria
{
    partial class TemplateName
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
            this.FirstNameText = new System.Windows.Forms.Label();
            this.LastNameText = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FirstNameText
            // 
            this.FirstNameText.AutoSize = true;
            this.FirstNameText.Location = new System.Drawing.Point(4, 39);
            this.FirstNameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(81, 17);
            this.FirstNameText.TabIndex = 0;
            this.FirstNameText.Text = "First Name*";
            // 
            // LastNameText
            // 
            this.LastNameText.AutoSize = true;
            this.LastNameText.Location = new System.Drawing.Point(220, 39);
            this.LastNameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(81, 17);
            this.LastNameText.TabIndex = 1;
            this.LastNameText.Text = "Last Name*";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(4, 60);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(187, 22);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(223, 60);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(164, 22);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // TemplateName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.FirstNameText);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TemplateName";
            this.Size = new System.Drawing.Size(416, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameText;
        private System.Windows.Forms.Label LastNameText;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
    }
}
