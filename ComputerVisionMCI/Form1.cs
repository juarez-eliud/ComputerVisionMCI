using ComputerVisionMCI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace ComputerVisionMCI
{
    public partial class Form1 : Form
    {
        ConnectionSettings conSet = new ConnectionSettings();
        //Connection PLC
        libnodave.daveOSserialType daveSerial;
        libnodave.daveInterface daveInterface;
        libnodave.daveConnection daveConnection;


        readonly int dataBlock = 1200;

        public string status = "";
        string fileNameFromFTP = "0_img.jpg";
                
        public Form1()
        {            
            conSet.Port = int.Parse(ConfigurationManager.AppSettings["port"]);
            conSet.IP = ConfigurationManager.AppSettings["ip"];
            conSet.Rack = int.Parse(ConfigurationManager.AppSettings["rack"]);
            conSet.Slot = int.Parse(ConfigurationManager.AppSettings["slot"]);
            Initiate();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetConfiguration();
            

        }

        public void Initiate()
        {
            if (ConnectPLC())
            {
                status = "Conectado";
                Console.WriteLine(status);
                Thread heartBeat = new Thread(HeartBeat);
                heartBeat.Start();

            }
            else
            {
                status = $"Sin conexión a la IP: {conSet.IP}, reintentando...";
                Console.WriteLine(status);
                Thread.Sleep(60000);
                Initiate();
            }

        }

        public void HeartBeat()
        {
            byte[] on = BitConverter.GetBytes(255);
            byte[] off = BitConverter.GetBytes(0);
            byte[] start = BitConverter.GetBytes(255);
            byte[] stop = BitConverter.GetBytes(0);
            byte[] strFromPLC;
            byte[] strCleanToPLC = new byte[100];
            byte[] done = BitConverter.GetBytes(255);
            byte[] resetDone = BitConverter.GetBytes(0);

           
          

            while (true)
            {
                try
                {
                    //Heart Beat
                    daveConnection.writeBits(libnodave.daveDB, dataBlock, 0, 1, on);
                    daveConnection.writeBits(libnodave.daveDB, dataBlock, 0, 1, off);
                    var responseStart = daveConnection.readBytes(libnodave.daveDB, dataBlock, 1, 1, start);

                    if (responseStart == 0)
                    {
                        //IF responseStart is true
                        if (start[0] == 1)
                        {
                            
                            strFromPLC = new byte[100];
                            activityTxt.Invoke((Action)delegate
                            {
                                activityTxt.Clear();
                                activityTxt.AppendText("Start"+"\r\n");
                            });
                            Console.WriteLine("Start");
                            //SET responseStart to false
                            daveConnection.writeBytes(libnodave.daveDB, dataBlock, 1, 1, stop);
                            //Read string from PLC
                            activityTxt.Invoke((Action)delegate
                            {
                                activityTxt.AppendText("Read string from PLC"+ "\r\n");
                            });

                            Array.Clear(strFromPLC, 0, strFromPLC.Length);

                            daveConnection.readBytes(libnodave.daveDB, dataBlock, 6, 100, strFromPLC);
                            var asss = daveConnection.writeBytes(libnodave.daveDB, dataBlock, 6, 100, strCleanToPLC);
                            //Reset string from PLC                           
                            Console.WriteLine(asss);
                            var imgName = FormatString(strFromPLC);
                            
                            if (DownloadFile(imgName))
                            {
                                var a = daveConnection.writeBytes(libnodave.daveDB, dataBlock, 2, 1, done);
                                Console.WriteLine(a);                              
                                activityTxt.Invoke((Action)delegate
                                {
                                    activityTxt.AppendText("Done!");
                                });
                                Console.WriteLine("Done");

                            }




                        }

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }


        }






        public bool ConnectPLC()
        {
            try
            {
                daveSerial.rfd = libnodave.openSocket(conSet.Port, conSet.IP);
                daveSerial.wfd = daveSerial.rfd;

                if (daveSerial.rfd > 0)
                {
                    daveInterface = new libnodave.daveInterface(daveSerial, "", 0, libnodave.daveProtoISOTCP, libnodave.daveSpeed187k);
                    daveInterface.setTimeout(1000000);
                    if (0 == daveInterface.initAdapter())
                    {
                        daveConnection = new libnodave.daveConnection(daveInterface, 0, conSet.Rack, conSet.Slot);
                        if (0 == daveConnection.connectPLC())
                        {
                            return true;
                        }
                        else
                        {
                            daveConnection.disconnectPLC();
                            libnodave.closeSocket(daveSerial.rfd);
                            return false;
                        }
                    }
                    else
                    {
                        daveInterface.disconnectAdapter();
                        libnodave.closeSocket(daveSerial.rfd);
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }


        }

        private void SetConfiguration()
        {
            hostTxt.Text = "192.168.0.30";
            usernameTxt.Text = "INTERFACE ";
            passwordTxt.Text = "1378";
            sourceTxt.Text = "cv-x/capture";
            targetTxt.Text = @"C:\Users\JuanC\Desktop\test";            
        }

        private void dataGridViewImages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ImageData imgData = new ImageData();
            string imgName = dataGridViewImages.CurrentRow.Cells[0].Value.ToString();
            Image img = Image.FromFile(@"C:\Users\JuanC\Desktop\test\" + imgName);
            imgData.imaDatapictureBox.Image = img;
            imgData.ShowDialog();
        }

        private void searchImageBtn_Click(object sender, EventArgs e)
        {
            string imageSearch = imageSearchTxt.Text;
            string[] files = Directory.GetFiles(@"C:\Users\JuanC\Desktop\test");
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


        private bool DownloadFile(string imageName)
        {
            FtpWebRequest requestDownload = (FtpWebRequest)WebRequest.Create("ftp://192.168.0.30:321/cv-x/capture/" + fileNameFromFTP);
            requestDownload.Method = WebRequestMethods.Ftp.DownloadFile;
            requestDownload.Credentials = new NetworkCredential("INTERFACE", "1378");
            bool doneTask = false;
            try
            {
                using (FtpWebResponse response = (FtpWebResponse)requestDownload.GetResponse())
                using (Stream ftpStream = response.GetResponseStream())
                using (Stream fileStream = File.Create(@"C:\Users\JuanC\Desktop\test\" + imageName + ".jpg"))
                {
                    ftpStream.CopyTo(fileStream);
                    Console.WriteLine($"Download Complete, status {response.StatusDescription}");            
                    activityTxt.Invoke((Action)delegate
                    {
                        activityTxt.AppendText("Image saved"+ "\r\n");
                    });
                    response.Close();
                    DeleteFile();
                    doneTask = true;
                }
            }
            catch (WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                {                
                    activityTxt.Invoke((Action)delegate
                    {
                        activityTxt.AppendText("File not exist"+ "\r\n");
                    });
                    Console.WriteLine("File not exist");
                }
            }

            return doneTask;

        }

        private void DeleteFile()
        {
            FtpWebRequest requestDelete = (FtpWebRequest)WebRequest.Create("ftp://192.168.0.30:321/cv-x/capture/" + fileNameFromFTP);
            requestDelete.Method = WebRequestMethods.Ftp.DeleteFile;

            requestDelete.Credentials = new NetworkCredential("INTERFACE", "1378");
            using (FtpWebResponse response2 = (FtpWebResponse)requestDelete.GetResponse())
            {
                Console.WriteLine(response2.StatusDescription);        
                activityTxt.Invoke((Action)delegate
                {
                    activityTxt.AppendText("Image deleted"+ "\r\n");
                });
                response2.Close();
            }
        }


        private string FormatString(byte[] strPLC)
        {
            List<int> strPLCint = new List<int>();

            foreach (int item in strPLC)
            {
                if (item != 0)
                {
                    strPLCint.Add(item);
                }

            }

            byte[] bytes = strPLCint.Select(x => (byte)x).ToArray();

            string cleanString = Encoding.ASCII.GetString(bytes);
            strFromPLCTxt.Invoke((Action)delegate
            {
                strFromPLCTxt.Text = cleanString;               
            });

            Console.WriteLine(cleanString);
            return cleanString;
        }

       

    }
}
