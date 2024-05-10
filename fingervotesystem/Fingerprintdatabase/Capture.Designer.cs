namespace Fingerprintdatabase
{
    partial class Capture
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
            this.components = new System.ComponentModel.Container();
            this.fImage = new System.Windows.Forms.PictureBox();
            this.Prompt = new System.Windows.Forms.TextBox();
            this.statustext = new System.Windows.Forms.TextBox();
            this.statuslabel = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.startscan = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fImage)).BeginInit();
            this.SuspendLayout();
            // 
            // fImage
            // 
            this.fImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fImage.Location = new System.Drawing.Point(29, 21);
            this.fImage.Name = "fImage";
            this.fImage.Size = new System.Drawing.Size(208, 217);
            this.fImage.TabIndex = 0;
            this.fImage.TabStop = false;
            // 
            // Prompt
            // 
            this.Prompt.BackColor = System.Drawing.SystemColors.Control;
            this.Prompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Prompt.Location = new System.Drawing.Point(252, 21);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(250, 13);
            this.Prompt.TabIndex = 1;
            // 
            // statustext
            // 
            this.statustext.Location = new System.Drawing.Point(252, 40);
            this.statustext.Multiline = true;
            this.statustext.Name = "statustext";
            this.statustext.Size = new System.Drawing.Size(250, 198);
            this.statustext.TabIndex = 2;
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Location = new System.Drawing.Point(26, 263);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(37, 13);
            this.statuslabel.TabIndex = 3;
            this.statuslabel.Text = "Status";
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(252, 244);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(204, 20);
            this.firstname.TabIndex = 4;
            this.firstname.TextChanged += new System.EventHandler(this.Firstname_TextChanged);
            // 
            // startscan
            // 
            this.startscan.Location = new System.Drawing.Point(426, 270);
            this.startscan.Name = "startscan";
            this.startscan.Size = new System.Drawing.Size(67, 20);
            this.startscan.TabIndex = 5;
            this.startscan.Text = "Start Scan";
            this.startscan.UseVisualStyleBackColor = true;
            this.startscan.Click += new System.EventHandler(this.Startscan_Click);
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Capture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 302);
            this.Controls.Add(this.startscan);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.statustext);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.fImage);
            this.Name = "Capture";
            this.Text = ".";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Capture_FormClosing);
            this.Load += new System.EventHandler(this.Capture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fImage;
        private System.Windows.Forms.TextBox Prompt;
        private System.Windows.Forms.TextBox statustext;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Button startscan;
        private System.Windows.Forms.Timer Timer1;
    }
}