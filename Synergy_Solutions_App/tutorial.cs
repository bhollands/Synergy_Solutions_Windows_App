using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synergy_Solutions_App
{
    public partial class tutorial : Form
    {
        public tutorial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //position the form in the center of the screen
            this.Location = new Point(this.Width / 2, (this.Height / 2) - 10);
            axWindowsMediaPlayer1.settings.volume = 100;
            //on form's load auto play a tutorial video in the lanuage that was defined in the StartScreen.cs form

            if (StartScreen.lanSelect % 2 == 0)
            {
                axWindowsMediaPlayer1.URL = @"C:\Users\bear\Documents\GitHub\Synergy_Solutions_Windows_App\other\EnglishTutorial.mp4";
            }
            if (StartScreen.lanSelect % 2 == 1)
            {
                axWindowsMediaPlayer1.URL = @"C:\Users\bear\Documents\GitHub\Synergy_Solutions_Windows_App\other\SpanishTutorial.mp4";

            }

            
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            Console.WriteLine(e);
            //on event E being 1 (event one being the end of the video, exit the form)
            if (e.newState == 1) {
                Console.WriteLine("end of video");
                System.Windows.Forms.Application.ExitThread();
                this.Close();
            }
        }
    }
}
