using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
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
            Form1 form = new Form1();
            Commands.CreateNewFile.create();
            Connection.ConnectionSetupParsers.setForm(form);
            Commands.ShowFlightData.setForm(form);
            Parsers.ParseSerialInput.setForm(form);
            Application.Run(form);
        }
    }
}
