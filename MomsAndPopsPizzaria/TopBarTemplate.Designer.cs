namespace MomsAndPopsPizzaria
{
    partial class TopBarTemplate
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
            this.MomsAndPopsPizzeriaLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MomsAndPopsPizzeriaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MomsAndPopsPizzeriaLogo
            // 
            this.MomsAndPopsPizzeriaLogo.Location = new System.Drawing.Point(4, 4);
            this.MomsAndPopsPizzeriaLogo.Name = "MomsAndPopsPizzeriaLogo";
            this.MomsAndPopsPizzeriaLogo.Size = new System.Drawing.Size(1233, 153);
            this.MomsAndPopsPizzeriaLogo.TabIndex = 0;
            this.MomsAndPopsPizzeriaLogo.TabStop = false;
            this.MomsAndPopsPizzeriaLogo.Click += new System.EventHandler(this.MomsAndPopsPizzeriaLogo_Click);
            // 
            // TopBarTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.MomsAndPopsPizzeriaLogo);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TopBarTemplate";
            this.Size = new System.Drawing.Size(1280, 160);
            ((System.ComponentModel.ISupportInitialize)(this.MomsAndPopsPizzeriaLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MomsAndPopsPizzeriaLogo;
    }
}
