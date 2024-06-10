using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace psoproject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string dosyaYolu = @"C: \Users\aysen\source\repos\psoproject\psoproject\insurance.csv";
            double[][] veriSeti = VeriSetiYukleyici.YükleVeriSeti(dosyaYolu);

            if (veriSeti != null)
            {
                // Process your dataset
                Console.WriteLine("Dataset loaded successfully.");
            }

            else
            {
                Console.WriteLine("Failed to load the dataset.");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
