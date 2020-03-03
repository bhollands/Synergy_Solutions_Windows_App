using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Timers;





namespace Synergy_Solutions_App
{

    public partial class UserMode : Form
    {

        //setting up. scorePH should be changed to the player's score but it is set to 5555 for now
        public int scorePH = 5555;
        int letterChoice = 0;
        public int[] highScoresList = { 101, 100, 99, 95, 80, 50, 10, 7, 9, 2, 1 };
        public string[] highScoreNames = { "STU_", "JO__", "GORI", "ALEX", "BER_", "AAAA", "_ZED", "CATS", "ROBB", "BEAR", "ALI_" };
        public byte alienAlpha = 255;
        
        Thread th;
        public bool grey;

        //Method to change the alpha value of a chosen image
        public static Bitmap changeTransparacy(Image image, Byte alpha)
        {
            Bitmap inputImage = new Bitmap(image);
            Bitmap outputImage = new Bitmap(image.Width, image.Height);
            Color orignalPixel = Color.Black;
            Color newPixel = Color.Black;


            for (int w = 0; w < image.Width; w++)
            {
                for (int h = 0; h < image.Height; h++)
                {
                    orignalPixel = inputImage.GetPixel(w, h);
                    if (orignalPixel == Color.FromArgb(0,orignalPixel.R,orignalPixel.G,orignalPixel.B)) { 
                        continue;
                    }
                    else
                    {
                        newPixel = Color.FromArgb(alpha, orignalPixel.R, orignalPixel.G, orignalPixel.B);

                        outputImage.SetPixel(w, h, newPixel);
                    }
                }

            }

            return outputImage;
        }


        private void logTraffic(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            //string time = GetTimeStamp(DateTime.Now) + " | ";
            box.AppendText(text + Environment.NewLine);
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

            public UserMode()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //box holding the player's score is loaded at the end of the game as well as the high scores of other users
            scoreText.ReadOnly = true;
            scoreText.Text = scorePH.ToString();

            
            //InitTimer();

            //labelName.BackColor = System.Drawing.Color.Transparent;

            for (int k = 0; k <= 10; k++) {
                highScores.Items.Add(highScoreNames[k] + "         " + highScoresList[k].ToString());
            }
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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

           

            //initializing everything 
            int listLength = highScoresList.Length;
            string userName = " ";

            //on click read in all the letters and write them into the user name variable
            string[] letterList = { letter1.Text, letter2.Text, letter3.Text, letter4.Text };

            for (int i = 0; i < 4; i++) {
                userName = userName + letterList[i];
            }

           

            //go down the high scores and check to see if the player's score is a high score if it is add it to the leader board in
            //the correct place (PLAYER NAME       PLAYER SCORE)
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

            //update the scoreboard to show the new order
           highScores.Items.Clear();

            for (int k = 0; k <= 10; k++)
            {

                string nameAndScoreTogether = highScoreNames[k] + "         " + highScoresList[k].ToString();

                highScores.Items.Add(nameAndScoreTogether);

            }

        }
        //button to move through letters in the options box (will be implimented into a hardware button soon)
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
        //button to move through letters in the options box (will be implimented into a hardware button soon)
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
        //button to move into the next letter selection
        private void button2_Click_1(object sender, EventArgs e)
        {
            letterChoice++;
        }

        private void maintenceModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
