using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace Synergy_Solutions_App
{
    public partial class StartScreen : Form
    {
        //all displayed text with a lanuage select varible
        int lanSelect = 0;
        String readyFReady = "Ready";
        String readyFGo = "Go";
        String loadingText = "Loading";

        //fade for the image
        public byte alpha = 255;
        bool inOut = true;

        //thread to move into UI mode
        Thread thUI;

        private static Bitmap changeTransparacy(Image image, Byte alpha)
        {
            Bitmap inputImage = new Bitmap(image);
            Bitmap outputImage = new Bitmap(image.Width, image.Height);
            System.Drawing.Color orignalPixel = System.Drawing.Color.Black;
            System.Drawing.Color newPixel = System.Drawing.Color.Black;


            for (int w = 0; w < image.Width; w++)
            {
                for (int h = 0; h < image.Height; h++)
                {
                    orignalPixel = inputImage.GetPixel(w, h);
                    if (orignalPixel == Color.FromArgb(0, orignalPixel.R, orignalPixel.B, orignalPixel.G))
                    {
                        continue;
                    }
                    else
                    {
                        newPixel = Color.FromArgb(alpha, orignalPixel.R, orignalPixel.B, orignalPixel.G);

                        outputImage.SetPixel(w, h, newPixel);
                    }
                }

            }


            return outputImage;
        }

        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            int getScreenWidth = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            int getScreenHight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;

            //set UI to screen size and put it in top corner of screen and to size of the screen
            this.ClientSize = new System.Drawing.Size(getScreenWidth, getScreenHight);
            this.Location = new Point(0, 0);

            //update UI
            manualUIUpdate();
            
        }

        //manually move UI elements
        public void manualUIUpdate() {

            startGame.Location = new Point(centerElementXcor(startGame.Location.X, startGame.Size.Width)
                , centerElementYcor(startGame.Location.Y, startGame.Size.Height));
            startGame.Refresh();

            img_action.Location = new Point(centerElementXcor(img_action.Location.X, img_action.Size.Width)
                , centerElementYcor(img_action.Location.Y, img_action.Size.Height));
            img_action.Refresh();

            img_arrow.Location = new Point(centerElementXcor(img_arrow.Location.X, img_arrow.Size.Width)
                , centerElementYcor(img_arrow.Location.Y, img_arrow.Size.Height));
            img_arrow.Refresh();

            img_button.Location = new Point(centerElementXcor(img_button.Location.X, img_button.Size.Width)
                , centerElementYcor(img_button.Location.Y, img_button.Size.Height));
            img_button.Refresh();

            instruction.Location = new Point(centerElementXcor(instruction.Location.X, instruction.Size.Width)
                , centerElementYcor(instruction.Location.Y, instruction.Size.Height));
            instruction.Refresh();

            action.Location = new Point(centerElementXcor(action.Location.X, action.Size.Width)
                , centerElementYcor(action.Location.Y, action.Size.Height));
            instruction.Refresh();

            int bottomCW = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - lanuage.Size.Width);
            int bottomCH = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - lanuage.Size.Height);

            lanuage.Location = new Point(bottomCW,bottomCH);
            lanuage.Refresh();
        }

        private int centerElementXcor(int Xcor, int elementWidth)
        {



            Xcor = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width / 2) - (elementWidth/2);
            return Xcor;
        }

        private int centerElementYcor(int Ycor, int elementHight)
        {
            Ycor = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height / 2) - (elementHight / 2);
            return Ycor;
        }

        //timer to fade arrow in and out on start screen
        private void timer1_Tick(object sender, EventArgs e)
        {
            img_arrow.Image = changeTransparacy(img_arrow.Image, alpha);

            if (inOut == true) {
                alpha -= 10;
            }
            if (inOut == false) {
                alpha += 10;
            }

            if (alpha < 10) {
                inOut = false;
            }
            if (alpha > 240) {
                inOut = true;
            }

        }


        private void startGame_Click(object sender, EventArgs e)
        {
            img_arrow.Visible = false;
            img_button.Visible = false;
            startGame.Visible = false;
            Thread.Sleep(300);
            runGame();
        }


        private void runGame()
        {
            
            String[] instructions = loadActions();
            int numInstructions = instructions.Length;

            ready321();
            instruction.Visible = true;
            instruction.Refresh();
            for (int dis = 0; dis < numInstructions; dis++) {

                instruction.Text = instructions[dis];
                instruction.Refresh();
                Thread.Sleep(1000);

            }

            openUI();
            this.Close();


        }

        //dummy method to load data from MBED
        private string[] loadActions() {
            Stopwatch timingP = new Stopwatch();
            action.Text = loadingText;
            action.Visible = true;
            img_action.Image = Synergy_Solutions_App.Properties.Resources.ufo;
            img_action.Visible = true;
            img_action.Refresh();
            action.Refresh();

            timingP.Start();
            String[] instructionsFromMBED = getActionsFromSerial();
            timingP.Stop();

            Console.WriteLine(timingP.ElapsedMilliseconds);

            int timeoutTime = 1000;
            timeoutTime -= unchecked((int)timingP.ElapsedMilliseconds);
            Thread.Sleep(timeoutTime);
            Console.WriteLine(timeoutTime);

            action.Visible = false;
            img_action.Visible = false;
            action.Refresh();
            img_action.Refresh();

            return instructionsFromMBED;
        }

        private string[] getActionsFromSerial() {
            int numOfCommands = 4;
            string[] MBEDcommands = new string[numOfCommands];

            /*
            for (int c = 0; c < numOfCommands;) { 
                
                MBEDcommands[c] = 
            
            }
            */
            MBEDcommands[0] = "button1";
            MBEDcommands[1] = "sliderUp";
            MBEDcommands[2] = "sliderDown";
            MBEDcommands[3] = "button1";

            return MBEDcommands;
        }


        private void ready321(){

            action.Text = readyFReady;
            action.Visible = true;
            action.Refresh();


            for (int t = 3; t > -1; t--) {

                if (t != 0)
                {
                    instruction.Text = t.ToString();
                }
                else
                {
                    instruction.Text = readyFGo;
                }

                instruction.Visible = true;
                instruction.Refresh();
                Thread.Sleep(1000);
            }

            instruction.Visible = false;
            action.Visible = false;
            action.Refresh();
            instruction.Refresh();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            openUI();
        }

        private void openUI() {

            thUI = new Thread(opennewform);
            thUI.SetApartmentState(ApartmentState.STA);
            thUI.Start();

        }

        private void opennewform()
        {
            Application.Run(new UserMode());
        }

        private void lanuage_Click(object sender, EventArgs e)
        {
            Console.WriteLine("mee");
            lanSelect++;
            if (lanSelect == 0) {
                startGame.Text = "Start Game";
                readyFGo = "Go";
                readyFReady = "Ready";
                loadingText = "Loading";
            
            }
            if (lanSelect == 1) {
                startGame.Text = "Start Game in Spanish";
                readyFReady = "Ready in Spanish";
                readyFGo = "Go in Spanish";
                loadingText = "Loading in Spanish";

                lanSelect = 0;
            
            }
            
        }

        private void img_arrow_Click(object sender, EventArgs e)
        {

        }
    }
}
