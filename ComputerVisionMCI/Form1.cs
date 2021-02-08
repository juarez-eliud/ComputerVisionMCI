using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerVisionMCI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetConfiguration();
            

        }

        private void SetConfiguration()
        {
            hostTxt.Text = "itetlax.org.mx";
            usernameTxt.Text = "itetlaxo ";
            passwordTxt.Text = "1nfo3m4t1c4ITE$!";
            remoteSiteTxt.Text = "/home3/itetlaxo/public_html";
            localSiteTxt.Text = @"C:\Users\JuanC\Desktop\ITE Web\";
        }

        private void dataGridViewImages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ImageData imgData = new ImageData();
            string imgName = dataGridViewImages.CurrentRow.Cells[0].Value.ToString();
            Image img = Image.FromFile(@"C:\Users\JuanC\Desktop\images\" + imgName);
            imgData.imaDatapictureBox.Image = img;
            imgData.ShowDialog();
        }

        private void searchImageBtn_Click(object sender, EventArgs e)
        {
            string imageSearch = imageSearchTxt.Text;
            string[] files = Directory.GetFiles(@"C:\Users\JuanC\Desktop\images");
            DataTable table = new DataTable();
            table.Columns.Add("Image Name");

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                if (file.Name.Contains(imageSearch))
                {
                    table.Rows.Add(file.Name);
                }
            }
            if (table.Rows.Count > 0)
            {
                dataGridViewImages.DataSource = table;

            }
            else
            {
                table.Rows.Add("No results found");
                dataGridViewImages.DataSource = table;
            }

        }
    }
}
