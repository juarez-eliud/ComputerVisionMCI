
namespace ComputerVisionMCI
{
    partial class ImageData
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
            this.imaDatapictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imaDatapictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imaDatapictureBox
            // 
            this.imaDatapictureBox.Location = new System.Drawing.Point(0, -1);
            this.imaDatapictureBox.Name = "imaDatapictureBox";
            this.imaDatapictureBox.Size = new System.Drawing.Size(1651, 990);
            this.imaDatapictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imaDatapictureBox.TabIndex = 0;
            this.imaDatapictureBox.TabStop = false;
            // 
            // ImageData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 993);
            this.Controls.Add(this.imaDatapictureBox);
            this.Name = "ImageData";
            this.Text = "Image";
            this.Load += new System.EventHandler(this.ImageData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imaDatapictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox imaDatapictureBox;
   
    }
}