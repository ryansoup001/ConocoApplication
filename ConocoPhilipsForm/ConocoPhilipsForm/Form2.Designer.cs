namespace ConocoPhilipsForm
{
    partial class Form2
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
            pix1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pix1).BeginInit();
            SuspendLayout();
            // 
            // pix1
            // 
            pix1.Image = Properties.Resources.conocoGlobe;
            pix1.Location = new Point(2, 0);
            pix1.Name = "pix1";
            pix1.Size = new Size(1737, 818);
            pix1.SizeMode = PictureBoxSizeMode.StretchImage;
            pix1.TabIndex = 0;
            pix1.TabStop = false;
            pix1.Click += pix1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1747, 823);
            Controls.Add(pix1);
            Name = "Form2";
            Text = "ConocoPhillips Global Map";
            ((System.ComponentModel.ISupportInitialize)pix1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pix1;
    }
}