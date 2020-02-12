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

namespace Synergy_Solutions_App
{
    public partial class Authorization : Form
    {
        Thread th;
        public Authorization()
        {
            InitializeComponent();
            label3.Text = "";
        }

        private void Password_protec_Load(object sender, EventArgs e)
        {}



        private void button1_Click(object sender, EventArgs e)
        {
            string engCode = textBox1.Text;
            string pass = textBox2.Text;
            if (auth(engCode, pass))
            {
                openMaintainceMode();
            }
            else
            {
                label3.Text = "Incorrect Credentials";
                label3.ForeColor = Color.Red;
            }
        }

        private void openMaintainceMode()
        {
            Close();
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform()
        {
            Application.Run(new MaintenceMode());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // engineer code
        {
        }

        private bool auth(string engCode, string password)
        {
            switch (engCode)
            {
                case "bh20":
                    if (password == "1234")
                    {
                        return true;
                    }
                    return false;
                case "ja57":
                    if (password == "1234")
                    {
                        return true;
                    }
                    return false;
                case "ahd1":
                    if (password == "1234")
                    {
                        return true;
                    }
                    return false;
                case "boi":
                    if (password == "")
                    {
                        return true;
                    }
                    return false;
                case "":
                    if (password == "")
                    {
                        return true;
                    }
                    return false;
                default:
                    return false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
