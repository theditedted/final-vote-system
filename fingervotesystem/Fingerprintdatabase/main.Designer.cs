using System;
using System.Drawing.Text;

namespace Fingerprintdatabase
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private void Form1_Load(object sender,EventArgs e)
        {
            this.Load += new System.EventHandler(this.Form1_Load);
        }

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
            this.Ver_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enroll_btn
            // 
            this.Enroll_btn.Location = new System.Drawing.Point(171, 43);
            this.Enroll_btn.Name = "Enroll_btn";
            this.Enroll_btn.Size = new System.Drawing.Size(238, 82);
            this.Enroll_btn.TabIndex = 0;
            this.Enroll_btn.Text = "Registration";
            this.Enroll_btn.UseVisualStyleBackColor = true;
            this.Enroll_btn.Click += new System.EventHandler(this.Enroll_btn_Click);
            // 
            // Ver_btn
            // 
            this.Ver_btn.Location = new System.Drawing.Point(171, 140);
            this.Ver_btn.Name = "Ver_btn";
            this.Ver_btn.Size = new System.Drawing.Size(238, 79);
            this.Ver_btn.TabIndex = 1;
            this.Ver_btn.Text = "Verification";
            this.Ver_btn.UseVisualStyleBackColor = true;
            this.Ver_btn.Click += new System.EventHandler(this.Ver_btn_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 298);
            this.Controls.Add(this.Ver_btn);
            this.Controls.Add(this.Enroll_btn);
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Enroll_btn;
        private System.Windows.Forms.Button Ver_btn;
    }
}

