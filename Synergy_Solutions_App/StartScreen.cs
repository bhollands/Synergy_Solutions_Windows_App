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
        public byte alpha = 255;
        string[] actions = { null, null, null, null };
        bool inOut = true;
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

        }

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
            loadActions();
            runGame();
        }

        private void runGame()
        {
            ready321();


        }

        private void loadActions() {
            Stopwatch timingP = new Stopwatch();
            action.Visible = true;
            img_action.Image = Synergy_Solutions_App.Properties.Resources.ufo;
            img_action.Visible = true;
            img_action.Refresh();
            action.Refresh();

            timingP.Start();
            getActionsFromSerial();
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

        }

        private void getActionsFromSerial() {

            Thread.Sleep(250);

        }

        private void ready321(){

            action.Text = "Ready?";
            action.Visible = true;
            action.Refresh();


            for (int t = 3; t > -1; t--) {

                if (t != 0)
                {
                    instruction.Text = t.ToString();
                }
                else
                {
                    instruction.Text = "Go!";
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
            thUI = new Thread(opennewform);
            thUI.SetApartmentState(ApartmentState.STA);
            thUI.Start();
        }

        private void opennewform()
        {
            Application.Run(new UserMode());
        }
    }
}
