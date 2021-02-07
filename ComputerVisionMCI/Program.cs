using System;
using System.Collections.Generic;
using System.Linq;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

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

            //byte[] bufEsc = BitConverter.GetBytes(814);
            //byte[] bufEscExit = BitConverter.GetBytes(0);

            //Console.WriteLine(bufEsc);
            //Console.WriteLine(bufEscExit);





        }
    }
}
