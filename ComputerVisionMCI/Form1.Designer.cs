
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
            this.sourceTxt = new System.Windows.Forms.TextBox();
            this.remoteSiteLbl = new System.Windows.Forms.Label();
            this.targetTxt = new System.Windows.Forms.TextBox();
            this.localSiteLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.searchImageBtn = new System.Windows.Forms.Button();
            this.dataGridViewImages = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.activityTxt = new System.Windows.Forms.TextBox();
            this.imageSearchTxt = new System.Windows.Forms.TextBox();
            this.imageNameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.strFromPLCTxt = new System.Windows.Forms.TextBox();
            this.stringPLCLbl = new System.Windows.Forms.Label();
            this.setFTPConfBtn = new System.Windows.Forms.Button();
            this.portLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImages)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.portLbl);
            this.groupBox1.Controls.Add(this.setFTPConfBtn);
            this.groupBox1.Controls.Add(this.passwordTxt);
            this.groupBox1.Controls.Add(this.passwordLbl);
            this.groupBox1.Controls.Add(this.usernameTxt);
            this.groupBox1.Controls.Add(this.usernameLbl);
            this.groupBox1.Controls.Add(this.hostTxt);
            this.groupBox1.Controls.Add(this.hostLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTP Settings";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(553, 32);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(122, 22);
            this.passwordTxt.TabIndex = 5;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(476, 33);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(73, 17);
            this.passwordLbl.TabIndex = 4;
            this.passwordLbl.Text = "Password:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(288, 32);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(142, 22);
            this.usernameTxt.TabIndex = 4;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(206, 34);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(77, 17);
            this.usernameLbl.TabIndex = 3;
            this.usernameLbl.Text = "Username:";
            // 
            // hostTxt
            // 
            this.hostTxt.Location = new System.Drawing.Point(64, 33);
            this.hostTxt.Name = "hostTxt";
            this.hostTxt.Size = new System.Drawing.Size(122, 22);
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
            this.groupBox2.Controls.Add(this.sourceTxt);
            this.groupBox2.Controls.Add(this.remoteSiteLbl);
            this.groupBox2.Controls.Add(this.targetTxt);
            this.groupBox2.Controls.Add(this.localSiteLbl);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(893, 77);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paths";
            // 
            // sourceTxt
            // 
            this.sourceTxt.Location = new System.Drawing.Point(112, 31);
            this.sourceTxt.Name = "sourceTxt";
            this.sourceTxt.Size = new System.Drawing.Size(318, 22);
            this.sourceTxt.TabIndex = 8;
            // 
            // remoteSiteLbl
            // 
            this.remoteSiteLbl.AutoSize = true;
            this.remoteSiteLbl.Location = new System.Drawing.Point(17, 33);
            this.remoteSiteLbl.Name = "remoteSiteLbl";
            this.remoteSiteLbl.Size = new System.Drawing.Size(57, 17);
            this.remoteSiteLbl.TabIndex = 7;
            this.remoteSiteLbl.Text = "Source:";
            // 
            // targetTxt
            // 
            this.targetTxt.Location = new System.Drawing.Point(546, 31);
            this.targetTxt.Name = "targetTxt";
            this.targetTxt.Size = new System.Drawing.Size(318, 22);
            this.targetTxt.TabIndex = 10;
            // 
            // localSiteLbl
            // 
            this.localSiteLbl.AutoSize = true;
            this.localSiteLbl.Location = new System.Drawing.Point(468, 33);
            this.localSiteLbl.Name = "localSiteLbl";
            this.localSiteLbl.Size = new System.Drawing.Size(54, 17);
            this.localSiteLbl.TabIndex = 9;
            this.localSiteLbl.Text = "Target:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.searchImageBtn);
            this.groupBox3.Controls.Add(this.dataGridViewImages);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.activityTxt);
            this.groupBox3.Controls.Add(this.imageSearchTxt);
            this.groupBox3.Controls.Add(this.imageNameLbl);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.strFromPLCTxt);
            this.groupBox3.Controls.Add(this.stringPLCLbl);
            this.groupBox3.Location = new System.Drawing.Point(12, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(893, 431);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // searchImageBtn
            // 
            this.searchImageBtn.Location = new System.Drawing.Point(798, 33);
            this.searchImageBtn.Name = "searchImageBtn";
            this.searchImageBtn.Size = new System.Drawing.Size(75, 33);
            this.searchImageBtn.TabIndex = 9;
            this.searchImageBtn.Text = "Search";
            this.searchImageBtn.UseVisualStyleBackColor = true;
            this.searchImageBtn.Click += new System.EventHandler(this.searchImageBtn_Click);
            // 
            // dataGridViewImages
            // 
            this.dataGridViewImages.AllowUserToAddRows = false;
            this.dataGridViewImages.AllowUserToDeleteRows = false;
            this.dataGridViewImages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImages.Location = new System.Drawing.Point(475, 74);
            this.dataGridViewImages.Name = "dataGridViewImages";
            this.dataGridViewImages.ReadOnly = true;
            this.dataGridViewImages.RowHeadersVisible = false;
            this.dataGridViewImages.RowHeadersWidth = 51;
            this.dataGridViewImages.RowTemplate.Height = 24;
            this.dataGridViewImages.Size = new System.Drawing.Size(398, 326);
            this.dataGridViewImages.TabIndex = 8;
            this.dataGridViewImages.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewImages_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Activity logs:";
            // 
            // activityTxt
            // 
            this.activityTxt.Location = new System.Drawing.Point(18, 141);
            this.activityTxt.Multiline = true;
            this.activityTxt.Name = "activityTxt";
            this.activityTxt.Size = new System.Drawing.Size(412, 259);
            this.activityTxt.TabIndex = 6;
            // 
            // imageSearchTxt
            // 
            this.imageSearchTxt.Location = new System.Drawing.Point(569, 38);
            this.imageSearchTxt.Name = "imageSearchTxt";
            this.imageSearchTxt.Size = new System.Drawing.Size(217, 22);
            this.imageSearchTxt.TabIndex = 5;
            // 
            // imageNameLbl
            // 
            this.imageNameLbl.AutoSize = true;
            this.imageNameLbl.Location = new System.Drawing.Point(472, 40);
            this.imageNameLbl.Name = "imageNameLbl";
            this.imageNameLbl.Size = new System.Drawing.Size(91, 17);
            this.imageNameLbl.TabIndex = 4;
            this.imageNameLbl.Text = "Image Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "✓";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connection status:";
            // 
            // strFromPLCTxt
            // 
            this.strFromPLCTxt.Location = new System.Drawing.Point(135, 72);
            this.strFromPLCTxt.Name = "strFromPLCTxt";
            this.strFromPLCTxt.Size = new System.Drawing.Size(295, 22);
            this.strFromPLCTxt.TabIndex = 1;
            // 
            // stringPLCLbl
            // 
            this.stringPLCLbl.AutoSize = true;
            this.stringPLCLbl.Location = new System.Drawing.Point(18, 74);
            this.stringPLCLbl.Name = "stringPLCLbl";
            this.stringPLCLbl.Size = new System.Drawing.Size(111, 17);
            this.stringPLCLbl.TabIndex = 0;
            this.stringPLCLbl.Text = "String from PLC:";
            // 
            // setFTPConfBtn
            // 
            this.setFTPConfBtn.Location = new System.Drawing.Point(798, 28);
            this.setFTPConfBtn.Name = "setFTPConfBtn";
            this.setFTPConfBtn.Size = new System.Drawing.Size(75, 33);
            this.setFTPConfBtn.TabIndex = 6;
            this.setFTPConfBtn.Text = "Set";
            this.setFTPConfBtn.UseVisualStyleBackColor = true;
            // 
            // portLbl
            // 
            this.portLbl.AutoSize = true;
            this.portLbl.Location = new System.Drawing.Point(696, 36);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(38, 17);
            this.portLbl.TabIndex = 7;
            this.portLbl.Text = "Port:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(741, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 22);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 722);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImages)).EndInit();
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
        private System.Windows.Forms.TextBox sourceTxt;
        private System.Windows.Forms.Label remoteSiteLbl;
        private System.Windows.Forms.TextBox targetTxt;
        private System.Windows.Forms.Label localSiteLbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox strFromPLCTxt;
        private System.Windows.Forms.Label stringPLCLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imageSearchTxt;
        private System.Windows.Forms.Label imageNameLbl;
        private System.Windows.Forms.TextBox activityTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewImages;
        private System.Windows.Forms.Button searchImageBtn;
        private System.Windows.Forms.Button setFTPConfBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label portLbl;
    }
}

