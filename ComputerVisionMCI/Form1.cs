using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


    }
}
