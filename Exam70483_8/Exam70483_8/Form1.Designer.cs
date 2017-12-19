namespace Exam70483_8
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
            this.uriTxtb = new System.Windows.Forms.TextBox();
            this.htmlLbl = new System.Windows.Forms.Label();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uriTxtb
            // 
            this.uriTxtb.Location = new System.Drawing.Point(37, 40);
            this.uriTxtb.Name = "uriTxtb";
            this.uriTxtb.Size = new System.Drawing.Size(219, 20);
            this.uriTxtb.TabIndex = 0;
            this.uriTxtb.Text = "https://www.google.com";
            // 
            // htmlLbl
            // 
            this.htmlLbl.AutoEllipsis = true;
            this.htmlLbl.AutoSize = true;
            this.htmlLbl.Location = new System.Drawing.Point(46, 143);
            this.htmlLbl.Name = "htmlLbl";
            this.htmlLbl.Size = new System.Drawing.Size(64, 13);
            this.htmlLbl.TabIndex = 1;
            this.htmlLbl.Text = "Displaying...";
            // 
            // downloadBtn
            // 
            this.downloadBtn.AutoSize = true;
            this.downloadBtn.Location = new System.Drawing.Point(95, 92);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(98, 23);
            this.downloadBtn.TabIndex = 2;
            this.downloadBtn.Text = "Download HTML";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.htmlLbl);
            this.Controls.Add(this.uriTxtb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uriTxtb;
        private System.Windows.Forms.Label htmlLbl;
        private System.Windows.Forms.Button downloadBtn;
    }
}

