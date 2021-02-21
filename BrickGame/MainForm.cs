using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09725060HSHuangAss05BrickGame
{
    
    public partial class MainForm : Form
    {
        int numRow;
        int numCol;
        PictureBox[,] bricks;
        int xSpeed,ySpeed;
        int barOffsetX;

        SoundPlayer sndBlast;
        SoundPlayer sndGameover;
        SoundPlayer sndbackground;
        SoundPlayer sndpass;
        int level = 1;
        int life = 3;
        bool firstclick = true;

        void SetupGame()
        {

            if (level == 1)
            {
                xSpeed = 18;
                ySpeed = 21;
                numRow = 3;
                numCol = 8;
            }
            else if(level==2)
            {
                numRow = 5;
                numCol = 10;
                xSpeed = 21;
                ySpeed = 24;
            }
            else
            {
                numRow = 8;
                numCol = 10;
                xSpeed = 21;
                ySpeed = 27;
            }

            //create our bricks array
            bricks = new PictureBox[numRow, numCol];
            //create each brick
            int w = (ClientRectangle.Width) / numCol;
            int h = 30;
            for (int r = 0; r < numRow; r++)
            {
                for (int c = 0; c < numCol; c++)
                {
                    bricks[r, c] = new PictureBox();
                    bricks[r, c].Width = w;
                    bricks[r, c].Height = h;
                    bricks[r, c].Top = 60 + r * h;
                    bricks[r, c].Left = c * w;
                    bricks[r, c].SizeMode = PictureBoxSizeMode.StretchImage;
                    bricks[r, c].Image = pcbBrick.Image;
                    Controls.Add(bricks[r, c]);
                }
            }
            pcbBall.Left = ClientRectangle.Width / 2 - pcbBall.Width / 2; //start position is in the middle of the form
            pcbBall.Top = ClientRectangle.Height / 3*2;
            setuplife();
            lablevel.Text = $"LEVEL: {level}";
        }

        void setuplife() //decide how many heart shown
        {
            if (life == 3)
            {
                ptbheart1.Visible = true;
                ptbheart2.Visible = true;
                ptbheart3.Visible = true;
            }
            else if (life == 2)
            {
                ptbheart1.Visible = true;
                ptbheart2.Visible = true;
                ptbheart3.Visible = false;
            }
            else if (life == 1)
            {
                ptbheart1.Visible = true;
                ptbheart2.Visible = false;
                ptbheart3.Visible = false;
            }
            else
            {
                ptbheart1.Visible = false;
                ptbheart2.Visible = false;
                ptbheart3.Visible = false;
            }
        }


        public MainForm()
        {
            InitializeComponent();
            SetupGame();
            sndBlast = new SoundPlayer("blast.wav");
            sndGameover = new SoundPlayer("gameover.wav");
            sndbackground = new SoundPlayer("background.wav");
            sndpass = new SoundPlayer("pass.wav");
            sndbackground.PlayLooping();
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            if(firstclick) //click to start the game
            {
                tmr.Enabled = !tmr.Enabled;
                firstclick = false;
            }
            if (pcbRestart.Visible) //player die
            {
                tmr.Enabled = !tmr.Enabled;
                pcbRestart.Visible = false;
                setuplife();
            }

            if(pcbPass.Visible) //player pass 
            {
                pcbPass.Visible = false;
                SetupGame();
                tmr.Enabled = !tmr.Enabled;
            }
            if(pcbWin.Visible||pcbLose.Visible) //player win or lose
            {
                this.Close();
            }
        }

        private void pcbBlast_MouseDown(object sender, MouseEventArgs e)
        {
            barOffsetX = e.X;
        }

        private void pcbBlast_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.Button != MouseButtons.Left) return;
            //pcbBar.Left = pcbBar.Left + (e.X - barOffsetX);
            //pcbBar.Left = e.X;
        }

        bool allgone = false;

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            pcbBar.Left = e.X;
        }

        private void pcbRestart_Click(object sender, EventArgs e)
        {
            tmr.Enabled = !tmr.Enabled;
            pcbRestart.Visible = false;
            setuplife(); //reset life
        }

        private void pcbPass_Click(object sender, EventArgs e)
        {
            pcbPass.Visible = false;
            level = level + 1;
            SetupGame(); //reset game layout
            tmr.Enabled = !tmr.Enabled;
        }

        private void pcbLose_Click(object sender, EventArgs e)
        {
            this.Close(); //if player click, close the game after showing the result of the game
        }

        private void pcbWin_Click(object sender, EventArgs e)
        {
            this.Close();//if player click, close the game after showing the result of the game
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            pcbBlast.Visible = false;
            pcbBall.Left = pcbBall.Left + xSpeed;
            pcbBall.Top = pcbBall.Top + ySpeed;

            // hit and return
            #region hit and return checking
            if (pcbBall.Bounds.Right >= ClientRectangle.Right ||
                pcbBall.Bounds.Left <= ClientRectangle.Left)
            {
                xSpeed = -xSpeed;
            }

            if (pcbBall.Bounds.Top <= 0 || pcbBall.Bounds.IntersectsWith(pcbBar.Bounds))
            {
                ySpeed = -ySpeed;
            }

            if(pcbBall.Top>ClientRectangle.Height)
            {
                sndGameover.Play();
                pcbBlast.Visible = false;
                pcbRestart.Visible = true;
                tmr.Enabled = false;
                pcbBall.Left = ClientRectangle.Width / 2;
                pcbBall.Top = ClientRectangle.Height / 2;
                life = life - 1;
            }
#endregion

            allgone = true;
            // check brick blast
            foreach (PictureBox bck in bricks)
            {

                //check visible bricks for collision
                if (bck.Visible)
                {
                    if(pcbBall.Bounds.IntersectsWith(bck.Bounds))
                    {
                        sndBlast.Play();
                        bck.Visible = false;
                        pcbBlast.Location = bck.Location;
                        pcbBlast.Visible = true;
                        xSpeed = -xSpeed;
                        ySpeed = -ySpeed;
                    }
                }
                if (bck.Visible) allgone = false;

            }

            //finish this level, level up
            if (allgone&&level<3)
            {
                sndpass.Play();
                pcbPass.Visible = true;
                pcbBlast.Visible = false;
                tmr.Enabled = false;
                pcbBall.Left = ClientRectangle.Width / 2;
                pcbBall.Top = ClientRectangle.Height / 2;
                level = level + 1;
            }

            //player pass all level, show "YOU WIN" to player
            if(allgone&&level==3)
            {
                sndpass.Play();
                pcbWin.Visible = true;
                pcbBlast.Visible=false;
                pcbBall.Visible = false;
                tmr.Enabled = false;
            }

            //player die more than three times, show "YOU LOSE" to player
            if(life==0)
            {
                setuplife();
                pcbRestart.Visible = false;
                sndGameover.Play();
                pcbLose.Visible = true;
                tmr.Enabled = false;
            }
        }
    }
}
