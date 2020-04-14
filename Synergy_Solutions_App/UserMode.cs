using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
//using System.Windows.Media;

namespace Synergy_Solutions_App
{

    public partial class UserMode : Form
    {



        //setting up. scorePH should be changed to the player's score but it is set to 5555 for now
        public int scorePH = 5555;
        int letterChoice = 0;
        public int[] highScoresList = {101, 100, 99, 95, 80, 50, 10, 7, 9, 2, 1 };
        public string[] highScoreNames = {"STU_", "JO__", "GORI", "ALEX", "BER_", "AAAA", "_ZED", "CATS", "ROBB", "BEAR", "ALI_"};
        public byte AA = 255;
        private object locker = new object();
        bool holder = true;
        //Debugging string
        String dug = "hello ";

       

        Thread th;

        private static Bitmap changeTransparacy(Image image, Byte alpha, int theWidth, int theHeight)
        {
            Bitmap inputImage = new Bitmap(image);
            Bitmap outputImage = new Bitmap(image.Width, image.Height);
            System.Drawing.Color orignalPixel = System.Drawing.Color.Black;
            System.Drawing.Color newPixel = System.Drawing.Color.Black;


                for (int w = 0; w < theWidth; w++)
                {
                    for (int h = 0; h <theHeight; h++)
                    {
                        orignalPixel = inputImage.GetPixel(w, h);
                        if (orignalPixel == Color.FromArgb(0, orignalPixel.R, orignalPixel.G, orignalPixel.B))
                        {
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

        /*
        public void connectToSerial() {

                string[] ports;
                ports = SerialPort.GetPortNames();

            System.Windows.Forms.MessageBox.Show("Connected to " + ports[0]);

        }
            
    */

        

        public UserMode()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            //box holding the player's score is loaded at the end of the game as well as the high scores of other users
            scoreText.ReadOnly = true;
            scoreText.Text = scorePH.ToString();

            //connectToSerial();

            //runTimer();

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

        private void button1_Click(object sender, EventArgs e)
        {
            //can only be pressed once
            button1.Enabled = false;

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
            Thread.Sleep(1000);
            th = new Thread(loopback);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            System.Windows.Forms.Application.ExitThread();
            this.Close();
        }


            private void loopback()
        {
            Application.Run(new StartScreen());
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
        // The goal of this is to fade in and out but alas it doesn't
     /*           private void timer1_Tick(object sender, EventArgs e)
                {
                    changeTransparacy(AlienImage.Image, alienAlpha);
                    alienAlpha-=20;
                }
                
       
        public void runTimer()
        {
            System.Timers.Timer aTimer = new System.Timers.Timer(10000);

            aTimer.Elapsed += new ElapsedEventHandler(RunEvent);
            aTimer.Interval = 2;
            aTimer.Enabled = true;
            if (AA == 0)
            {
                aTimer.Stop();
            }
        }

        //This method will get called every second until the timer stops or the program exits.
        public void RunEvent(object source, ElapsedEventArgs e)
        {

            Image ph = AlienImage1.Image;
            lock (locker)
            {

              
                if (AA >= 45 )
                {
                    AA -= 30;

                    ph = changeTransparacy(ph, AA, ph.Width, ph.Height);
                    AlienImage1.Image = ph;


                }
                if(AA <=45)
                {
                    ph = changeTransparacy(ph, 0, ph.Width, ph.Height);
                    AlienImage1.Image = ph;
                    AA = 0;

                }
            }


            
        }

        /*
private void AlienImage_MouseEnter(object sender, EventArgs e)
{
   /*

   DoubleAnimation da = new DoubleAnimation
   {
       From = 0,
       To = 1,
       Duration = new Duration(TimeSpan.FromSeconds(1)),
       AutoReverse = true
   };
   Logo.BeginAnimation(OpacityProperty, da);


   Image ing = (Image)sender;
   DoubleAnimation animate = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
   ing.BeginAnimation(Opacity, animate);


  /// this.Fade(value: 0.5f, duration: 2500, delay: 250, easingType: EasingType.Default).Start();
  // await this.Fade(value: 0.5f, duration: 2500, delay: 250, easingType: EasingType.Default).StartAsync();  //Fade animation can be awaited
  */
    }
    }
//}
