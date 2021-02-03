using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superjump
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, jumping, isGameOver;
        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;
        int enemyOneSpeed = 5;
        int enemyTwoSpeed = 3;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "score:" + score;
            player.Top += jumpSpeed;
            if(goLeft == true)
            {
                player.Left -= playerSpeed;
            }
            if(goRight == true)
            {
                player.Left += playerSpeed;
            }
            if(jumping == true &&force < 0)
            {
                jumping = false;
            }
            if(jumping == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if((string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;
                        }
                        x.BringToFront();
                    }
                    if((string)x.Tag =="coin")
                    {
                        if(player.Bounds.IntersectsWith(x.Bounds)&& x.Visible == true)
                        {
                            x.Visible = false;
                            score++;
                        }
                    }
                    if((string)x.Tag == "enemy")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameTimer.Stop();
                            isGameOver = true;
                            txtScore.Text = "Score: " + score + Environment.NewLine + "you got killed!!";
                        }
                    }
                }
            }
            enemyOne.Left -= enemyOneSpeed;
            if(enemyOne.Left<pictureBox2.Left || enemyOne.Left + enemyOne.Width > pictureBox2.Left + pictureBox2.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;
            }
            enemyTwo.Left -= enemyTwoSpeed;
            if (enemyTwo.Left < pictureBox4.Left || enemyTwo.Left + enemyTwo.Width > pictureBox4.Left + pictureBox4.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
            }
            if(player.Top + player.Height> this.ClientSize.Height + 50)
            {
                gameTimer.Stop();
                isGameOver = true;
                txtScore.Text = "Score: " + score + Environment.NewLine + "you dead falling!";
            }
            if(player.Bounds.IntersectsWith(door.Bounds)&& score == 3)
            {
                gameTimer.Stop();
                isGameOver = true;
                txtScore.Text = "Score: " + Environment.NewLine + "GRATZ WINNING!";

            }
            
        }

        private void player_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void keyisDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if(e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void keyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if(jumping == true)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                RestartGame();
            }

        }
        private void RestartGame()
        {

        
            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            score = 0;
            txtScore.Text = "score:" + score;
            foreach (Control x in this.Controls)
            { if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }
            player.Left= 71;
            player.Top= 466;

            enemyOne.Left = 504;
            enemyTwo.Left = 504;

            gameTimer.Start();
        }
    }
}
