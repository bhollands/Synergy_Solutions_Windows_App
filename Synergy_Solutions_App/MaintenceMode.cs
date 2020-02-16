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
        string log;

        Thread th;

        public MaintenceMode()
        {
            InitializeComponent();
            readOnly();
            getComPorts();
            rich_traffic_window.ReadOnly = true;
            rich_traffic_window.BackColor = Color.White;

        }

        private void readOnly()
        {
            TextBox[] textBox = {textBox1, textBox2, textBox3, textBox4, textBox5,
                                textBox6, LEDbox1, LEDbox4,Dbug_window, LEDbox6, LEDbox5, LEDbox7,
                                LEDbox3, LEDbox2,};
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

        }




        private void writeToPort(string mesg)
        {
            try
            {
                port.Write(mesg);
                lastWritten = mesg;
            }
            catch (System.InvalidOperationException)
            {
                
                string send = "ERROR: No Connected Port";
                logTraffic(rich_traffic_window, send, Color.Red);
                return;
            }

            string sent = port.PortName + "_Tx: " + mesg;
            logTraffic(rich_traffic_window, sent, Color.Black);
        }

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
                grey = true; ; ;
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
                                LEDbox5, LEDbox6, LEDbox7};
            string Oncommand = "#LED" + no + "ON\n";
            string OFFcommand = "#LED" + no + "OF\n";
            TextBox activeBox;
            activeBox = ledBox[no-1];

            if (isConnected && Oncommand != lastWritten)
            {
                writeToPort(Oncommand);
                activeBox.Text = "Active";
            }
            else
            {
                writeToPort(OFFcommand);
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

            isConnected = true;
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            Dbug_window.Text = "";
 
            Dbug_window.AppendText("Selected COM Port = " + selectedPort + Environment.NewLine);
            try
            {
                Dbug_window.AppendText("Trying to open " + selectedPort + Environment.NewLine);
                port.PortName = selectedPort;
                port.Open();
                port.Write("#STAR\n");
                connectBtn.Text = "Disconnect";
                Dbug_window.AppendText("--------------------------------------" + Environment.NewLine);
            }
            catch
            {
                Dbug_window.AppendText("Cannot open " + selectedPort + Environment.NewLine);
                return;
            }
            Dbug_window.AppendText(selectedPort + " now open" + Environment.NewLine);
            Dbug_window.AppendText("--------------------------------------" + Environment.NewLine);
        }

        private void disconnect()
        {
            isConnected = false;
            port.Write("#STOP\n");
            port.Close();
            connectBtn.Text = "Connect";
            //disableControls();
            //resetDefaults();
            Dbug_window.AppendText(port.PortName + " is now closed" + Environment.NewLine);
            Dbug_window.AppendText("--------------------------------------" + Environment.NewLine);

        }
    }
}
