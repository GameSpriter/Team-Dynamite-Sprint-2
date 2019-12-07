namespace MomsAndPopsPizzaria
{
    partial class TemplatePizzaTopping
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
            this.ToppingImageBox = new System.Windows.Forms.PictureBox();
            this.ToppingGroupBox = new System.Windows.Forms.GroupBox();
            this.ToppingExtraCheckBox = new System.Windows.Forms.CheckBox();
            this.ToppingCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ToppingImageBox)).BeginInit();
            this.ToppingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToppingImageBox
            // 
            this.ToppingImageBox.BackColor = System.Drawing.Color.Gainsboro;
            this.ToppingImageBox.Location = new System.Drawing.Point(4, 4);
            this.ToppingImageBox.Name = "ToppingImageBox";
            this.ToppingImageBox.Size = new System.Drawing.Size(90, 90);
            this.ToppingImageBox.TabIndex = 0;
            this.ToppingImageBox.TabStop = false;
            // 
            // ToppingGroupBox
            // 
            this.ToppingGroupBox.Controls.Add(this.ToppingExtraCheckBox);
            this.ToppingGroupBox.Controls.Add(this.ToppingCheckBox);
            this.ToppingGroupBox.Location = new System.Drawing.Point(100, 0);
            this.ToppingGroupBox.Name = "ToppingGroupBox";
            this.ToppingGroupBox.Size = new System.Drawing.Size(128, 98);
            this.ToppingGroupBox.TabIndex = 1;
            this.ToppingGroupBox.TabStop = false;
            // 
            // ToppingExtraCheckBox
            // 
            this.ToppingExtraCheckBox.AutoSize = true;
            this.ToppingExtraCheckBox.Location = new System.Drawing.Point(7, 64);
            this.ToppingExtraCheckBox.Name = "ToppingExtraCheckBox";
            this.ToppingExtraCheckBox.Size = new System.Drawing.Size(117, 17);
            this.ToppingExtraCheckBox.TabIndex = 1;
            this.ToppingExtraCheckBox.Text = "ExtraToppingName";
            this.ToppingExtraCheckBox.UseVisualStyleBackColor = true;
            // 
            // ToppingCheckBox
            // 
            this.ToppingCheckBox.AutoSize = true;
            this.ToppingCheckBox.Location = new System.Drawing.Point(7, 19);
            this.ToppingCheckBox.Name = "ToppingCheckBox";
            this.ToppingCheckBox.Size = new System.Drawing.Size(93, 17);
            this.ToppingCheckBox.TabIndex = 0;
            this.ToppingCheckBox.Text = "ToppingName";
            this.ToppingCheckBox.UseVisualStyleBackColor = true;
            // 
            // TemplatePizzaTopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToppingGroupBox);
            this.Controls.Add(this.ToppingImageBox);
            this.Name = "TemplatePizzaTopping";
            this.Size = new System.Drawing.Size(234, 98);
            ((System.ComponentModel.ISupportInitialize)(this.ToppingImageBox)).EndInit();
            this.ToppingGroupBox.ResumeLayout(false);
            this.ToppingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ToppingImageBox;
        private System.Windows.Forms.GroupBox ToppingGroupBox;
        private System.Windows.Forms.CheckBox ToppingExtraCheckBox;
        private System.Windows.Forms.CheckBox ToppingCheckBox;
    }
}
