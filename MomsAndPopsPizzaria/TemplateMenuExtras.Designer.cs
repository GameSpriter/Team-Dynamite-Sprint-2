namespace MomsAndPopsPizzaria
{
    partial class TemplateMenuExtras
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
            this.ExtraPriceText = new System.Windows.Forms.Label();
            this.ExtraNameText = new System.Windows.Forms.Label();
            this.ExtraPictureBox = new System.Windows.Forms.PictureBox();
            this.ExtraCounter = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // ExtraPriceText
            // 
            this.ExtraPriceText.AutoSize = true;
            this.ExtraPriceText.Location = new System.Drawing.Point(126, 39);
            this.ExtraPriceText.Name = "ExtraPriceText";
            this.ExtraPriceText.Size = new System.Drawing.Size(35, 13);
            this.ExtraPriceText.TabIndex = 17;
            this.ExtraPriceText.Text = "label5";
            // 
            // ExtraNameText
            // 
            this.ExtraNameText.AutoSize = true;
            this.ExtraNameText.Location = new System.Drawing.Point(126, 3);
            this.ExtraNameText.Name = "ExtraNameText";
            this.ExtraNameText.Size = new System.Drawing.Size(35, 13);
            this.ExtraNameText.TabIndex = 16;
            this.ExtraNameText.Text = "label4";
            // 
            // ExtraPictureBox
            // 
            this.ExtraPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.ExtraPictureBox.Location = new System.Drawing.Point(3, 3);
            this.ExtraPictureBox.Name = "ExtraPictureBox";
            this.ExtraPictureBox.Size = new System.Drawing.Size(87, 87);
            this.ExtraPictureBox.TabIndex = 15;
            this.ExtraPictureBox.TabStop = false;
            // 
            // ExtraCounter
            // 
            this.ExtraCounter.Location = new System.Drawing.Point(115, 70);
            this.ExtraCounter.Name = "ExtraCounter";
            this.ExtraCounter.Size = new System.Drawing.Size(61, 20);
            this.ExtraCounter.TabIndex = 11;
            this.ExtraCounter.ValueChanged += new System.EventHandler(this.ExtraCounter_ValueChanged);
            // 
            // TemplateMenuExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ExtraPriceText);
            this.Controls.Add(this.ExtraNameText);
            this.Controls.Add(this.ExtraPictureBox);
            this.Controls.Add(this.ExtraCounter);
            this.Name = "TemplateMenuExtras";
            this.Size = new System.Drawing.Size(188, 98);
            ((System.ComponentModel.ISupportInitialize)(this.ExtraPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExtraPriceText;
        private System.Windows.Forms.Label ExtraNameText;
        private System.Windows.Forms.PictureBox ExtraPictureBox;
        private System.Windows.Forms.NumericUpDown ExtraCounter;
    }
}
