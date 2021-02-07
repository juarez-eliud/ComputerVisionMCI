
namespace ComputerVisionMCI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.hostTxt = new System.Windows.Forms.TextBox();
            this.hostLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.remoteSiteTxt = new System.Windows.Forms.TextBox();
            this.remoteSiteLbl = new System.Windows.Forms.Label();
            this.localSiteTxt = new System.Windows.Forms.TextBox();
            this.localSiteLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordTxt);
            this.groupBox1.Controls.Add(this.passwordLbl);
            this.groupBox1.Controls.Add(this.usernameTxt);
            this.groupBox1.Controls.Add(this.usernameLbl);
            this.groupBox1.Controls.Add(this.hostTxt);
            this.groupBox1.Controls.Add(this.hostLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1139, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTP Settings";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(691, 32);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(173, 22);
            this.passwordTxt.TabIndex = 5;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(614, 33);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(73, 17);
            this.passwordLbl.TabIndex = 4;
            this.passwordLbl.Text = "Password:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(413, 32);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(172, 22);
            this.usernameTxt.TabIndex = 4;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(331, 34);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(77, 17);
            this.usernameLbl.TabIndex = 3;
            this.usernameLbl.Text = "Username:";
            // 
            // hostTxt
            // 
            this.hostTxt.Location = new System.Drawing.Point(64, 33);
            this.hostTxt.Name = "hostTxt";
            this.hostTxt.Size = new System.Drawing.Size(237, 22);
            this.hostTxt.TabIndex = 2;
            // 
            // hostLbl
            // 
            this.hostLbl.AutoSize = true;
            this.hostLbl.Location = new System.Drawing.Point(18, 34);
            this.hostLbl.Name = "hostLbl";
            this.hostLbl.Size = new System.Drawing.Size(41, 17);
            this.hostLbl.TabIndex = 1;
            this.hostLbl.Text = "Host:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.remoteSiteTxt);
            this.groupBox2.Controls.Add(this.remoteSiteLbl);
            this.groupBox2.Controls.Add(this.localSiteTxt);
            this.groupBox2.Controls.Add(this.localSiteLbl);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1139, 77);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paths";
            // 
            // remoteSiteTxt
            // 
            this.remoteSiteTxt.Location = new System.Drawing.Point(112, 31);
            this.remoteSiteTxt.Name = "remoteSiteTxt";
            this.remoteSiteTxt.Size = new System.Drawing.Size(318, 22);
            this.remoteSiteTxt.TabIndex = 8;
            // 
            // remoteSiteLbl
            // 
            this.remoteSiteLbl.AutoSize = true;
            this.remoteSiteLbl.Location = new System.Drawing.Point(17, 33);
            this.remoteSiteLbl.Name = "remoteSiteLbl";
            this.remoteSiteLbl.Size = new System.Drawing.Size(89, 17);
            this.remoteSiteLbl.TabIndex = 7;
            this.remoteSiteLbl.Text = "Remote Site:";
            // 
            // localSiteTxt
            // 
            this.localSiteTxt.Location = new System.Drawing.Point(546, 31);
            this.localSiteTxt.Name = "localSiteTxt";
            this.localSiteTxt.Size = new System.Drawing.Size(318, 22);
            this.localSiteTxt.TabIndex = 10;
            // 
            // localSiteLbl
            // 
            this.localSiteLbl.AutoSize = true;
            this.localSiteLbl.Location = new System.Drawing.Point(468, 33);
            this.localSiteLbl.Name = "localSiteLbl";
            this.localSiteLbl.Size = new System.Drawing.Size(74, 17);
            this.localSiteLbl.TabIndex = 9;
            this.localSiteLbl.Text = "Local Site:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox hostTxt;
        private System.Windows.Forms.Label hostLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox remoteSiteTxt;
        private System.Windows.Forms.Label remoteSiteLbl;
        private System.Windows.Forms.TextBox localSiteTxt;
        private System.Windows.Forms.Label localSiteLbl;
    }
}

