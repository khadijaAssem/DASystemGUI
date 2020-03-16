using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Parsers
{
    class AltitudeData
    {
        private static Form1 form;
        public static void setForm(Form1 fo)
        {
            form = fo;
        }
        public static void processData(String data)
        {
            form.setHeightText(data);
            editFile(data);
            float fData = 0;
            try
            {
                fData = float.Parse(data);
                checkAltitude(fData);
                form.updateChart(fData,"Series1");
            }
            catch (Exception)
            {
                form.editDebuggingText("Data Error from Process Data recieved .........");
                return;
            }
        }
        private static void checkAltitude(float altitude)
        { 
            try
            {
                //Hight = data;//For Releasing data
                if (altitude > 100)
                {
                    form.setAbove100Text("We are above 100 ft", Color.RoyalBlue);
                }
                else
                {
                    form.setAbove100Text("", Color.Red);
                }
            }
            catch (Exception)
            {
                form.editDebuggingText("Error Checking Above 100 Condition");
            }

        }
        public static void editFile(String altitude)
        {
            try
            {
                var systemPath = System.Environment.
                                 GetFolderPath(
                                     Environment.SpecialFolder.CommonApplicationData
                                 );
                using (System.IO.StreamWriter sw2 = new System.IO.StreamWriter("Data.txt", true))
                {
                    sw2.WriteLine(altitude);
                }
            }
            catch(Exception E)
            {
                form.editDebuggingText("Failed To Update File");
                form.editDebuggingText(E.StackTrace);
            }
        }
    }
}
