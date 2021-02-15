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

namespace RockPaperScissorGame
{

    public partial class MainForm : Form
    {
        //data member
        int won = 0, tied = 0, lost = 0;
        int computerHand;
        string playerHand;
        Random myRandomNumberGenerator = new Random();
        SoundPlayer wonsound = new SoundPlayer("wonsound.wav");
        SoundPlayer tiedsound = new SoundPlayer("tiedsound.wav");
        SoundPlayer lostsound = new SoundPlayer("lostsound.wav");

        void DisplayScoreBoard()
        {
            labScores.Text = $"Won Count:{won} Lost Count:{lost} Tied Count:{tied} ";
        }

        private void pcbRock_Click(object sender, EventArgs e)
        {
            pcbComputer.Image = null; //clear image of computer hand
            pcbPlayer.Image = pcbRock.Image; //change player hand
            playerHand = "r";
        }

        private void pcbpaper_Click(object sender, EventArgs e)
        {
            pcbComputer.Image = null; //clear image of computer hand
            pcbPlayer.Image = pcbPaper.Image;
            playerHand = "p";
        }

        private void pcbscissors_Click(object sender, EventArgs e)
        {
            pcbComputer.Image = null; //clear image of computer hand
            pcbPlayer.Image = pcbScissors.Image;
            playerHand = "s";
        }

        
        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            //computer place hand
            //pcbComputer.Image = null; //clear computer hand when evaluate button is clicked

            computerHand = myRandomNumberGenerator.Next(3); //random generate 0,1,2
            if(computerHand==0) //rock
            {
                pcbComputer.Image = pcbRock.Image;
            }
            else if(computerHand==1) //paper
            {
                pcbComputer.Image = pcbPaper.Image;
            }
            else //scissors
            {
                pcbComputer.Image = pcbScissors.Image;
            }

            //check won, lost, tied
            if((playerHand == "r" && computerHand == 2) ||
               (playerHand == "p" && computerHand == 0) ||
               (playerHand == "s" && computerHand == 1))
            {
                //won
                won = won + 1;
                wonsound.Play();
                MessageBox.Show("You Won!!");
            }
            else
            {
                if((playerHand == "r" && computerHand == 1) ||
                   (playerHand == "p" && computerHand == 2) ||
                   (playerHand == "s" && computerHand == 0))
                {
                    //lost
                    lost = lost + 1;
                    lostsound.Play();
                    MessageBox.Show("You Lost!");
                }
                else
                {
                    //tied
                    tied = tied + 1;
                    tiedsound.Play();
                    MessageBox.Show("Tied!!");
                }
            }


            //Update Scoreboard
            DisplayScoreBoard();


        }

        public MainForm() //constructior
        {           
            InitializeComponent();
            DisplayScoreBoard();
        }


    }
}
