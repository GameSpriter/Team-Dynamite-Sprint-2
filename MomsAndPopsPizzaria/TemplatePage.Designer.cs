namespace MomsAndPopsPizzaria
{
    partial class TemplatePage
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
            this.PageTitle = new System.Windows.Forms.Label();
            this.bottomBarTemplate1 = new MomsAndPopsPizzaria.TemplateBottomBar();
            this.topBarTemplate1 = new MomsAndPopsPizzaria.TemplateTopBar();
            this.SuspendLayout();
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitle.Location = new System.Drawing.Point(5, 202);
            this.PageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(176, 42);
            this.PageTitle.TabIndex = 2;
            this.PageTitle.Text = "PageTitle";
            //Removed as this functionality is for a future update
            //this.PageTitle.Click += new System.EventHandler(this.PageTitle_Click);
            // 
            // bottomBarTemplate1
            // 
            this.bottomBarTemplate1.BackColor = System.Drawing.Color.Gainsboro;
            this.bottomBarTemplate1.Location = new System.Drawing.Point(0, 837);
            this.bottomBarTemplate1.Margin = new System.Windows.Forms.Padding(0);
            this.bottomBarTemplate1.Name = "bottomBarTemplate1";
            this.bottomBarTemplate1.Size = new System.Drawing.Size(1707, 49);
            this.bottomBarTemplate1.TabIndex = 1;
            // 
            // topBarTemplate1
            // 
            this.topBarTemplate1.BackColor = System.Drawing.Color.Gainsboro;
            this.topBarTemplate1.Location = new System.Drawing.Point(0, 0);
            this.topBarTemplate1.Margin = new System.Windows.Forms.Padding(0);
            this.topBarTemplate1.Name = "topBarTemplate1";
            this.topBarTemplate1.Size = new System.Drawing.Size(1707, 197);
            this.topBarTemplate1.TabIndex = 0;
            // 
            // TemplatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PageTitle);
            this.Controls.Add(this.bottomBarTemplate1);
            this.Controls.Add(this.topBarTemplate1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TemplatePage";
            this.Size = new System.Drawing.Size(1707, 886);
            //Removed as this functionality is for a future update
            //this.Load += new System.EventHandler(this.TemplatePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TemplateTopBar topBarTemplate1;
        private TemplateBottomBar bottomBarTemplate1;
        private System.Windows.Forms.Label PageTitle;
    }
}
