using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace SimonSays
{
    public partial class MenuScreen : UserControl
    {
        System.Windows.Media.MediaPlayer backMedia = new System.Windows.Media.MediaPlayer();
        public MenuScreen()
        {
            InitializeComponent();

            backMedia.Open(new Uri(Application.StartupPath + "/Resources/Pharoahe Monch - Simon Says [Instrumental}.mp3"));
            backMedia.Play();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //TODO: remove this screen and start the GameScreen

            backMedia.Stop();
            Form1.ChangeScreen(this, new GameScreen());
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            //TODO: end the application

            Application.Exit();
        }
    }
}
