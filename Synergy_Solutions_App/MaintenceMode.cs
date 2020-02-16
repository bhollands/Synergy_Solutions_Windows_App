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
 
        
        //*********************************
        // Constant Definitions
        //*********************************
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
                                textBox6, textBox7, textBox8,Dbug_window, textBox10, textBox11, textBox12,
                                textBox13, textBox14,};
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
            //UserMode um = new UserMode();
            //um.Show();


/*            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();*/
        }

        private void opennewform()
        {
            Application.Run(new UserMode());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
           // port.Write("#LED1OF\n");

            if (isConnected && "#LED1ON\n" != lastWritten)
            {
                writeToPort("#LED1ON\n");
                textBox7.Text = "Active";
                //port.Write("#LED1ON\n");
            }
            else
            {
                writeToPort("#LED1OF\n");
                textBox7.Text = "Inactive";
            }
        }

        string lastWritten;
        private void writeToPort(string mesg)
        {
            try
            {
                port.Write(mesg);
                lastWritten = mesg;
            }
            catch (System.InvalidOperationException)
            {
                
                string send = GetTimeStamp(DateTime.Now) + " | " + "ERROR: No Connected Port" + Environment.NewLine;
                AppendText(rich_traffic_window, send, Color.Red);
                return;
            }

            
            string sent = GetTimeStamp(DateTime.Now)+ " | " +port.PortName + "_Tx: " + mesg + Environment.NewLine;
            AppendText(rich_traffic_window, sent, Color.Black);
            //traffic_window.AppendText(port.PortName+"_Tx: "+mesg+Environment.NewLine);
        }

        private string GetTimeStamp(DateTime value)
        {
            return value.ToString("HH:mm:ss");
        }
/*        private void toLog(string toPost)
        {
            string newLine = Environment.NewLine;
            string time = GetTimeStamp(DateTime.Now);
            logString = logString.Insert(0, time + " | " + toPost + newLine);
            textBox1.Text = logString;
        }*/

        private void AppendText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

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

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void rich_traffic_window_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
