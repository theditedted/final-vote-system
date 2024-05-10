namespace Fingerprint_form
{
    partial class Form1
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
            this.StatusText = new System.Windows.Forms.Label();
            this.fImage = new System.Windows.Forms.PictureBox();
            this.Button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fImage)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Location = new System.Drawing.Point(12, 248);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(35, 13);
            this.StatusText.TabIndex = 0;
            this.StatusText.Text = "label1";
            // 
            // fImage
            // 
            this.fImage.Location = new System.Drawing.Point(12, 32);
            this.fImage.Name = "fImage";
            this.fImage.Size = new System.Drawing.Size(273, 155);
            this.fImage.TabIndex = 2;
            this.fImage.TabStop = false;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(204, 226);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(81, 24);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Start Capture";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 326);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.fImage);
            this.Controls.Add(this.StatusText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.PictureBox fImage;
        private System.Windows.Forms.Button Button1;
    }
}

