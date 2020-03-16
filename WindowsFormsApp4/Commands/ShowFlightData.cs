using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Commands
{
    class ShowFlightData
    {
        private static Form1 form;
        public static void setForm(Form1 fo)
        {
            form = fo;
        }
        public static void show()
        {
            try
            {
                Process.Start(@"Data.txt");
            }
            catch (Exception E)
            {
                form.editDebuggingText("Failed To Open Flight Data File");
                form.editDebuggingText(E.StackTrace);
            }
        }
    }
}
