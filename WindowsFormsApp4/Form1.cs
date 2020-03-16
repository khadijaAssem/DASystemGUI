using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private static int i = 0;
        private static int MultOfHundreds = 100;

        public Form1()
        {
            InitializeComponent();
        }

        public String getBaudRate()
        {
            return BaudRateTB.Text;
        }
        public String getCOMPort()
        {
            return COMPortTB.Text;
        }

        private void Connect_Click_1(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    editDebuggingText("Connecting...");
                    Console.WriteLine("COM Port : "+Connection.ConnectionSetupParsers.getCOMPort());
                    Console.WriteLine("BaudRate : " + Connection.ConnectionSetupParsers.getBaudrate());

                    serialPort1.PortName = Connection.ConnectionSetupParsers.getCOMPort();
                    serialPort1.BaudRate = Connection.ConnectionSetupParsers.getBaudrate();

                    timer1.Enabled = true;
                    serialPort1.Open();
                    ShowState.Text = "Connected";
                    ShowState.ForeColor = Color.DarkGreen;
                    RPayloads.Enabled = true;
                    ReleaseCDA.Enabled = true;
                    Disconnect.Enabled = true;
                    Connect.Enabled = false;
                    editDebuggingText("Connection done");
                }
                catch (Exception E)
                {
                    editDebuggingText("Cann't Connect ");
                    editDebuggingText("COM " + COMPortTB.Text + " Not found !");
                    editDebuggingText(E.StackTrace);
                }
            }
        }

        private void Disconnect_Click_1(object sender, EventArgs e)
        {
            try {
                editDebuggingText("Disconnecting....");
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    ShowState.Text = "Disconnected";
                    timer1.Enabled = false;
                    ShowState.ForeColor = Color.DarkRed;
                    ReleaseCDA.Enabled = false;
                    Connect.Enabled = true;
                    ReleaseCDA.Enabled = false;
                    RPayloads.Enabled = false;
                    editDebuggingText("Disconnected");
                }
            }
            catch(Exception E)
            {
                editDebuggingText("Failed To Disconnect");
                editDebuggingText(E.StackTrace);
            }
        }

        private void IncSize_Click(object sender, EventArgs e)
        {
            try
            {
                float currentSize = Height.Font.Size;
                currentSize += 1.0F;
                Height.Font = new Font(Height.Font.Name, currentSize, Height.Font.Style, Height.Font.Unit);
                WaitingCDA.Font = new Font(WaitingCDA.Font.Name, currentSize, WaitingCDA.Font.Style, WaitingCDA.Font.Unit);
                WaitingPayloads.Font = new Font(WaitingPayloads.Font.Name, currentSize, WaitingPayloads.Font.Style, WaitingPayloads.Font.Unit);

            }
            catch(Exception E)
            {
                editDebuggingText("Cann't Increase Size");
                editDebuggingText(E.StackTrace);
            }
        }

        private void DecSize_Click(object sender, EventArgs e)
        {
            try
            {
                float currentSize = Height.Font.Size;
                currentSize -= 1.0F;
                Height.Font = new Font(Height.Font.Name, currentSize, Height.Font.Style, Height.Font.Unit);
                WaitingCDA.Font = new Font(WaitingCDA.Font.Name, currentSize, WaitingCDA.Font.Style, WaitingCDA.Font.Unit);
                WaitingPayloads.Font = new Font(WaitingPayloads.Font.Name, currentSize, WaitingPayloads.Font.Style, WaitingPayloads.Font.Unit);
            }
            catch(Exception E)
            {
                editDebuggingText("Cann't Decrease Size");
                editDebuggingText(E.StackTrace);
            }
        }

        private void ScreenShot_Click(object sender, EventArgs e)
        {
            try
            {
                editDebuggingText("Capturing ScreenShot .....");
                Console.WriteLine("ScreenShot Capure Command");
                Commands.ScreenShotCMD.Capture();
                editDebuggingText("ScreenShot Captured");
            }
            catch(Exception E)
            {
                editDebuggingText("Failed To Capture ScreenShot");
                editDebuggingText(E.StackTrace);
            }
        }

        private void ShowFlightData_Click_1(object sender, EventArgs e)
        {
            try
            {
                editDebuggingText("Openning Flight Data .......");
                Commands.ShowFlightData.show();
                editDebuggingText("Flight Data Opened");
            }
            catch(Exception E)
            {
                editDebuggingText("Failed To Open Flight Data");
                editDebuggingText(E.StackTrace);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Timer.Text = Commands.TimerTickCMD.tick();
            }
            catch(Exception E)
            {
                editDebuggingText("Timer Error");
                editDebuggingText(E.StackTrace);
            }
        }

        public void setHeightText(String text)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    Height.Text = text;
                }));
            }
            catch(Exception E)
            {
                editDebuggingText("Failed To Set Height Text");
                editDebuggingText(E.StackTrace);
            }
        } 

        public void setAbove100Text(String text,Color color)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    Above100.Text = text;
                    Above100.ForeColor = color;
                }));
            }
            catch (Exception E)
            {
                editDebuggingText("Failed To Set Above 100 Text");
                editDebuggingText(E.StackTrace);
            }
        }

        public void editDebuggingText(String text)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    Debugging.AppendText(Timer.Text + " >> " + text);
                }));
            }
            catch (Exception E)
            {
                Console.WriteLine("Failed To Add Debug Data Text");
                Console.WriteLine(E.StackTrace);
            }
        }

        public void updateChart(float data,String series)
        {
            var Chart = chart1.ChartAreas[0];
            try
            {
                Invoke(new Action(() =>
                {
                    if (i > MultOfHundreds)
                        MultOfHundreds += i;

                    Chart.AxisX.Minimum = (MultOfHundreds - 100);
                    Chart.AxisX.Maximum = MultOfHundreds;

                    Chart.AxisX.Interval = 5;
                    Chart.AxisY.Interval = 2;

                    Chart.RecalculateAxesScale();

                    chart1.Series[0].IsVisibleInLegend = false;
                    chart1.Series[series].Points.AddXY(i, data);
                    i++;
                }));
            }
            catch (Exception)
            {
                editDebuggingText("Error Updating Chart");
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string Data = serialPort1.ReadLine();
                Parsers.ParseSerialInput.interpret(Data);
            }
            catch(Exception E)
            {
                editDebuggingText("Data Recieved Error");
                editDebuggingText(E.StackTrace);
            }
        }
       
        private void ResetBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string H = Height.Text;
                for (int k = 0; k < 10; k++)
                    serialPort1.Write("3");
                editDebuggingText("Reset CMD Sent");
            }
            catch (Exception E)
            {
                editDebuggingText("Reset Failed");
                editDebuggingText(E.StackTrace);
            }
        }

        private void RPayloads_Click(object sender, EventArgs e)
        {
            string H = Height.Text;
            try
            {
                for (int k = 0; k < 10; k++)
                    serialPort1.Write("2");

                editDebuggingText("Release Payloads CMD Sent");

                Parsers.AltitudeData.editFile("Payloads releasd at hight : " + H);
                WaitingPayloads.Text = H;
            }
            catch(Exception E)
            {
                editDebuggingText("Failed to release payloads");
                editDebuggingText(E.StackTrace);
            }
            try
            {
                float fData = 0;
                try
                {
                    fData = float.Parse(H);
                    updateChart(fData, "Series3");
                }
                catch (Exception E)
                {
                    editDebuggingText("Failed To add Point In Graph : Payloads Releasing");
                    editDebuggingText(E.StackTrace);
                }
            }
            catch (Exception E)
            {
                editDebuggingText("Failed To add Point In Graph : Payloads Releasing");
                editDebuggingText(E.StackTrace);
            }
        }

        private void ReleaseCDA_Click(object sender, EventArgs e)
        {
            string H = Height.Text;
            try
            {
                for (int k = 0; k < 10; k++)
                    serialPort1.Write("1");

                editDebuggingText("Release CDA CMD Sent");

                Parsers.AltitudeData.editFile("CDA releasd at hight : " + H);
                WaitingCDA.Text = H;
            }
            catch(Exception E)
            {
                editDebuggingText("Failed To Release Payloads");
                editDebuggingText(E.StackTrace);
            }

            try
            {
                float fData = 0;
                try
                {
                    fData = float.Parse(H);
                    updateChart(fData, "Series2");
                }
                catch (Exception E)
                {
                    editDebuggingText("Failed To add Point In Graph : CDA Releasing");
                    editDebuggingText(E.StackTrace);
                }
            }
            catch (Exception E)
            {
                editDebuggingText("Failed To add Point In Graph : CDA Releasing");
                editDebuggingText(E.StackTrace);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (e.KeyChar.ToString().Equals("c")|| e.KeyChar.ToString().Equals("C"))
            {
                editDebuggingText("C Pressed");
            }
            else 
            {
                if ( e.KeyChar.ToString().Equals("P") || e.KeyChar.ToString().Equals("p"))
                {
                    editDebuggingText("P Pressed");
                }
            }*/

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Pressed");
            editDebuggingText("Key Pressed");
            if (e.KeyCode.ToString().Equals("c") || e.KeyCode.ToString().Equals("C"))
            {
                editDebuggingText("C Pressed");
            }
            else
            {
                if (e.KeyCode.ToString().Equals("P") || e.KeyCode.ToString().Equals("p"))
                {
                    editDebuggingText("P Pressed");
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Pressed");
            editDebuggingText("Key Pressed");
            if (e.KeyCode.ToString().Equals("c") || e.KeyCode.ToString().Equals("C"))
            {
                editDebuggingText("C Pressed");
            }
            else
            {
                if (e.KeyCode.ToString().Equals("P") || e.KeyCode.ToString().Equals("p"))
                {
                    editDebuggingText("P Pressed");
                }
            }
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Console.WriteLine("Pressed");
            editDebuggingText("Key Pressed");
            if (e.KeyCode.ToString().Equals("c") || e.KeyCode.ToString().Equals("C"))
            {
                editDebuggingText("C Pressed");
            }
            else
            {
                if (e.KeyCode.ToString().Equals("P") || e.KeyCode.ToString().Equals("p"))
                {
                    editDebuggingText("P Pressed");
                }
            }
        }
    }
}