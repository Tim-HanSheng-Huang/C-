using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09725060MineSweepGameSolution
{
    public partial class MainForm : Form
    {
        Bitmap[] numbers = new Bitmap[9];
        Bitmap cover, flag, question;
        Bitmap bomb;

        int numRow=12;
        int numCol=15;
        int totalbombnum = 0;

        MineSweepPictureBox[,] grids;

        void SetupCover()
        {
            
            grids = new MineSweepPictureBox[numRow, numCol];
            int w = (int)((ClientRectangle.Width) * 0.8 / numCol);
            int h = (int)((ClientRectangle.Width) * 0.8 / numCol);
            for (int r = 0; r < numRow; r++)
            {
                for (int c = 0; c < numCol; c++)
                {
                    grids[r, c] = new MineSweepPictureBox();
                    grids[r, c].Width = w;
                    grids[r, c].Height = h;
                    grids[r, c].Top = 120 + r * h;
                    grids[r, c].Left = (int)((ClientRectangle.Width) * 0.1 + c * w);
                    grids[r, c].SizeMode = PictureBoxSizeMode.StretchImage;
                    grids[r, c].Image = cover;
                    grids[r, c].R = r;
                    grids[r, c].C = c;
                    Controls.Add(grids[r, c]);
                }
            }
            
        }

        void SetupTag()
        {
            totalbombnum = 0;
            Random randomnumber = new Random();
            for (int r = 0; r < numRow; r++) //setup bomb tag
            {
                for (int c = 0; c < numCol; c++)
                {
                    int rannum = randomnumber.Next(0, 10);

                    if (rannum % 100 == 3) //10% probability is bomb
                    {
                        grids[r, c].Tag = bomb;
                        grids[r, c].SizeMode = PictureBoxSizeMode.StretchImage;
                        totalbombnum++;
                    }
                }

            }

            for (int r = 0; r < numRow; r++) //setup nonbomb tag
            {
                for (int c = 0; c < numCol; c++)
                {
                    if (grids[r, c].Tag != bomb)
                    {
                        int bombcount = 0;

                        if (r - 1 >= 0)
                        {
                            if (c - 1 >= 0)
                            {
                                if (grids[r - 1, c - 1].Tag == bomb)
                                    bombcount++;
                            }

                            if (grids[r - 1, c].Tag == bomb)
                                bombcount++;

                            if (c + 1 < numCol)
                            {
                                if (grids[r - 1, c + 1].Tag == bomb)
                                    bombcount++;
                            }
                        }

                        if (c - 1 >= 0)
                        {
                            if (grids[r, c - 1].Tag == bomb)
                                bombcount++;
                        }

                        if(c+1< numCol)
                        {
                            if (grids[r, c + 1].Tag == bomb)
                                bombcount++;
                        }


                        if (r + 1 < numRow)
                        {
                            if(c-1>=0)
                            {
                                if (grids[r + 1, c - 1].Tag == bomb)
                                    bombcount++;
                            }

                            if (grids[r + 1, c].Tag == bomb)
                                bombcount++;

                            if (c + 1 < numCol)
                            {
                                if (grids[r + 1, c + 1].Tag == bomb)
                                    bombcount++;
                            }    

                        }

                        grids[r, c].SizeMode = PictureBoxSizeMode.StretchImage;
                        grids[r, c].Tag = numbers[bombcount];
                    }
                }
            }
        }


        void open(object sender)
        {
            MineSweepPictureBox pb = (MineSweepPictureBox)sender;
            if (pb.Tag == numbers[0])
            {
                int r = pb.R;
                int c = pb.C;
                pb.Image = (Bitmap)pb.Tag;

                if (r - 1 >= 0)
                {
                    if (c - 1 >= 0 && grids[r - 1, c - 1].Image == cover)
                        open(grids[r - 1, c - 1]);

                    if (grids[r - 1, c].Image == cover)
                        open(grids[r - 1, c]);

                    if (c + 1 < numCol && grids[r - 1, c + 1].Image == cover)
                        open(grids[r - 1, c + 1]);
                }

                if (c - 1 >= 0 && grids[r, c - 1].Image == cover)
                    open(grids[r, c - 1]);
                if (c + 1 < numCol && grids[r, c + 1].Image == cover)
                    open(grids[r, c + 1]);

                if (r + 1 < numRow)
                {
                    if (c - 1 >= 0 && grids[r + 1, c - 1].Image == cover)
                        open(grids[r + 1, c - 1]);

                    if(grids[r + 1, c].Image == cover)
                        open(grids[r + 1, c]);

                    if (c + 1 < numCol && grids[r + 1, c + 1].Image == cover)
                        open(grids[r + 1, c + 1]);
                }
            }                
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            MineSweepPictureBox pb = (MineSweepPictureBox)sender;
            switch (e.Button)
            {
                case MouseButtons.Left:

                    int opened = numCol * numRow - totalbombnum;
                    if (pb.Tag == bomb)
                    {
                        pb.Image = (Bitmap)pb.Tag;
                        transparentPanel_lose.Visible = true;
                        endgame();
                    }
                    else if (pb.Tag == numbers[0]) 
                    {
                        open(pb);
                        for (int r = 0; r < numRow; r++)
                        {
                            for (int c = 0; c < numCol; c++)
                            {
                                //check if the player win the game
                                if (grids[r, c].Image != cover)
                                    opened--;
                            }
                        }
                        if(opened<=0)
                        {
                            endgame();
                            transparentPanel_pass.Visible = true;
                        }

                    }
                    else
                    {
                        pb.Image = (Bitmap)pb.Tag;
                        for (int r = 0; r < numRow; r++)
                        {
                            for (int c = 0; c < numCol; c++)
                            {
                                //check if the player win the game
                                if (grids[r, c].Image != cover)
                                    opened--;
                            }
                        }
                        if (opened <= 0)
                        {
                            endgame();
                            transparentPanel_pass.Visible = true;
                        }

                    }
                    break;
                case MouseButtons.Right:
                    if (pb.Image == cover)
                        pb.Image = flag;
                    else if (pb.Image == flag)
                        pb.Image = question;
                    else
                        pb.Image = cover;
                    break;
            }

        }

        void SetuptMouseClick()
        {
            for (int r = 0; r < numRow; r++)
            {
                for (int c = 0; c < numCol; c++)
                {
                    grids[r, c].MouseClick += new System.Windows.Forms.MouseEventHandler(mouseClick);
                }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            for (int r = 0; r < numRow; r++)
            {
                for (int c = 0; c < numCol; c++)
                {
                    Controls.Remove(grids[r, c]);
                }
            }
            transparentPanel_lose.Visible = false;
            transparentPanel_pass.Visible = false;
            numRow = (int)numudRow.Value;
            numCol = (int)numudCol.Value;
            SetupCover();
            SetupTag();
            SetuptMouseClick();
        }


        void endgame()
        {
            for (int r = 0; r < numRow; r++)
            {
                for (int c = 0; c < numCol; c++)
                {
                    grids[r, c].Enabled = false;
                }
            }
        }


        public MainForm()
        {
            InitializeComponent();
            numbers[0] = Properties.Resources.zero;
            numbers[1] = Properties.Resources.one;
            numbers[2] = Properties.Resources.two;
            numbers[3] = Properties.Resources.three;
            numbers[4] = Properties.Resources.four;
            numbers[5] = Properties.Resources.five;
            numbers[6] = Properties.Resources.six;
            numbers[7] = Properties.Resources.seven;
            numbers[8] = Properties.Resources.eight;

            cover = Properties.Resources.cover;
            flag = Properties.Resources.flag;
            question = Properties.Resources.question;
            bomb = Properties.Resources.bomb;

            SetupCover();
            SetupTag();
            SetuptMouseClick();

        }

        /*private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            switch(e.Button)
            {
                case MouseButtons.Left:
                    pb.Image = (Bitmap)pb.Tag;
                    if(pb.Tag==bomb)
                    {
                        pb.Image = bomb;
                        

                    }
                    else
                    {
                    }
                    transparentPanel_Pass.Visible = true;
                    break;
                case MouseButtons.Right:
                    if (pb.Image == cover)
                        pb.Image = flag;
                    else if (pb.Image == flag)
                        pb.Image = question;
                    else
                        pb.Image = cover;
                    break;
            }
            
        }*/
    }
}
