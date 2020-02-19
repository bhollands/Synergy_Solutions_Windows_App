using System;
using System.Threading;
using System.Windows.Forms;




namespace Synergy_Solutions_App
{

    public partial class UserMode : Form
    {
        public int scorePH = 5555;
        int letterChoice = 0;
        public int[] highScoresList = {9999, 100, 99, 95, 80, 50, 10, 7, 9, 2, 1 };
        public string[] highScoreNames = {"STU_", "JO__", "GORI", "ALEX", "BER_", "AAAA", "_ZED", "CATS", "ROBB", "BEAR", "ALI_"};
      

        Thread th;
        public UserMode()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            scoreText.ReadOnly = true;
            scoreText.Text = scorePH.ToString();

            for (int k = 0; k <= 10; k++) {
                highScores.Items.Add(highScoreNames[k] + "         " + highScoresList[k].ToString());
            }

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
                if (scorePH >= highScoresList[j]) {

                    for (int l = 1; l < (listLength - j); l++)
                    {
                         highScoresList[listLength - l] = highScoresList[listLength - 1 - l];
                        highScoreNames[listLength - l] = highScoreNames[listLength - 1 - l];
                        // = -2;
                    }


                    highScoresList[j] = scorePH;
                    highScoreNames[j] = userName;
                    break;
                }

            }

           highScores.Items.Clear();

            for (int k = 0; k <= 10; k++)
            {

                string nameAndScoreTogether = highScoreNames[k] + "         " + highScoresList[k].ToString();

                highScores.Items.Add(nameAndScoreTogether);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (letterChoice)
            {

                case 0:
                    letter1.UpButton();
                    break;
                case 1:
                    letter2.UpButton();
                    break;
                case 2:
                    letter3.UpButton();
                    break;
                case 3:
                    letter4.UpButton();
                    break;
                default:
                    Console.WriteLine("out of letters");
                    letterChoice = 0;
                    break;


            }
        }

        private void debugButton2_Click(object sender, EventArgs e)
        {


                switch (letterChoice)
                {
                    
                case 0:
                    letter1.DownButton();
                    break;
                case 1:
                    letter2.DownButton();
                    break;
                case 2:
                    letter3.DownButton();
                    break;
                case 3:
                    letter4.DownButton();
                    break;
                default:
                    Console.WriteLine("out of letters");
                    letterChoice = 0;
                    break;
            
            
                }


      
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            letterChoice++;
        }
    }
}
