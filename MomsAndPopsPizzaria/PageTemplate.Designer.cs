namespace MomsAndPopsPizzaria
{
    partial class PageTemplate
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
            this.topBarTemplate1 = new MomsAndPopsPizzaria.TopBarTemplate();
            this.bottomBarTemplate1 = new MomsAndPopsPizzaria.BottomBarTemplate();
            this.SuspendLayout();
            // 
            // topBarTemplate1
            // 
            this.topBarTemplate1.BackColor = System.Drawing.Color.Gainsboro;
            this.topBarTemplate1.Location = new System.Drawing.Point(0, 0);
            this.topBarTemplate1.Name = "topBarTemplate1";
            this.topBarTemplate1.Size = new System.Drawing.Size(1280, 160);
            this.topBarTemplate1.TabIndex = 0;
            // 
            // bottomBarTemplate1
            // 
            this.bottomBarTemplate1.BackColor = System.Drawing.Color.Gainsboro;
            this.bottomBarTemplate1.Location = new System.Drawing.Point(0, 680);
            this.bottomBarTemplate1.Name = "bottomBarTemplate1";
            this.bottomBarTemplate1.Size = new System.Drawing.Size(1280, 40);
            this.bottomBarTemplate1.TabIndex = 1;
            // 
            // PageTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bottomBarTemplate1);
            this.Controls.Add(this.topBarTemplate1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PageTemplate";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);

        }

        #endregion

        private TopBarTemplate topBarTemplate1;
        private BottomBarTemplate bottomBarTemplate1;
    }
}
