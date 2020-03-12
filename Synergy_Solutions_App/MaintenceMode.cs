using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;


namespace Synergy_Solutions_App
{ 

    public partial class MaintenceMode : Form
    {
        bool isConnected = false;
        string lastWritten;
        string rxType;
        string log;
        bool requestSent = false;
        string a = "Inactive";
        Thread th;
        bool switch1Active = false;
        bool switch2Active = false;
        bool switch3Active = false;

        public MaintenceMode()
        {
            InitializeComponent();
            readOnly();
            getComPorts();
            TX_traffic_window.ReadOnly = true;
            TX_traffic_window.BackColor = Color.White;
        }

        private void readOnly()
        {
            TextBox[] textBox = {button1Text,switch1, switch2, slider1,
                                slider2, LEDbox1, LEDbox4,Connection_window, LEDbox6, LEDbox5, LEDbox7,
                                LEDbox3, LEDbox2, distTextBox};
            foreach (TextBox textbox in textBox)
            {
                textbox.ReadOnly = true;
            }
        }
        
        void getComPorts()
        {
            string[] ports;
            ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox1.SelectedItem = ports[0];
                }
            }
        }

        private void shitGoBakcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void opennewform()
        {
            Application.Run(new UserMode());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            switch1.Text = a;
        }

        private void writeToPort(string id, int deviceNo, string data,  int direction) //direction just for DC motors
        {
            string mesg = "#" + id + ":" + deviceNo + ":" + data + ":" + direction +";";
            try
            {
                port.Write(mesg);
                lastWritten = mesg;
                logTraffic(TX_traffic_window, mesg, Color.Black);
            }
            catch (Exception e)
            {
                string send = "ERROR: "+ e.Message ;
                logTraffic(Debug_W, send, Color.Red);
                return;
            }

            
        }

        private int[] getPacket(string buffer)
        {
            char[] bufferArray = buffer.ToCharArray();

            int[] returnArray = {0,0};
            for (int i = 0; i < bufferArray.Length; i++)
            {
                if (bufferArray[i] == '#')
                {
                    returnArray[0] = i;
                }
                if (bufferArray[i] == ':')
                {
                    returnArray[1] = i;
                    break;
                }
            }
            return returnArray;
        }
        
/*        private string readFromPort()
        {
            try
            {
                string lastRecived = port.ReadExisting().ToString();
                Console.WriteLine(lastRecived);
                logTraffic(RX_traffic_window, lastRecived, Color.Black);
                return lastRecived; 
            }
            catch(Exception e)
            {
                string send = "ERROR: " + e.Message + e.StackTrace;
                logTraffic(Debug_W, send, Color.Red);
                return "Null";
            }
        }*/

        private string GetTimeStamp(DateTime value)
        {
            return value.ToString("HH:mm:ss");
        }

        bool grey = false;
        private void logTraffic(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            //string time = GetTimeStamp(DateTime.Now) + " | ";
            box.AppendText(text+Environment.NewLine);
            if (grey == true)
            {
                box.SelectionBackColor = Color.White;
                grey = false;
            }
            else
            {
                box.SelectionBackColor = Color.LightGray;
                grey = true;
            }
            box.SelectionColor = box.ForeColor;
            box.ScrollToCaret();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            ledButton(1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ledButton(2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ledButton(3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ledButton(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ledButton(5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ledButton(6);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ledButton(7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ledButton(int no)
        {
            TextBox[] ledBox = {LEDbox1, LEDbox2, LEDbox3, LEDbox4,
                                LEDbox5, LEDbox6, LEDbox7, LEDbox8};
            string Oncommand = no + "ON;";
            string OFFcommand = no + "OF;";
            TextBox activeBox;
            activeBox = ledBox[no-1];

            if (isConnected && activeBox.Text != "Active")
            {
                writeToPort("l",no,1.ToString(),0);
                activeBox.Text = "Active";
            }
            else
            {
                writeToPort("l",no,0.ToString(),0);
                activeBox.Text = "Inactive";
            }
        }
    
        private void button5_Click_1(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connect();
                
            }
            else
            {
                disconnect();
            }

        }
        private void connect()
        {

            
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            Connection_window.Text = "";
 
            Connection_window.AppendText("Selected COM Port = " + selectedPort + Environment.NewLine);
            Connection_window.AppendText("Trying to open " + selectedPort + Environment.NewLine);
            try
            {
                isConnected = true;
                port.PortName = selectedPort;
                port.Open();
                string start = "#STAR\n";
                port.Write(start);
                port.ReadExisting();
                logTraffic(TX_traffic_window, start, Color.Black);
                connectBtn.Text = "Disconnect";
                Connection_window.AppendText("--------------------------------------" + Environment.NewLine);
            }
            catch
            {
                Connection_window.AppendText("Cannot open " + selectedPort + Environment.NewLine);
                return;
            }
            Connection_window.AppendText(selectedPort + " now open" + Environment.NewLine);
            Connection_window.AppendText("--------------------------------------" + Environment.NewLine);
        }

        private void disconnect()
        {
            try
            {
                isConnected = false;
                port.Write("#STOP\n");
                port.Close();
                connectBtn.Text = "Connect";
            }
            catch
            {
                return;
            }

            Connection_window.AppendText(port.PortName + " is now closed" + Environment.NewLine);
            Connection_window.AppendText("--------------------------------------" + Environment.NewLine);

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void dist_button_Click(object sender, EventArgs e)
        {
            writeRequest("d",0);
        }

        private void writeRequest(string key, int no)
        {
            try
            {
                string mesg = "#" + key +":"+ no + ";";
                port.Write(mesg);
                requestSent = true;
                logTraffic(TX_traffic_window, mesg, Color.Black);
            }
            catch(Exception e)
            {
                logTraffic(Debug_W, e.Source+"Error: :" + e.Message,Color.Red);
            }

        }

        private string getData(string lastRecived)
        {
            try
            {
                int srt_pos = lastRecived.IndexOf(":") + 1;
                int end_pos = lastRecived.IndexOf(";");
                int goToPos = end_pos - srt_pos;
                string data = lastRecived.Substring(srt_pos, goToPos);
                return data;
            }
            catch
            {
                return null;
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void TX_Clear_Click(object sender, EventArgs e)
        {
            TX_traffic_window.Text = "";
        }

        private void RX_Clear_Click(object sender, EventArgs e)
        {
            RX_traffic_window.Text = "";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void servo_btn_Click(object sender, EventArgs e)
        {
            int servoNo = (int)ServoNumber.Value;
            string servoAngle = servoAngel.Value.ToString();
            writeToPort("s",servoNo, servoAngle, 0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void MotorBtn_CLick(object sender, EventArgs e)
        {
            int mtrNo = (int)motorNo.Value;
            string speed = motorSpeed.SelectedIndex.ToString();
            int direction = DCdirection.SelectedIndex + 1;

            writeToPort("m",mtrNo,speed, direction);
        }

        private void LEDbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void control_panel_Read(object sender, EventArgs e)
        { 
           // readFromPort();
        }

        TextBox textBox;
        private void serial_data_in(object sender, SerialDataReceivedEventArgs e)
        {

            string txt = port.ReadExisting().ToString();
            textBoxDetermin(txt);
            SetText(txt.ToString());
        }
        bool switchActive;
        private void textBoxDetermin(string txt)
        {
            if (txt.Contains("d"))
            {
                textBox = distTextBox;
            }
            else if (txt.Contains("ldr1"))
            {
                textBox = LDR1;
                if (switchActive)
                {
                    switchActive = false;
                }
                else
                {
                    switchActive = true;
                }
            }
            else if (txt.Contains("ldr2"))
            {
                textBox = LDR2;
                if (switchActive)
                {
                    switchActive = false;
                }
                else
                {
                    switchActive = true;
                }
            }
            else if (txt.Contains("ldr3"))
            {
                textBox = LDR3;
            }
            else if (txt.Contains("ldr4"))
            {
                textBox = LDR4;
            }
            else if (txt.Contains("ldr5"))
            {
                textBox = LDR5;
            }
            else if (txt.Contains("ldr6"))
            {
                textBox = LDR6;
            }
            else if (txt.Contains("sw1"))
            {
                textBox = switch1;
                if (switchActive)
                {
                    switchActive = false;
                }
                else
                {
                    switchActive = true;
                }
                
               // switch1Active = true;
            }
            else if (txt.Contains("sw2"))
            {
                textBox = switch2;
                if (switchActive)
                {
                    switchActive = false;
                }
                else
                {
                    switchActive = true;
                }
                

            }
            else if (txt.Contains("sw3"))
            {
                textBox = button1Text;
                if (switchActive)
                {
                    switchActive = false;
                }
                else
                {
                    switchActive = true;
                }
                
               // switch3Active = true;
            }
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            ledButton(8);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            for (int i = 3; i < 7; i++)
            {
                writeRequest("l", i);
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            try
            {
                if (this.textBox.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    logTraffic(RX_traffic_window, text, Color.Black);
                    if (switchActive == false) // if its not a switch
                    {
                        string displayText = getData(text);

                        if (text.Contains("sw") || text.Contains("ldr"))//if last recived is a switch
                        {
                            this.textBox.Text = "Inactive";
                        }
                        else
                        {
                            this.textBox.Text = displayText;
                        }
                    }
                    else
                    {
                        this.textBox.Text = "Active";
                    }
                }
            }
            catch
            {

            }



                
            }
        }
    }
