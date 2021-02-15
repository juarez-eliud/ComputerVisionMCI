
namespace ComputerVisionMCI
{
    partial class Tesla3
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
            this.ftpGbx = new System.Windows.Forms.GroupBox();
            this.portFTPTxt = new System.Windows.Forms.TextBox();
            this.portLbl = new System.Windows.Forms.Label();
            this.updateFTPConfBtn = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.hostTxt = new System.Windows.Forms.TextBox();
            this.hostLbl = new System.Windows.Forms.Label();
            this.pathsGbx = new System.Windows.Forms.GroupBox();
            this.defaultImgTxt = new System.Windows.Forms.TextBox();
            this.defaultImgLbl = new System.Windows.Forms.Label();
            this.updatePathsConfBtn = new System.Windows.Forms.Button();
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
            this.statusLbl = new System.Windows.Forms.Label();
            this.connStatusLbl = new System.Windows.Forms.Label();
            this.strFromPLCTxt = new System.Windows.Forms.TextBox();
            this.stringPLCLbl = new System.Windows.Forms.Label();
            this.mciLogoPbx = new System.Windows.Forms.PictureBox();
            this.tesla3Lbl = new System.Windows.Forms.Label();
            this.plcGbx = new System.Windows.Forms.GroupBox();
            this.updatePLCConfBtn = new System.Windows.Forms.Button();
            this.slotTxt = new System.Windows.Forms.TextBox();
            this.slotLbl = new System.Windows.Forms.Label();
            this.rackTxt = new System.Windows.Forms.TextBox();
            this.rackLbl = new System.Windows.Forms.Label();
            this.portPLCTxt = new System.Windows.Forms.TextBox();
            this.portPLCLbl = new System.Windows.Forms.Label();
            this.ipTxt = new System.Windows.Forms.TextBox();
            this.ipLbl = new System.Windows.Forms.Label();
            this.ftpGbx.SuspendLayout();
            this.pathsGbx.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mciLogoPbx)).BeginInit();
            this.plcGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // ftpGbx
            // 
            this.ftpGbx.Controls.Add(this.portFTPTxt);
            this.ftpGbx.Controls.Add(this.portLbl);
            this.ftpGbx.Controls.Add(this.updateFTPConfBtn);
            this.ftpGbx.Controls.Add(this.passwordTxt);
            this.ftpGbx.Controls.Add(this.passwordLbl);
            this.ftpGbx.Controls.Add(this.usernameTxt);
            this.ftpGbx.Controls.Add(this.usernameLbl);
            this.ftpGbx.Controls.Add(this.hostTxt);
            this.ftpGbx.Controls.Add(this.hostLbl);
            this.ftpGbx.Location = new System.Drawing.Point(12, 185);
            this.ftpGbx.Name = "ftpGbx";
            this.ftpGbx.Size = new System.Drawing.Size(893, 72);
            this.ftpGbx.TabIndex = 0;
            this.ftpGbx.TabStop = false;
            this.ftpGbx.Text = "FTP";
            // 
            // portFTPTxt
            // 
            this.portFTPTxt.Location = new System.Drawing.Point(712, 27);
            this.portFTPTxt.Name = "portFTPTxt";
            this.portFTPTxt.Size = new System.Drawing.Size(60, 22);
            this.portFTPTxt.TabIndex = 8;
            // 
            // portLbl
            // 
            this.portLbl.AutoSize = true;
            this.portLbl.Location = new System.Drawing.Point(667, 32);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(38, 17);
            this.portLbl.TabIndex = 7;
            this.portLbl.Text = "Port:";
            // 
            // updateFTPConfBtn
            // 
            this.updateFTPConfBtn.Location = new System.Drawing.Point(798, 24);
            this.updateFTPConfBtn.Name = "updateFTPConfBtn";
            this.updateFTPConfBtn.Size = new System.Drawing.Size(75, 33);
            this.updateFTPConfBtn.TabIndex = 6;
            this.updateFTPConfBtn.Text = "Update";
            this.updateFTPConfBtn.UseVisualStyleBackColor = true;
            this.updateFTPConfBtn.Click += new System.EventHandler(this.updateFTPConfBtn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(506, 27);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(122, 22);
            this.passwordTxt.TabIndex = 5;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(429, 29);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(73, 17);
            this.passwordLbl.TabIndex = 4;
            this.passwordLbl.Text = "Password:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(257, 27);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(142, 22);
            this.usernameTxt.TabIndex = 4;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(209, 30);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(42, 17);
            this.usernameLbl.TabIndex = 3;
            this.usernameLbl.Text = "User:";
            // 
            // hostTxt
            // 
            this.hostTxt.Location = new System.Drawing.Point(64, 27);
            this.hostTxt.Name = "hostTxt";
            this.hostTxt.Size = new System.Drawing.Size(122, 22);
            this.hostTxt.TabIndex = 2;
            // 
            // hostLbl
            // 
            this.hostLbl.AutoSize = true;
            this.hostLbl.Location = new System.Drawing.Point(18, 30);
            this.hostLbl.Name = "hostLbl";
            this.hostLbl.Size = new System.Drawing.Size(41, 17);
            this.hostLbl.TabIndex = 1;
            this.hostLbl.Text = "Host:";
            // 
            // pathsGbx
            // 
            this.pathsGbx.Controls.Add(this.defaultImgTxt);
            this.pathsGbx.Controls.Add(this.defaultImgLbl);
            this.pathsGbx.Controls.Add(this.updatePathsConfBtn);
            this.pathsGbx.Controls.Add(this.sourceTxt);
            this.pathsGbx.Controls.Add(this.remoteSiteLbl);
            this.pathsGbx.Controls.Add(this.targetTxt);
            this.pathsGbx.Controls.Add(this.localSiteLbl);
            this.pathsGbx.Location = new System.Drawing.Point(12, 281);
            this.pathsGbx.Name = "pathsGbx";
            this.pathsGbx.Size = new System.Drawing.Size(893, 72);
            this.pathsGbx.TabIndex = 6;
            this.pathsGbx.TabStop = false;
            this.pathsGbx.Text = "Paths";
            // 
            // defaultImgTxt
            // 
            this.defaultImgTxt.Location = new System.Drawing.Point(122, 26);
            this.defaultImgTxt.Name = "defaultImgTxt";
            this.defaultImgTxt.Size = new System.Drawing.Size(102, 22);
            this.defaultImgTxt.TabIndex = 12;
            // 
            // defaultImgLbl
            // 
            this.defaultImgLbl.AutoSize = true;
            this.defaultImgLbl.Location = new System.Drawing.Point(17, 29);
            this.defaultImgLbl.Name = "defaultImgLbl";
            this.defaultImgLbl.Size = new System.Drawing.Size(99, 17);
            this.defaultImgLbl.TabIndex = 11;
            this.defaultImgLbl.Text = "Default image:";
            // 
            // updatePathsConfBtn
            // 
            this.updatePathsConfBtn.Location = new System.Drawing.Point(798, 20);
            this.updatePathsConfBtn.Name = "updatePathsConfBtn";
            this.updatePathsConfBtn.Size = new System.Drawing.Size(75, 33);
            this.updatePathsConfBtn.TabIndex = 9;
            this.updatePathsConfBtn.Text = "Update";
            this.updatePathsConfBtn.UseVisualStyleBackColor = true;
            this.updatePathsConfBtn.Click += new System.EventHandler(this.updatePathsConfBtn_Click);
            // 
            // sourceTxt
            // 
            this.sourceTxt.Location = new System.Drawing.Point(314, 26);
            this.sourceTxt.Name = "sourceTxt";
            this.sourceTxt.Size = new System.Drawing.Size(116, 22);
            this.sourceTxt.TabIndex = 8;
            // 
            // remoteSiteLbl
            // 
            this.remoteSiteLbl.AutoSize = true;
            this.remoteSiteLbl.Location = new System.Drawing.Point(251, 31);
            this.remoteSiteLbl.Name = "remoteSiteLbl";
            this.remoteSiteLbl.Size = new System.Drawing.Size(57, 17);
            this.remoteSiteLbl.TabIndex = 7;
            this.remoteSiteLbl.Text = "Source:";
            // 
            // targetTxt
            // 
            this.targetTxt.Location = new System.Drawing.Point(526, 26);
            this.targetTxt.Name = "targetTxt";
            this.targetTxt.Size = new System.Drawing.Size(246, 22);
            this.targetTxt.TabIndex = 10;
            // 
            // localSiteLbl
            // 
            this.localSiteLbl.AutoSize = true;
            this.localSiteLbl.Location = new System.Drawing.Point(467, 30);
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
            this.groupBox3.Controls.Add(this.statusLbl);
            this.groupBox3.Controls.Add(this.connStatusLbl);
            this.groupBox3.Controls.Add(this.strFromPLCTxt);
            this.groupBox3.Controls.Add(this.stringPLCLbl);
            this.groupBox3.Location = new System.Drawing.Point(12, 372);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(893, 347);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PLC";
            // 
            // searchImageBtn
            // 
            this.searchImageBtn.Location = new System.Drawing.Point(798, 29);
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
            this.dataGridViewImages.Location = new System.Drawing.Point(526, 70);
            this.dataGridViewImages.Name = "dataGridViewImages";
            this.dataGridViewImages.ReadOnly = true;
            this.dataGridViewImages.RowHeadersVisible = false;
            this.dataGridViewImages.RowHeadersWidth = 51;
            this.dataGridViewImages.RowTemplate.Height = 24;
            this.dataGridViewImages.Size = new System.Drawing.Size(347, 242);
            this.dataGridViewImages.TabIndex = 8;
            this.dataGridViewImages.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewImages_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Activity logs:";
            // 
            // activityTxt
            // 
            this.activityTxt.Location = new System.Drawing.Point(18, 137);
            this.activityTxt.Multiline = true;
            this.activityTxt.Name = "activityTxt";
            this.activityTxt.Size = new System.Drawing.Size(467, 175);
            this.activityTxt.TabIndex = 6;
            // 
            // imageSearchTxt
            // 
            this.imageSearchTxt.Location = new System.Drawing.Point(622, 34);
            this.imageSearchTxt.Name = "imageSearchTxt";
            this.imageSearchTxt.Size = new System.Drawing.Size(150, 22);
            this.imageSearchTxt.TabIndex = 5;
            // 
            // imageNameLbl
            // 
            this.imageNameLbl.AutoSize = true;
            this.imageNameLbl.Location = new System.Drawing.Point(525, 36);
            this.imageNameLbl.Name = "imageNameLbl";
            this.imageNameLbl.Size = new System.Drawing.Size(91, 17);
            this.imageNameLbl.TabIndex = 4;
            this.imageNameLbl.Text = "Image Name:";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Location = new System.Drawing.Point(73, 33);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(51, 18);
            this.statusLbl.TabIndex = 3;
            this.statusLbl.Text = "status";
            // 
            // connStatusLbl
            // 
            this.connStatusLbl.AutoSize = true;
            this.connStatusLbl.Location = new System.Drawing.Point(18, 34);
            this.connStatusLbl.Name = "connStatusLbl";
            this.connStatusLbl.Size = new System.Drawing.Size(52, 17);
            this.connStatusLbl.TabIndex = 2;
            this.connStatusLbl.Text = "Status:";
            // 
            // strFromPLCTxt
            // 
            this.strFromPLCTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strFromPLCTxt.Location = new System.Drawing.Point(135, 68);
            this.strFromPLCTxt.Name = "strFromPLCTxt";
            this.strFromPLCTxt.Size = new System.Drawing.Size(350, 24);
            this.strFromPLCTxt.TabIndex = 1;
            // 
            // stringPLCLbl
            // 
            this.stringPLCLbl.AutoSize = true;
            this.stringPLCLbl.Location = new System.Drawing.Point(18, 70);
            this.stringPLCLbl.Name = "stringPLCLbl";
            this.stringPLCLbl.Size = new System.Drawing.Size(111, 17);
            this.stringPLCLbl.TabIndex = 0;
            this.stringPLCLbl.Text = "String from PLC:";
            // 
            // mciLogoPbx
            // 
            this.mciLogoPbx.Image = global::ComputerVisionMCI.Properties.Resources.MCI_logo_50_blanco;
            this.mciLogoPbx.Location = new System.Drawing.Point(12, 12);
            this.mciLogoPbx.Name = "mciLogoPbx";
            this.mciLogoPbx.Size = new System.Drawing.Size(247, 66);
            this.mciLogoPbx.TabIndex = 8;
            this.mciLogoPbx.TabStop = false;
            // 
            // tesla3Lbl
            // 
            this.tesla3Lbl.AutoSize = true;
            this.tesla3Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tesla3Lbl.Location = new System.Drawing.Point(282, 12);
            this.tesla3Lbl.Name = "tesla3Lbl";
            this.tesla3Lbl.Size = new System.Drawing.Size(177, 44);
            this.tesla3Lbl.TabIndex = 9;
            this.tesla3Lbl.Text = "TESLA 3";
            // 
            // plcGbx
            // 
            this.plcGbx.Controls.Add(this.updatePLCConfBtn);
            this.plcGbx.Controls.Add(this.slotTxt);
            this.plcGbx.Controls.Add(this.slotLbl);
            this.plcGbx.Controls.Add(this.rackTxt);
            this.plcGbx.Controls.Add(this.rackLbl);
            this.plcGbx.Controls.Add(this.portPLCTxt);
            this.plcGbx.Controls.Add(this.portPLCLbl);
            this.plcGbx.Controls.Add(this.ipTxt);
            this.plcGbx.Controls.Add(this.ipLbl);
            this.plcGbx.Location = new System.Drawing.Point(12, 91);
            this.plcGbx.Name = "plcGbx";
            this.plcGbx.Size = new System.Drawing.Size(893, 72);
            this.plcGbx.TabIndex = 10;
            this.plcGbx.TabStop = false;
            this.plcGbx.Text = "PLC";
            // 
            // updatePLCConfBtn
            // 
            this.updatePLCConfBtn.Location = new System.Drawing.Point(798, 20);
            this.updatePLCConfBtn.Name = "updatePLCConfBtn";
            this.updatePLCConfBtn.Size = new System.Drawing.Size(75, 33);
            this.updatePLCConfBtn.TabIndex = 9;
            this.updatePLCConfBtn.Text = "Update";
            this.updatePLCConfBtn.UseVisualStyleBackColor = true;
            this.updatePLCConfBtn.Click += new System.EventHandler(this.updatePLCConfBtn_Click);
            // 
            // slotTxt
            // 
            this.slotTxt.Location = new System.Drawing.Point(529, 24);
            this.slotTxt.Name = "slotTxt";
            this.slotTxt.Size = new System.Drawing.Size(60, 22);
            this.slotTxt.TabIndex = 7;
            // 
            // slotLbl
            // 
            this.slotLbl.AutoSize = true;
            this.slotLbl.Location = new System.Drawing.Point(486, 27);
            this.slotLbl.Name = "slotLbl";
            this.slotLbl.Size = new System.Drawing.Size(36, 17);
            this.slotLbl.TabIndex = 6;
            this.slotLbl.Text = "Slot:";
            // 
            // rackTxt
            // 
            this.rackTxt.Location = new System.Drawing.Point(395, 25);
            this.rackTxt.Name = "rackTxt";
            this.rackTxt.Size = new System.Drawing.Size(60, 22);
            this.rackTxt.TabIndex = 5;
            // 
            // rackLbl
            // 
            this.rackLbl.AutoSize = true;
            this.rackLbl.Location = new System.Drawing.Point(343, 27);
            this.rackLbl.Name = "rackLbl";
            this.rackLbl.Size = new System.Drawing.Size(44, 17);
            this.rackLbl.TabIndex = 4;
            this.rackLbl.Text = "Rack:";
            // 
            // portPLCTxt
            // 
            this.portPLCTxt.Location = new System.Drawing.Point(254, 25);
            this.portPLCTxt.Name = "portPLCTxt";
            this.portPLCTxt.Size = new System.Drawing.Size(60, 22);
            this.portPLCTxt.TabIndex = 3;
            // 
            // portPLCLbl
            // 
            this.portPLCLbl.AutoSize = true;
            this.portPLCLbl.Location = new System.Drawing.Point(209, 27);
            this.portPLCLbl.Name = "portPLCLbl";
            this.portPLCLbl.Size = new System.Drawing.Size(38, 17);
            this.portPLCLbl.TabIndex = 2;
            this.portPLCLbl.Text = "Port:";
            // 
            // ipTxt
            // 
            this.ipTxt.Location = new System.Drawing.Point(47, 25);
            this.ipTxt.Name = "ipTxt";
            this.ipTxt.Size = new System.Drawing.Size(139, 22);
            this.ipTxt.TabIndex = 1;
            // 
            // ipLbl
            // 
            this.ipLbl.AutoSize = true;
            this.ipLbl.Location = new System.Drawing.Point(17, 27);
            this.ipLbl.Name = "ipLbl";
            this.ipLbl.Size = new System.Drawing.Size(24, 17);
            this.ipLbl.TabIndex = 0;
            this.ipLbl.Text = "IP:";
            // 
            // Tesla3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 742);
            this.Controls.Add(this.plcGbx);
            this.Controls.Add(this.tesla3Lbl);
            this.Controls.Add(this.mciLogoPbx);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pathsGbx);
            this.Controls.Add(this.ftpGbx);
            this.Name = "Tesla3";
            this.Text = "Tesla3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ftpGbx.ResumeLayout(false);
            this.ftpGbx.PerformLayout();
            this.pathsGbx.ResumeLayout(false);
            this.pathsGbx.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mciLogoPbx)).EndInit();
            this.plcGbx.ResumeLayout(false);
            this.plcGbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ftpGbx;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox hostTxt;
        private System.Windows.Forms.Label hostLbl;
        private System.Windows.Forms.GroupBox pathsGbx;
        private System.Windows.Forms.TextBox sourceTxt;
        private System.Windows.Forms.Label remoteSiteLbl;
        private System.Windows.Forms.TextBox targetTxt;
        private System.Windows.Forms.Label localSiteLbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox strFromPLCTxt;
        private System.Windows.Forms.Label stringPLCLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label connStatusLbl;
        private System.Windows.Forms.TextBox imageSearchTxt;
        private System.Windows.Forms.Label imageNameLbl;
        private System.Windows.Forms.TextBox activityTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewImages;
        private System.Windows.Forms.Button searchImageBtn;
        private System.Windows.Forms.Button updateFTPConfBtn;
        private System.Windows.Forms.TextBox portFTPTxt;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.PictureBox mciLogoPbx;
        private System.Windows.Forms.Label tesla3Lbl;
        private System.Windows.Forms.GroupBox plcGbx;
        private System.Windows.Forms.TextBox ipTxt;
        private System.Windows.Forms.Label ipLbl;
        private System.Windows.Forms.TextBox slotTxt;
        private System.Windows.Forms.Label slotLbl;
        private System.Windows.Forms.TextBox rackTxt;
        private System.Windows.Forms.Label rackLbl;
        private System.Windows.Forms.TextBox portPLCTxt;
        private System.Windows.Forms.Label portPLCLbl;
        private System.Windows.Forms.Button updatePLCConfBtn;
        private System.Windows.Forms.Button updatePathsConfBtn;
        private System.Windows.Forms.TextBox defaultImgTxt;
        private System.Windows.Forms.Label defaultImgLbl;
    }
}

