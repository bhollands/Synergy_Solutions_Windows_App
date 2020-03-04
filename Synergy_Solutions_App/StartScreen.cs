using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Synergy_Solutions_App
{
    public partial class StartScreen : Form
    {
        public byte alpha = 255;
        bool inOut = true;
        Thread th;
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
                    if (orignalPixel == Color.FromArgb(0, orignalPixel.R, orignalPixel.B,orignalPixel.G))
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

        public void Main() {

            while (1 == 1)
            {

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            img_arrow.Image = changeTransparacy(img_arrow.Image, alpha);

            if (inOut == true) {
                alpha -= 10;
            }
            if(inOut == false){
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
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }


        private void opennewform()
        {
            Application.Run(new UserMode());
        }
    }
}
