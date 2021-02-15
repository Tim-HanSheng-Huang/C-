using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09725060HSHAss06
{
    public partial class MainForm : Form
    {
        GCDLCM_Finder myFinder;

        public MainForm()
        {
            InitializeComponent();

            //create myFinder object
            myFinder = new GCDLCM_Finder();
            propertyGrid1.SelectedObject = myFinder;
        }

        private void btnFindGCDnGCD_Click(object sender, EventArgs e)
        {
            string result;
            long g = myFinder.GetGCD();
            long l = myFinder.GetLCM();
            result = $"Numbers({myFinder.Number1},{myFinder.Number2}): GCD={g} LCM={l}";
            labResult.Text = result;
            rtbGCDLCMResult.Clear();
            rtbGCDLCMResult.AppendText(result);

            /*long aa = Convert.ToInt64(txbA.Text);
            long bb = Convert.ToInt64(txbB.Text);

            string result;

            if (myFinder.SetOperands(aa, bb))
            {
                long g = myFinder.GetGCD();
                long l = myFinder.GetLCM();
                result = $"({aa},{bb}) GCD={g} LCM={l}";
                labResult.Text = result;
                rtbGCDLCMResult.Clear();
                rtbGCDLCMResult.AppendText(result);
            }
            else
            {
                MessageBox.Show("You Can't Set Number to Zero!!");
            }*/
        }

        private void btnFindAllPrimes_Click(object sender, EventArgs e)
        {
            int limit = Convert.ToInt32(txbLimit.Text);
            rtbPrime.Text = PrimeNumberIdentifier.GetPrimeNumbers(limit);
        }
    }
}
