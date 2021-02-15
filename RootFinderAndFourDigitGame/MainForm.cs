using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09725060HSHuangAss04
{
    public partial class MainForm : Form
    {
        RootFinder myRootFinder;
        FourDigitGame myGame;
        public MainForm()
        {
            InitializeComponent();

            //create root finder object
            myRootFinder = new RootFinder();
            myGame = new FourDigitGame();
        }

        private void btnFindRoots_Click(object sender, EventArgs e)
        {
            //get a, b, c form UIs
            double aa, bb, cc;
            aa = Convert.ToDouble(txba.Text);
            bb = Convert.ToDouble(txbb.Text);
            cc = Convert.ToDouble(txbc.Text);

            myRootFinder.setQuadraticCoefficients(aa, bb, cc);
            string outcome = myRootFinder.findPolynominalRoots();

            rtbDisplay.Text = outcome;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            myGame.ResetDigits();
            labAnswer.Text = myGame.GetCorrectAnswer();
            rtbLog.Clear();
        }


        private void txbGuess_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(myGame.CheckInput(txbGuess.Text))
                {
                    string ss = myGame.CheckCorrectness(txbGuess.Text);
                    rtbLog.AppendText(ss);
                    rtbLog.AppendText("\n");
                    txbGuess.Clear();
                }
                else
                {
                    rtbLog.AppendText("Your guess need to be FOUR DIFFERENT digits!\n"); //wrong input
                    txbGuess.Clear();
                }

            }

        }
    }
}
