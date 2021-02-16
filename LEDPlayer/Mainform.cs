using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09725060HSHuangAss10
{
    public partial class Mainform : Form
    {
        PictureBox[,] LEDs;
        Bitmap onBmp, offBmp;
        List<int[]> frames = new List<int[]>();
        int currentIdx = 0;

        public Mainform()
        {
            InitializeComponent();

            //assign bitmaps
            onBmp = Properties.Resources.on;
            offBmp = Properties.Resources.off;

            //create 16*32 pictureboxes
            LEDs = new PictureBox[16, 32];
            int w = ClientRectangle.Width / 40;

            for (int r = 0; r < 16; r++)
            {
                for (int c = 0; c < 32; c++)
                {
                    LEDs[r, c] = new PictureBox();
                    LEDs[r, c].Width = LEDs[r, c].Height = w;
                    LEDs[r, c].Left = (31 - c) * w;
                    LEDs[r, c].Top = (r + 5) * w;
                    LEDs[r, c].Image = offBmp;
                    LEDs[r, c].SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(LEDs[r, c]);
                    LEDs[r, c].Click += LED_Clicked;
                }
            }

        }

        private void LED_Clicked(object sender, EventArgs e)
        {
            PictureBox theLED = (PictureBox)sender;
            if (theLED.Image == onBmp)
                theLED.Image = offBmp;
            else
                theLED.Image = onBmp;
            //throw new NotImplementedException();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            int[] currentFrame = recordAFrame();
            frames.Add(currentFrame);
            labFrameCount.Text = $"Frame Count : {frames.Count}";
            labCurrentFrame.Text = $"Current Frame : {frames.Count}";
        }

        int[] recordAFrame()
        {
            int[] aFrame = new int[16]; 

            for (int r = 0; r < 16; r++)
            {
                // Read LED images of row r to compose the int value ...
                int mask;
                aFrame[r] = 0;
                string ary="";
                BitArray aFramebitary = new BitArray(32);
                for (int c = 0; c < 32; c++)
                {
                    mask = 1 << c;
                    if(LEDs[r,c].Image==onBmp)
                    {
                        if(c==31)
                        {
                            aFrame[r] += (-2147483648);
                        }
                        else
                        {
                            aFrame[r] += Convert.ToInt32(Math.Pow(2, c));
                        }
                    }
                }
            }
            return aFrame;
        }

        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
            showAFrame(frames[currentIdx]);
            currentIdx++;
            if (currentIdx >= frames.Count)
                currentIdx = 0;
        }

        private void btnAnimate_Click(object sender, EventArgs e)
        {
            tmrAnimation.Enabled = !tmrAnimation.Enabled;
            if (tmrAnimation.Enabled)
                btnAnimate.Text = "Stop";
            else
                btnAnimate.Text = "Animate";
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            DialogResult ans = dlgOpen.ShowDialog();
            if (ans != DialogResult.OK)
                return;
            StreamReader sr = new StreamReader(dlgOpen.FileName);
            string str;
            frames.Clear();
            str = sr.ReadLine();
            int numOfFrames = Convert.ToInt32(str);
            char[] seps = { ' ' };
            for(int i=0;i<numOfFrames;i++)
            {
                string[] items;
                str = sr.ReadLine();
                items = str.Split(seps, StringSplitOptions.RemoveEmptyEntries);
                int[] fr = new int[16];
                for (int c = 0; c < 16; c++)
                    fr[c] = Convert.ToInt32(items[c]);
                frames.Add(fr);
            }
            sr.Close();
            currentIdx = 0;
            showAFrame(frames[currentIdx]);
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() != DialogResult.OK)
                return;
            StreamWriter sw = new StreamWriter(dlgSave.FileName);
            sw.WriteLine(frames.Count);
            for(int i=0;i<frames.Count;i++)
            {
                for (int r = 0; r < 16; r++) 
                {
                    sw.Write(frames[i][r]);
                    sw.Write(' ');
                }
                sw.WriteLine();
            }
            sw.Close();
        }

        //Display the LED screen images for a given array of int
        void showAFrame(int[] frame)
        {
            int mask;
            for (int r = 0; r < 16; r++)
            {
                //Set LED on or off for row r
                //frame[r]
                int rowPattern = frame[r];
                for (int c = 0; c < 32; c++)
                {
                    // check the c-th bit value of nowpattern
                    mask = 1 << c;
                    if ((mask & rowPattern) == 0)
                        LEDs[r, c].Image = offBmp;
                    else
                        LEDs[r, c].Image = onBmp;

                }
            }
            labFrameCount.Text = $"Frame Count : {frames.Count}";
            labCurrentFrame.Text = $"Current Frame : {currentIdx}";
        }

        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            clearScreen();
        }

        void clearScreen()
        {
            for (int r = 0; r < 16; r++)
            {
                for (int c = 0; c < 32; c++)
                {
                    LEDs[r, c].Image = offBmp;
                }
            }

        }

        private void btnLeftShift_Click(object sender, EventArgs e)
        {
           leftShift();
        }

        void leftShift()
        {
            int[] currentFrame = recordAFrame();
            for (int i = 0; i < currentFrame.Length; i++) 
            {
                currentFrame[i] = currentFrame[i] << 1;
            }
            showAFrame(currentFrame);
        }

        private void btnRightShift_Click(object sender, EventArgs e)
        {
            rightShift();
        }

        void rightShift()
        {
            int[] currentFrame = recordAFrame();
            for (int i = 0; i < currentFrame.Length; i++)
            {
                currentFrame[i] = currentFrame[i] >> 1;
            }
            showAFrame(currentFrame);
        }

        private void btnUpShift_Click(object sender, EventArgs e)
        {
            upShift();
        }

        void upShift()
        {
            int[] currentFrame = recordAFrame();
            int temp = currentFrame[0];
            for (int i = 0; i < currentFrame.Length-1; i++)
            {
                currentFrame[i] = currentFrame[i+1];
            }
            currentFrame[currentFrame.Length-1] = temp;
            showAFrame(currentFrame);
        }

        private void btnDownShift_Click(object sender, EventArgs e)
        {
            downShift();
        }

        private void btnClearAllFrame_Click(object sender, EventArgs e)
        {
            frames.Clear();
            currentIdx = 0;
            labFrameCount.Text = $"Frame Count : {frames.Count}";
            labCurrentFrame.Text = $"Current Frame : {currentIdx}";
        }

        private void btnDeleteCurrentFrame_Click(object sender, EventArgs e)
        {
            if(frames.Count>0)
            {
                frames.RemoveAt(currentIdx);
                currentIdx = (currentIdx - 1 + frames.Count) % frames.Count;
                labFrameCount.Text = $"Frame Count : {frames.Count}";
                labCurrentFrame.Text = $"Current Frame : {currentIdx}";
            }

        }

        private void btnPreviousFrame_Click(object sender, EventArgs e)
        {
            currentIdx = (currentIdx - 1 + frames.Count) % frames.Count;
            showAFrame(frames[currentIdx]);
        }

        private void btnNextFrame_Click(object sender, EventArgs e)
        {
            currentIdx = (currentIdx + 1) % frames.Count;
            showAFrame(frames[currentIdx]);
        }

        void downShift()
        {
            int[] currentFrame = recordAFrame();
            int temp = currentFrame[currentFrame.Length - 1];
            for(int i=currentFrame.Length-1;i>0;i--)
            {
                currentFrame[i] = currentFrame[i - 1];
            }
            currentFrame[0] = temp;
            showAFrame(currentFrame);
        }


    }
}
