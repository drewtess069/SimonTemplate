using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class GameOverScreen : UserControl
    {
        System.Windows.Media.MediaPlayer backMedia = new System.Windows.Media.MediaPlayer();
        public GameOverScreen()
        {
            InitializeComponent();

            backMedia.Open(new Uri(Application.StartupPath + "/Resources/Pharoahe Monch - Simon Says [Instrumental}.mp3"));
            backMedia.Play();
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            //TODO: show the length of the pattern

            lengthLabel.Text = $"{Form1.pattern.Count}";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //TODO: close this screen and open the MenuScreen

            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
