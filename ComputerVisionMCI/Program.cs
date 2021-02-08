using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerVisionMCI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            string value = "mci_Techno";

            // Convert the string into a byte[].
            //byte[] asciiBytes = Encoding.ASCII.GetBytes(value);
            //foreach (var item in asciiBytes)
            //{
            //    Console.WriteLine(item);

            //}

            //--------------

            //byte[] cadena = new byte[20];          
            //cadena[7] = 101;
            //cadena[8] = 108;
            //cadena[9] = 105;
            //cadena[10] = 117;
            //cadena[11] = 100;

            //List<int> intss = new List<int>();

            //foreach (int item in cadena)
            //{
            //    if (item != 0)
            //    {
            //        intss.Add(item);
            //    }

            //}

            //byte[] bytes = intss.Select(x => (byte)x).ToArray();


            ////foreach (int item3 in bytes)
            ////{
            ////    Console.WriteLine(item3);

            ////}

            //string asdddsfa = Encoding.ASCII.GetString(bytes);


            //Console.WriteLine(asdddsfa);

            //Array.Clear(cadena, 0, cadena.Length);

            //Console.WriteLine(cadena);

            //-------

            //byte[] bufEsc = BitConverter.GetBytes(28524);
            //byte[] bufEscExit = BitConverter.GetBytes(0);

            //Console.WriteLine(bufEsc);
            //Console.WriteLine(bufEscExit);

            string fileName = "asdf.png";
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://192.168.1.69/"+ fileName);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential("eliud","b203284");
            bool asf = false;
            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (Stream ftpStream = response.GetResponseStream())
                using (Stream fileStream = File.Create(@"C:\Users\JuanC\Desktop\test\" + "abcdario.png"))
                {
                    ftpStream.CopyTo(fileStream);
                    
                    Console.WriteLine($"Download Complete, status {response.StatusDescription}");
                    response.Close();
                    asf = true;
                }
            }
            catch (WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                {
                    Console.WriteLine("File not exist");
                }
            }
            if (asf)
            {
                FtpWebRequest request2 = (FtpWebRequest)WebRequest.Create("ftp://192.168.1.69/" + fileName);
                request2.Method = WebRequestMethods.Ftp.DeleteFile;
              
                request2.Credentials = new NetworkCredential("eliud", "b203284");
                using (FtpWebResponse response2 = (FtpWebResponse)request2.GetResponse())
                {
                    Console.WriteLine(response2.StatusDescription);
                    response2.Close();
                }
            }




        }
    }
}
