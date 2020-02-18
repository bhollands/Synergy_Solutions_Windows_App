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
        public int scorePH = 5555;
        public int[] highScoresList = {9999, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        Thread th;
        public UserMode()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            scoreText.ReadOnly = true;
            scoreText.Text = scorePH.ToString();

            highScores.Items.Add("hello");

            for (int k = 0; k <= 10; k++) {
                highScores.Items.Add(highScoresList[k].ToString());
            }

            highScores.Items.Add("goodbye");

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

        private void button1_Click(object sender, EventArgs e)
        {
            int listLength = highScoresList.Length;
            string userName = " ";
            string[] letterList = { letter1.Text, letter2.Text, letter3.Text, letter4.Text };
            for (int i = 0; i < 4; i++) {
                userName = userName + letterList[i];
            }

           


            for (int j = 0; j < listLength; j++)
            {
                //highScoresList[j] = 22;
                int checker = 99;
                if (checker >= highScoresList[j]) {

                    for (int l = 1; l < (listLength - j); l++)
                    {
                        highScoresList[listLength - 1] = -1;
                        highScoresList[listLength - l] = -2;
                    }


                    highScoresList[j] = checker;
                    break;
                }

            }

           highScores.Items.Clear();

            for (int k = 0; k <= 10; k++)
            {
                highScores.Items.Add(highScoresList[k].ToString());
            }

        }


    }
}
