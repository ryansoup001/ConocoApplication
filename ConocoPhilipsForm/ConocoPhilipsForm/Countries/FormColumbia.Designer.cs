namespace ConocoPhilipsForm.Countries
{
    partial class FormColumbia
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
            pixColumbia = new PictureBox();
            columbiaTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pixColumbia).BeginInit();
            SuspendLayout();
            // 
            // pixColumbia
            // 
            pixColumbia.Image = Properties.Resources.conocoGlobe;
            pixColumbia.Location = new Point(2, 6);
            pixColumbia.Name = "pixColumbia";
            pixColumbia.Size = new Size(1750, 728);
            pixColumbia.SizeMode = PictureBoxSizeMode.StretchImage;
            pixColumbia.TabIndex = 0;
            pixColumbia.TabStop = false;
            // 
            // columbiaTxt
            // 
            columbiaTxt.BackColor = SystemColors.ActiveCaption;
            columbiaTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            columbiaTxt.Location = new Point(271, 212);
            columbiaTxt.Multiline = true;
            columbiaTxt.Name = "columbiaTxt";
            columbiaTxt.Size = new Size(473, 185);
            columbiaTxt.TabIndex = 1;
            columbiaTxt.Text = "5 million ppm";
            // 
            // FormColumbia
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 733);
            Controls.Add(columbiaTxt);
            Controls.Add(pixColumbia);
            Name = "FormColumbia";
            Text = "FormColumbia";
            ((System.ComponentModel.ISupportInitialize)pixColumbia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pixColumbia;
        private TextBox columbiaTxt;
    }
}