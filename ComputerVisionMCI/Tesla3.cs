using ComputerVisionMCI.Models;
using System;
using System.Collections.Generic;
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
using System.Xml;

namespace ComputerVisionMCI
{
    public partial class Tesla3 : Form
    {
        PLC plcConf = new PLC();
        FTP ftpConf = new FTP();
        PathImages pathImgsConf = new PathImages();
        //Connection PLC
        libnodave.daveOSserialType daveSerial;
        libnodave.daveInterface daveInterface;
        libnodave.daveConnection daveConnection;
        readonly int dataBlock = 1200;

        public Tesla3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetPLCConfig();
            GetFTPConfig();
            GetPathsConfig();
            passwordTxt.PasswordChar = '*';
        }

        public void Initiate()
        {

          
            statusLbl.Text = "Connecting...";
            statusLbl.ForeColor = Color.DarkGray;

            //Thread.Sleep(60000);
            if (ConnectPLC())
            {
                
                statusLbl.Invoke((Action)delegate
                {
                    statusLbl.Text = "Connected";
                    statusLbl.ForeColor = Color.Green;
                });
                //Thread heartBeat = new Thread(HeartBeat);
                //heartBeat.Start();
            }
            else
            {
                
                statusLbl.Invoke((Action)delegate
                {
                    statusLbl.Text = "Unable to connect";
                    statusLbl.ForeColor = Color.Red;
                });
                //Thread.Sleep(60000);
                // Initiate();
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
                            //SET responseStart to false
                            daveConnection.writeBytes(libnodave.daveDB, dataBlock, 1, 1, stop);
                            //Read string from PLC
                            activityTxt.Invoke((Action)delegate
                            {
                                activityTxt.AppendText("Read string from PLC"+ "\r\n");
                            });

                            Array.Clear(strFromPLC, 0, strFromPLC.Length);

                            daveConnection.readBytes(libnodave.daveDB, dataBlock, 6, 100, strFromPLC);
                            daveConnection.writeBytes(libnodave.daveDB, dataBlock, 6, 100, strCleanToPLC);
                            //Reset string from PLC
                            var imgName = FormatString(strFromPLC);
                            
                            if (DownloadFile(imgName))
                            {
                                var a = daveConnection.writeBytes(libnodave.daveDB, dataBlock, 2, 1, done);
                                Console.WriteLine(a);                              
                                activityTxt.Invoke((Action)delegate
                                {
                                    activityTxt.AppendText("Done!");
                                });
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
                daveSerial.rfd = libnodave.openSocket(plcConf.Port, plcConf.IP);
                daveSerial.wfd = daveSerial.rfd;

                if (daveSerial.rfd > 0)
                {
                    daveInterface = new libnodave.daveInterface(daveSerial, "", 0, libnodave.daveProtoISOTCP, libnodave.daveSpeed187k);
                    //daveInterface.setTimeout(1000000);
                    if (0 == daveInterface.initAdapter())
                    {
                        daveConnection = new libnodave.daveConnection(daveInterface, 0, plcConf.Rack, plcConf.Slot);
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

        

        private void GetPLCConfig()
        {
            plcConf.Port = int.Parse(ConfigurationManager.AppSettings["port"]);
            plcConf.IP = ConfigurationManager.AppSettings["ip"];
            plcConf.Rack = int.Parse(ConfigurationManager.AppSettings["rack"]);
            plcConf.Slot = int.Parse(ConfigurationManager.AppSettings["slot"]);

            ipTxt.Text = plcConf.IP;
            portPLCTxt.Text = plcConf.Port.ToString();
            rackTxt.Text = plcConf.Rack.ToString();
            slotTxt.Text = plcConf.Slot.ToString();
        }

        private void GetFTPConfig()
        {
            ftpConf.Host = ConfigurationManager.AppSettings["host"];
            ftpConf.User = ConfigurationManager.AppSettings["user"];
            ftpConf.Pass = ConfigurationManager.AppSettings["pass"];
            ftpConf.Port = ConfigurationManager.AppSettings["portFTP"];

            hostTxt.Text = ftpConf.Host;
            usernameTxt.Text = ftpConf.User;
            passwordTxt.Text = ftpConf.Pass;
            portFTPTxt.Text = ftpConf.Port;
        }

        private void GetPathsConfig()
        {
            pathImgsConf.DefaultImage = ConfigurationManager.AppSettings["defaultImg"];
            pathImgsConf.Source = ConfigurationManager.AppSettings["source"];
            pathImgsConf.Target = ConfigurationManager.AppSettings["target"];

            defaultImgTxt.Text = pathImgsConf.DefaultImage;
            sourceTxt.Text = pathImgsConf.Source;
            targetTxt.Text = pathImgsConf.Target;
        }

        private void UpdatePathsConfig()
        {
            string defaultImg = defaultImgTxt.Text.Trim();
            string source = sourceTxt.Text.Trim();
            string target = targetTxt.Text.Trim();

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                foreach (XmlElement element in xmlDoc.DocumentElement)
                {
                    if (element.Name.Equals("appSettings"))
                    {
                        foreach (XmlNode node in element.ChildNodes)
                        {
                            if (node.Attributes[0].Value == "defaultImg")
                            {
                                node.Attributes[1].Value = defaultImg;
                            }
                            if (node.Attributes[0].Value == "source")
                            {
                                node.Attributes[1].Value = source;
                            }
                            if (node.Attributes[0].Value == "target")
                            {
                                node.Attributes[1].Value = target;
                            }
                           

                        }
                    }
                }

                xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                ConfigurationManager.RefreshSection("appSettings");
                GetPathsConfig();
                MessageBox.Show("Successfully saved", "Paths Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void UpdateFTPConfig()
        {
            string host = hostTxt.Text.Trim();
            string user = usernameTxt.Text.Trim();
            string pass = passwordTxt.Text.Trim();
            string port = portFTPTxt.Text.Trim();

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                foreach (XmlElement element in xmlDoc.DocumentElement)
                {
                    if (element.Name.Equals("appSettings"))
                    {
                        foreach (XmlNode node in element.ChildNodes)
                        {
                            if (node.Attributes[0].Value == "host")
                            {
                                node.Attributes[1].Value = host;
                            }
                            if (node.Attributes[0].Value == "user")
                            {
                                node.Attributes[1].Value = user;
                            }
                            if (node.Attributes[0].Value == "pass")
                            {
                                node.Attributes[1].Value = pass;
                            }
                            if (node.Attributes[0].Value == "portFTP")
                            {
                                node.Attributes[1].Value = port;
                            }

                        }
                    }
                }

                xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                ConfigurationManager.RefreshSection("appSettings");
                GetFTPConfig();
                MessageBox.Show("Successfully saved", "FTP Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UpdatePLCConfig()
        {
            string ip = ipTxt.Text.Trim();
            string port = portPLCTxt.Text.Trim();
            string rack = rackTxt.Text.Trim();
            string slot = slotTxt.Text.Trim();

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                foreach (XmlElement element in xmlDoc.DocumentElement)
                {
                    if (element.Name.Equals("appSettings"))
                    {
                        foreach (XmlNode node in element.ChildNodes)
                        {
                            if (node.Attributes[0].Value == "port")
                            {
                                node.Attributes[1].Value = port;
                            }
                            if (node.Attributes[0].Value == "ip")
                            {
                                node.Attributes[1].Value = ip;
                            }
                            if (node.Attributes[0].Value == "rack")
                            {
                                node.Attributes[1].Value = rack;
                            }
                            if (node.Attributes[0].Value == "slot")
                            {
                                node.Attributes[1].Value = slot;
                            }

                        }
                    }
                }

                xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                ConfigurationManager.RefreshSection("appSettings");
                GetPLCConfig();          
                MessageBox.Show("Successfully saved", "PLC Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewImages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    ImageData imgData = new ImageData();
                    string imgName = dataGridViewImages.CurrentRow.Cells[0].Value.ToString();
                    Image img = Image.FromFile($@"{pathImgsConf.Target}\{imgName}");
                    imgData.imaDatapictureBox.Image = img;
                    imgData.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void searchImageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string imageSearch = imageSearchTxt.Text;
                string[] files = Directory.GetFiles($@"{pathImgsConf.Target}");
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
                    MessageBox.Show("No results found", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                  
                    dataGridViewImages.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private bool DownloadFile(string imageName)
        {
            bool doneTask = false;
            try
            {
                FtpWebRequest requestDownload = (FtpWebRequest)WebRequest
                    .Create($"ftp://{ftpConf.Host}:{ftpConf.Port}/{pathImgsConf.Source}/{pathImgsConf.DefaultImage}");
                requestDownload.Method = WebRequestMethods.Ftp.DownloadFile;
                requestDownload.Credentials = new NetworkCredential(ftpConf.User, ftpConf.Pass);
                using (FtpWebResponse response = (FtpWebResponse)requestDownload.GetResponse())
                using (Stream ftpStream = response.GetResponseStream())
                using (Stream fileStream = File.Create($@"{pathImgsConf.Target}\{imageName}.jpg"))
                {
                    ftpStream.CopyTo(fileStream);                      
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
                }
            }
            return doneTask;
        }

        private void DeleteFile()
        {
            try
            {
                FtpWebRequest requestDelete = (FtpWebRequest)WebRequest
                .Create($"ftp://{ftpConf.Host}:{ftpConf.Port}/{pathImgsConf.Source}/{pathImgsConf.DefaultImage}");
                requestDelete.Method = WebRequestMethods.Ftp.DeleteFile;

                requestDelete.Credentials = new NetworkCredential(ftpConf.User, ftpConf.Pass);
                using (FtpWebResponse response2 = (FtpWebResponse)requestDelete.GetResponse())
                {
                    Console.WriteLine(response2.StatusDescription);
                    activityTxt.Invoke((Action)delegate
                    {
                        activityTxt.AppendText("Image deleted" + "\r\n");
                    });
                    response2.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private string FormatString(byte[] strPLC)
        {
            string cleanString = "";
            try
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
                cleanString = Encoding.ASCII.GetString(bytes);
                strFromPLCTxt.Invoke((Action)delegate
                {
                    strFromPLCTxt.Text = cleanString;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }          
            return cleanString;
        }

        private void updatePLCConfBtn_Click(object sender, EventArgs e)
        {
            UpdatePLCConfig();
        }

        private void updateFTPConfBtn_Click(object sender, EventArgs e)
        {
            UpdateFTPConfig();
        }

        private void updatePathsConfBtn_Click(object sender, EventArgs e)
        {
            UpdatePathsConfig();
        }

        private void connectPLCBtn_Click(object sender, EventArgs e)
        {
            Initiate();
        }
    }
}
