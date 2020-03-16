using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Parsers
{
    class ParseSerialInput
    {
        private static Form1 form;
        public static void setForm(Form1 fo)
        {
            form = fo;
        }
        public static void interpret(String input)
        {
            if (input.StartsWith("Altitude"))
            {
                String Data = input.Substring(input.IndexOf(':')+1);
                Parsers.AltitudeData.processData(Data);
            }
            else
            {
                form.editDebuggingText("Recieved : "+input);
            }
        }
    }
}
