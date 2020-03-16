using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Connection
{
    class ConnectionSetupParsers
    {
        private static Form1 form;
        public static void setForm (Form1 fo)
        {
            form = fo;
            Parsers.AltitudeData.setForm(fo);
        }
        public static int getBaudrate()
        {
            String BaudRate = form.getBaudRate();
            int BR = Int32.Parse(BaudRate);
            if (BR > 300 && BR < 115200)
                return Int32.Parse(BaudRate);
            else
                throw new FormatException();
        }
        public static String getCOMPort()
        {
            String COMPort = form.getCOMPort().ToUpper();
            var regex = @"^\w{3}\d{1,9}$"; //Regex for 3 characters followed by an int 1>>9
            var match = Regex.Match(COMPort, regex,RegexOptions.IgnoreCase);
            if (match.Success)
                return COMPort;
            else
                throw new FormatException();
        }
    }
}
