namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ScreenShot = new System.Windows.Forms.Button();
            this.DecSize = new System.Windows.Forms.Button();
            this.IncSize = new System.Windows.Forms.Button();
            this.WaitingPayloads = new System.Windows.Forms.Label();
            this.WaitingCDA = new System.Windows.Forms.Label();
            this.RPayloads = new System.Windows.Forms.Button();
            this.ReleaseCDA = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Above100 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BaudRateTB = new System.Windows.Forms.TextBox();
            this.COMPortTB = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.Label();
            this.ft = new System.Windows.Forms.Label();
            this.CurrentHeight = new System.Windows.Forms.Label();
            this.ShowFlightData = new System.Windows.Forms.Button();
            this.ShowState = new System.Windows.Forms.Label();
            this.ConnectionState = new System.Windows.Forms.Label();
            this.BaudRata = new System.Windows.Forms.Label();
            this.ComPort = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.ResetBTN = new System.Windows.Forms.Button();
            this.Debugging = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScreenShot
            // 
            this.ScreenShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenShot.Location = new System.Drawing.Point(656, 298);
            this.ScreenShot.Name = "ScreenShot";
            this.ScreenShot.Size = new System.Drawing.Size(270, 41);
            this.ScreenShot.TabIndex = 40;
            this.ScreenShot.Text = "Capture screenshot";
            this.ScreenShot.UseVisualStyleBackColor = true;
            this.ScreenShot.Click += new System.EventHandler(this.ScreenShot_Click);
            // 
            // DecSize
            // 
            this.DecSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecSize.Location = new System.Drawing.Point(1392, 95);
            this.DecSize.Name = "DecSize";
            this.DecSize.Size = new System.Drawing.Size(32, 42);
            this.DecSize.TabIndex = 39;
            this.DecSize.Text = "-";
            this.DecSize.UseVisualStyleBackColor = true;
            this.DecSize.Click += new System.EventHandler(this.DecSize_Click);
            // 
            // IncSize
            // 
            this.IncSize.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncSize.Location = new System.Drawing.Point(1392, 49);
            this.IncSize.Name = "IncSize";
            this.IncSize.Size = new System.Drawing.Size(32, 40);
            this.IncSize.TabIndex = 38;
            this.IncSize.Text = "+";
            this.IncSize.UseVisualStyleBackColor = true;
            this.IncSize.Click += new System.EventHandler(this.IncSize_Click);
            // 
            // WaitingPayloads
            // 
            this.WaitingPayloads.AutoSize = true;
            this.WaitingPayloads.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitingPayloads.Location = new System.Drawing.Point(816, 235);
            this.WaitingPayloads.Name = "WaitingPayloads";
            this.WaitingPayloads.Size = new System.Drawing.Size(100, 29);
            this.WaitingPayloads.TabIndex = 34;
            this.WaitingPayloads.Text = "Waiting";
            // 
            // WaitingCDA
            // 
            this.WaitingCDA.AutoSize = true;
            this.WaitingCDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitingCDA.Location = new System.Drawing.Point(816, 188);
            this.WaitingCDA.Name = "WaitingCDA";
            this.WaitingCDA.Size = new System.Drawing.Size(100, 29);
            this.WaitingCDA.TabIndex = 33;
            this.WaitingCDA.Text = "Waiting";
            // 
            // RPayloads
            // 
            this.RPayloads.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPayloads.Location = new System.Drawing.Point(563, 223);
            this.RPayloads.Name = "RPayloads";
            this.RPayloads.Size = new System.Drawing.Size(208, 41);
            this.RPayloads.TabIndex = 32;
            this.RPayloads.Text = "Release payloads";
            this.RPayloads.UseVisualStyleBackColor = true;
            this.RPayloads.Click += new System.EventHandler(this.RPayloads_Click);
            // 
            // ReleaseCDA
            // 
            this.ReleaseCDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseCDA.Location = new System.Drawing.Point(563, 179);
            this.ReleaseCDA.Name = "ReleaseCDA";
            this.ReleaseCDA.Size = new System.Drawing.Size(208, 38);
            this.ReleaseCDA.TabIndex = 31;
            this.ReleaseCDA.Text = "Release CDA";
            this.ReleaseCDA.UseVisualStyleBackColor = true;
            this.ReleaseCDA.Click += new System.EventHandler(this.ReleaseCDA_Click);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(659, 49);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(133, 36);
            this.Timer.TabIndex = 30;
            this.Timer.Text = "00:00:00";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(12, 455);
            this.chart1.Name = "chart1";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series14.Legend = "Legend1";
            series14.Name = "Series2";
            series14.YValuesPerPoint = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series15.Legend = "Legend1";
            series15.Name = "Series3";
            series15.YValuesPerPoint = 2;
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Series.Add(series15);
            this.chart1.Size = new System.Drawing.Size(1456, 583);
            this.chart1.TabIndex = 41;
            this.chart1.Text = "chart1";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Above100
            // 
            this.Above100.AutoSize = true;
            this.Above100.Location = new System.Drawing.Point(1009, 218);
            this.Above100.Name = "Above100";
            this.Above100.Size = new System.Drawing.Size(0, 20);
            this.Above100.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BaudRateTB);
            this.groupBox1.Controls.Add(this.COMPortTB);
            this.groupBox1.Controls.Add(this.Height);
            this.groupBox1.Controls.Add(this.ft);
            this.groupBox1.Controls.Add(this.CurrentHeight);
            this.groupBox1.Controls.Add(this.ShowFlightData);
            this.groupBox1.Controls.Add(this.ShowState);
            this.groupBox1.Controls.Add(this.ConnectionState);
            this.groupBox1.Controls.Add(this.BaudRata);
            this.groupBox1.Controls.Add(this.ComPort);
            this.groupBox1.Controls.Add(this.Connect);
            this.groupBox1.Controls.Add(this.Disconnect);
            this.groupBox1.Location = new System.Drawing.Point(33, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 345);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // BaudRateTB
            // 
            this.BaudRateTB.Location = new System.Drawing.Point(238, 114);
            this.BaudRateTB.Name = "BaudRateTB";
            this.BaudRateTB.Size = new System.Drawing.Size(100, 26);
            this.BaudRateTB.TabIndex = 51;
            this.BaudRateTB.Text = "57600";
            // 
            // COMPortTB
            // 
            this.COMPortTB.Location = new System.Drawing.Point(238, 78);
            this.COMPortTB.Name = "COMPortTB";
            this.COMPortTB.Size = new System.Drawing.Size(100, 26);
            this.COMPortTB.TabIndex = 50;
            this.COMPortTB.Text = "COM";
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height.Location = new System.Drawing.Point(247, -6);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(101, 36);
            this.Height.TabIndex = 49;
            this.Height.Text = "Height";
            // 
            // ft
            // 
            this.ft.AutoSize = true;
            this.ft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ft.Location = new System.Drawing.Point(360, 0);
            this.ft.Name = "ft";
            this.ft.Size = new System.Drawing.Size(27, 29);
            this.ft.TabIndex = 48;
            this.ft.Text = "ft";
            // 
            // CurrentHeight
            // 
            this.CurrentHeight.AutoSize = true;
            this.CurrentHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentHeight.Location = new System.Drawing.Point(59, 0);
            this.CurrentHeight.Name = "CurrentHeight";
            this.CurrentHeight.Size = new System.Drawing.Size(182, 29);
            this.CurrentHeight.TabIndex = 47;
            this.CurrentHeight.Text = "Current Height";
            // 
            // ShowFlightData
            // 
            this.ShowFlightData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowFlightData.Location = new System.Drawing.Point(137, 278);
            this.ShowFlightData.Name = "ShowFlightData";
            this.ShowFlightData.Size = new System.Drawing.Size(238, 46);
            this.ShowFlightData.TabIndex = 46;
            this.ShowFlightData.Text = "Show Flight Data";
            this.ShowFlightData.UseVisualStyleBackColor = true;
            this.ShowFlightData.Click += new System.EventHandler(this.ShowFlightData_Click_1);
            // 
            // ShowState
            // 
            this.ShowState.AutoSize = true;
            this.ShowState.Location = new System.Drawing.Point(269, 166);
            this.ShowState.Name = "ShowState";
            this.ShowState.Size = new System.Drawing.Size(107, 20);
            this.ShowState.TabIndex = 45;
            this.ShowState.Text = "Disconnected";
            // 
            // ConnectionState
            // 
            this.ConnectionState.AutoSize = true;
            this.ConnectionState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionState.Location = new System.Drawing.Point(47, 162);
            this.ConnectionState.Name = "ConnectionState";
            this.ConnectionState.Size = new System.Drawing.Size(212, 29);
            this.ConnectionState.TabIndex = 44;
            this.ConnectionState.Text = "Connection State";
            // 
            // BaudRata
            // 
            this.BaudRata.AutoSize = true;
            this.BaudRata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRata.Location = new System.Drawing.Point(59, 110);
            this.BaudRata.Name = "BaudRata";
            this.BaudRata.Size = new System.Drawing.Size(134, 29);
            this.BaudRata.TabIndex = 43;
            this.BaudRata.Text = "Baud Rate";
            // 
            // ComPort
            // 
            this.ComPort.AutoSize = true;
            this.ComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComPort.Location = new System.Drawing.Point(59, 75);
            this.ComPort.Name = "ComPort";
            this.ComPort.Size = new System.Drawing.Size(127, 29);
            this.ComPort.TabIndex = 42;
            this.ComPort.Text = "COM Port";
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.PaleGreen;
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.Location = new System.Drawing.Point(78, 219);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(170, 41);
            this.Connect.TabIndex = 39;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click_1);
            // 
            // Disconnect
            // 
            this.Disconnect.BackColor = System.Drawing.Color.LightCoral;
            this.Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnect.Location = new System.Drawing.Point(253, 219);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(169, 41);
            this.Disconnect.TabIndex = 38;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = false;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click_1);
            // 
            // ResetBTN
            // 
            this.ResetBTN.Location = new System.Drawing.Point(563, 373);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(208, 41);
            this.ResetBTN.TabIndex = 44;
            this.ResetBTN.Text = "Reset";
            this.ResetBTN.UseVisualStyleBackColor = true;
            this.ResetBTN.Click += new System.EventHandler(this.ResetBTN_Click);
            // 
            // Debugging
            // 
            this.Debugging.Enabled = false;
            this.Debugging.Location = new System.Drawing.Point(1478, 36);
            this.Debugging.Name = "Debugging";
            this.Debugging.Size = new System.Drawing.Size(434, 1002);
            this.Debugging.TabIndex = 45;
            this.Debugging.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1231, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 46;
            this.label1.Text = "Font Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Debugging);
            this.Controls.Add(this.ResetBTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Above100);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ScreenShot);
            this.Controls.Add(this.DecSize);
            this.Controls.Add(this.IncSize);
            this.Controls.Add(this.WaitingPayloads);
            this.Controls.Add(this.WaitingCDA);
            this.Controls.Add(this.RPayloads);
            this.Controls.Add(this.ReleaseCDA);
            this.Controls.Add(this.Timer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ScreenShot;
        private System.Windows.Forms.Button DecSize;
        private System.Windows.Forms.Button IncSize;
        private System.Windows.Forms.Label WaitingPayloads;
        private System.Windows.Forms.Label WaitingCDA;
        private System.Windows.Forms.Button RPayloads;
        private System.Windows.Forms.Button ReleaseCDA;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Above100;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label ft;
        private System.Windows.Forms.Label CurrentHeight;
        private System.Windows.Forms.Button ShowFlightData;
        private System.Windows.Forms.Label ShowState;
        private System.Windows.Forms.Label ConnectionState;
        private System.Windows.Forms.Label BaudRata;
        private System.Windows.Forms.Label ComPort;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Disconnect;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button ResetBTN;
        private System.Windows.Forms.TextBox BaudRateTB;
        private System.Windows.Forms.TextBox COMPortTB;
        private System.Windows.Forms.RichTextBox Debugging;
        private System.Windows.Forms.Label label1;
    }
}

