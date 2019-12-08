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
            this.ToppingExtraCheckBox = new System.Windows.Forms.CheckBox();
            this.ToppingCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToppingImageBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToppingImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ToppingExtraCheckBox
            // 
            this.ToppingExtraCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ToppingExtraCheckBox.AutoSize = true;
            this.ToppingExtraCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToppingExtraCheckBox.Location = new System.Drawing.Point(3, 60);
            this.ToppingExtraCheckBox.Name = "ToppingExtraCheckBox";
            this.ToppingExtraCheckBox.Size = new System.Drawing.Size(151, 52);
            this.ToppingExtraCheckBox.TabIndex = 1;
            this.ToppingExtraCheckBox.Text = "Extra\r\nToppingName";
            this.ToppingExtraCheckBox.UseVisualStyleBackColor = true;
            this.ToppingExtraCheckBox.CheckedChanged += new System.EventHandler(this.ToppingExtraCheckBox_CheckedChanged);
            // 
            // ToppingCheckBox
            // 
            this.ToppingCheckBox.AutoSize = true;
            this.ToppingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToppingCheckBox.Location = new System.Drawing.Point(3, 15);
            this.ToppingCheckBox.Name = "ToppingCheckBox";
            this.ToppingCheckBox.Size = new System.Drawing.Size(151, 28);
            this.ToppingCheckBox.TabIndex = 0;
            this.ToppingCheckBox.Text = "ToppingName";
            this.ToppingCheckBox.UseVisualStyleBackColor = true;
            this.ToppingCheckBox.CheckedChanged += new System.EventHandler(this.ToppingCheckBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ToppingCheckBox);
            this.panel1.Controls.Add(this.ToppingExtraCheckBox);
            this.panel1.Location = new System.Drawing.Point(138, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 127);
            this.panel1.TabIndex = 2;
            // 
            // ToppingImageBox
            // 
            this.ToppingImageBox.BackColor = System.Drawing.Color.Gainsboro;
            this.ToppingImageBox.InitialImage = global::MomsAndPopsPizzaria.Properties.Resources.Pepperoni;
            this.ToppingImageBox.Location = new System.Drawing.Point(4, 4);
            this.ToppingImageBox.Name = "ToppingImageBox";
            this.ToppingImageBox.Size = new System.Drawing.Size(127, 127);
            this.ToppingImageBox.TabIndex = 0;
            this.ToppingImageBox.TabStop = false;
            // 
            // TemplatePizzaTopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToppingImageBox);
            this.Name = "TemplatePizzaTopping";
            this.Size = new System.Drawing.Size(300, 134);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToppingImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ToppingImageBox;
        private System.Windows.Forms.CheckBox ToppingExtraCheckBox;
        private System.Windows.Forms.CheckBox ToppingCheckBox;
        private System.Windows.Forms.Panel panel1;
    }
}
