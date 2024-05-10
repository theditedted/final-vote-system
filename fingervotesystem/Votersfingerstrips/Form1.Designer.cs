namespace Votersfingerstrips
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
            this.Enroll_btn = new System.Windows.Forms.Button();
            this.Verify_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enroll_btn
            // 
            this.Enroll_btn.Location = new System.Drawing.Point(260, 70);
            this.Enroll_btn.Name = "Enroll_btn";
            this.Enroll_btn.Size = new System.Drawing.Size(235, 111);
            this.Enroll_btn.TabIndex = 0;
            this.Enroll_btn.Text = "Enroll";
            this.Enroll_btn.UseVisualStyleBackColor = true;
            this.Enroll_btn.Click += new System.EventHandler(this.Enroll_btn_Click);
            // 
            // Verify_btn
            // 
            this.Verify_btn.Location = new System.Drawing.Point(260, 187);
            this.Verify_btn.Name = "Verify_btn";
            this.Verify_btn.Size = new System.Drawing.Size(235, 104);
            this.Verify_btn.TabIndex = 1;
            this.Verify_btn.Text = "Verification";
            this.Verify_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Verify_btn);
            this.Controls.Add(this.Enroll_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Enroll_btn;
        private System.Windows.Forms.Button Verify_btn;
    }
}

