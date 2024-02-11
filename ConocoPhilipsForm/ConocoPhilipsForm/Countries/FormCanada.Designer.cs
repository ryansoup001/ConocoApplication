namespace ConocoPhilipsForm
{
    partial class FormCanada
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
            pixCanada = new PictureBox();
            canadaTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pixCanada).BeginInit();
            SuspendLayout();
            // 
            // pixCanada
            // 
            pixCanada.Image = Properties.Resources.conocoGlobe;
            pixCanada.Location = new Point(-3, 0);
            pixCanada.Name = "pixCanada";
            pixCanada.Size = new Size(1704, 824);
            pixCanada.SizeMode = PictureBoxSizeMode.StretchImage;
            pixCanada.TabIndex = 0;
            pixCanada.TabStop = false;
            // 
            // canadaTxt
            // 
            canadaTxt.BackColor = SystemColors.ActiveCaption;
            canadaTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            canadaTxt.Location = new Point(255, 219);
            canadaTxt.Multiline = true;
            canadaTxt.Name = "canadaTxt";
            canadaTxt.Size = new Size(314, 215);
            canadaTxt.TabIndex = 1;
            canadaTxt.Text = "2 million ppm";
            // 
            // FormCanada
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1701, 825);
            Controls.Add(canadaTxt);
            Controls.Add(pixCanada);
            Name = "FormCanada";
            Text = "FormCanada";
            ((System.ComponentModel.ISupportInitialize)pixCanada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pixCanada;
        private TextBox canadaTxt;
    }
}