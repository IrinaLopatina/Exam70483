namespace Exam70483_13
{
    partial class Login
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNamelabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.Controls.Add(this.passwordText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.userNameText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.passwordLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.userNamelabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.loginButton, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(230, 116);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // passwordText
            // 
            this.passwordText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordText.Location = new System.Drawing.Point(94, 39);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(133, 20);
            this.passwordText.TabIndex = 1;
            // 
            // userNameText
            // 
            this.userNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameText.Location = new System.Drawing.Point(94, 3);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(133, 20);
            this.userNameText.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordLabel.Location = new System.Drawing.Point(3, 36);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(85, 40);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userNamelabel
            // 
            this.userNamelabel.AutoSize = true;
            this.userNamelabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNamelabel.Location = new System.Drawing.Point(3, 0);
            this.userNamelabel.Name = "userNamelabel";
            this.userNamelabel.Size = new System.Drawing.Size(85, 36);
            this.userNamelabel.TabIndex = 0;
            this.userNamelabel.Text = "User name";
            this.userNamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginButton
            // 
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginButton.Location = new System.Drawing.Point(94, 79);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(133, 34);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Login";
            this.Text = "Login";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label userNamelabel;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button loginButton;
    }
}