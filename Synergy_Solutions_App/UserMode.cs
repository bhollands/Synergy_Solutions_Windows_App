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
    public partial class UserMode : Form
    {
       

        Thread th;
        public UserMode()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int scorePH = 5555;
            scoreText.ReadOnly = true;
            scoreText.Text = scorePH.ToString();

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void maintainceModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform()
        {
            Application.Run(new Authorization());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
