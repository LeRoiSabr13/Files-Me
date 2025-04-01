using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 10;
        int gravity = 15;
        int score = 0;

        bool gameOver = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -15;
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Space)
                    gravity = 15;
            }
            if (e.KeyCode == Keys.R && gameOver)
                RestartGame();
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " GAME OVER!!! Press R to Restart";
            gameOver = true;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            pipedown.Left -= pipeSpeed;
            pipeup.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (pipedown.Left < -150)
            {
                pipedown.Left = 800;
                score++;
            }
            if (pipeup.Left < -180)
            {
                pipeup.Left = 950;
            }

            if (Bird.Bounds.IntersectsWith(pipedown.Bounds) ||
               Bird.Bounds.IntersectsWith(pipeup.Bounds) ||
               Bird.Bounds.IntersectsWith(ground.Bounds) || Bird.Top < -25
               )
            {
                endGame();
            }
            if (score > 5)
            {
                pipeSpeed = 15;
            }
        }

        private void RestartGame()
        {
            gameOver = false;
            Bird.Location = new Point(12, 289);
            pipeup.Left = 800;
            pipedown.Left = 1200;

            score = 0;
            pipeSpeed = 10;
            scoreText.Text = "Score: 0";
            gameTimer.Start();
        }

        private void Bird_Click(object sender, EventArgs e)
        {

        }
    }
}

