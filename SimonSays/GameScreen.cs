using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Xml.Schema;
using System.Net.Sockets;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //TODO: create an int guess variable to track what part of the pattern the user is at
        //int guess = 0;
        Random randGen = new Random();
        int buttonTime = 500;

        SoundPlayer greenPlayer = new SoundPlayer(Properties.Resources.green);
        SoundPlayer redPlayer = new SoundPlayer(Properties.Resources.red);
        SoundPlayer yellowPlayer = new SoundPlayer(Properties.Resources.yellow);
        SoundPlayer bluePlayer = new SoundPlayer(Properties.Resources.blue);
        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(15, 15, 200, 204);
            Region buttonRegion = new Region(circlePath);

            greenButton.Region = buttonRegion;
            Matrix transformMatrix = new Matrix();
            transformMatrix.RotateAt(90, new PointF(61,61));
            buttonRegion.Transform(transformMatrix);

            redButton.Region = buttonRegion;

            transformMatrix.RotateAt(90, new PointF(61, 61));
            buttonRegion.Transform(transformMatrix);

            yellowButton.Region = buttonRegion;

            transformMatrix.RotateAt(90, new PointF(61, 61));
            buttonRegion.Transform(transformMatrix);

            blueButton.Region = buttonRegion;

            //TODO: clear the pattern list from form1
            Form1.pattern.Clear();

            //TODO: refresh
            this.Refresh();

            //TODO: pause for a bit
            Thread.Sleep(1000);

            //TODO: run ComputerTurn()
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            levelLabel.Text = $"{Form1.guess + 1}";

            Refresh();
            Thread.Sleep(250);

            //TODO: get rand num between 0 and 4 (0, 1, 2, 3) and add to pattern list. Each number represents a button. For example, 0 may be green, 1 may be blue, etc.
            Form1.pattern.Add(randGen.Next(0, 4));

            //TODO: create a for loop that shows each value in the pattern by lighting up approriate button
            for (int i = 0; i < Form1.pattern.Count; i++)
            {
                if (Form1.pattern[i] == 0)
                {
                    greenButton.BackColor = Color.Lime;
                    greenPlayer.Play();
                }
                else if (Form1.pattern[i] == 1)
                {
                    redButton.BackColor = Color.Red;
                    redPlayer.Play();
                }
                else if (Form1.pattern[i] == 2)
                {
                    yellowButton.BackColor = Color.Yellow;
                    yellowPlayer.Play();
                }
                else
                {
                    blueButton.BackColor = Color.Blue;
                    bluePlayer.Play();
                }

                Refresh();
                Thread.Sleep(buttonTime);

                greenButton.BackColor = Color.ForestGreen;
                redButton.BackColor = Color.DarkRed;
                yellowButton.BackColor = Color.Goldenrod;
                blueButton.BackColor = Color.DarkBlue;

                Refresh();
                Thread.Sleep(buttonTime);
            }
            //TODO: set guess value back to 0
            Form1.guess = 0;
        }

        //TODO: create one of these event methods for each button
        private void greenButton_Click(object sender, EventArgs e)
        {
            greenPlayer.Play();

            //TODO: is the value in the pattern list at index [guess] equal to a green?
            // change button color
            // play sound
            // refresh
            // pause
            // set button colour back to original
            // add one to the guess variable

            if (Form1.pattern[Form1.guess] == 0)
            {
                greenButton.BackColor = Color.Lime;
                this.Refresh();
                Thread.Sleep(buttonTime);
                greenButton.BackColor = Color.ForestGreen;
                this.Refresh();
                Form1.guess++;
                Thread.Sleep(buttonTime);
            }
            else
            {
                GameOver();
            }


            //TODO:check to see if we are at the end of the pattern, (guess is the same as pattern list count).
            // call ComputerTurn() method

            if (Form1.guess == Form1.pattern.Count)
            {
                ComputerTurn();
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            redPlayer.Play();

            //TODO: is the value in the pattern list at index [guess] equal to a green?

            if (Form1.pattern[Form1.guess] == 1)
            {
                redButton.BackColor = Color.Red;
                this.Refresh();
                Thread.Sleep(buttonTime);
                redButton.BackColor = Color.DarkRed;
                this.Refresh();
                Form1.guess++;
                Thread.Sleep(buttonTime);
            }
            else //if (Form1.pattern[guess] != 1)
            {
                GameOver();
            }


            //TODO:check to see if we are at the end of the pattern, (guess is the same as pattern list count).

            if (Form1.guess == Form1.pattern.Count)
            {
                ComputerTurn();
            }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            yellowPlayer.Play();

            //TODO: is the value in the pattern list at index [guess] equal to a green?

            if (Form1.pattern[Form1.guess] == 2)
            {
                yellowButton.BackColor = Color.Yellow;
                this.Refresh();
                Thread.Sleep(buttonTime);
                yellowButton.BackColor = Color.Goldenrod;
                this.Refresh();
                Form1.guess++;
                Thread.Sleep(buttonTime);
            }
            else
            {
                GameOver();
            }


            //TODO:check to see if we are at the end of the pattern, (guess is the same as pattern list count).
            if (Form1.guess == Form1.pattern.Count)
            {
                ComputerTurn();
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            bluePlayer.Play();

            //TODO: is the value in the pattern list at index [guess] equal to a green?
            if (Form1.pattern[Form1.guess] == 3)
            {
                blueButton.BackColor = Color.Blue;
                this.Refresh();
                Thread.Sleep(buttonTime);
                blueButton.BackColor = Color.DarkBlue;
                this.Refresh();
                Form1.guess++;
                Thread.Sleep(buttonTime);
            }
            else
            {
                GameOver();
            }

            //TODO:check to see if we are at the end of the pattern, (guess is the same as pattern list count).
            if (Form1.guess == Form1.pattern.Count)
            {
                ComputerTurn();
            }
        }
        public void GameOver()
        {
            //TODO: Play a game over sound
            SoundPlayer gameOverPlayer = new SoundPlayer(Properties.Resources.mistake);
            gameOverPlayer.Play();

            //TODO: close this screen and open the GameOverScreen
            Form1.ChangeScreen(this, new GameOverScreen());
        }
    }
}
