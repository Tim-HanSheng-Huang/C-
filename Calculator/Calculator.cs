using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r09725060HSHuangAss03
{
    public partial class btnMemoryStore : Form
    {
        //data members
        double operand1;
        double operand2;
        string binaryOperator;
        double memory;

        //constructor
        public btnMemoryStore()
        {
            InitializeComponent();
        }

        private void NumericalKey_Click(object sender, EventArgs e)
        {
            //cast 
            Button btn = (Button)sender;

            if(labDisplay.Text=="0")
            {
                labDisplay.Text = btn.Text;
            }
            else
            {
                labDisplay.Text = labDisplay.Text + btn.Text;
            }
        }


        private void btnDot_Click(object sender, EventArgs e)
        {
            //check whether there is a dot existing
            bool dotExist = labDisplay.Text.Contains(".");
            
            if(!dotExist)
                labDisplay.Text = labDisplay.Text + ".";
        }

        void GetOperand1()
        {
            operand1 = Convert.ToDouble(labDisplay.Text);
        }

        void GetOperand2()
        {
            operand2 = Convert.ToDouble(labDisplay.Text);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            //assign operand1
            GetOperand1();
            if (rdbDegree.Checked)
                operand1 = operand1 * Math.PI / 180.0;

            labDisplay.Text = Math.Sin(operand1).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labDisplay.Text = "0";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            //get operand2
            GetOperand2();

            //calculage binary operation results
            if(binaryOperator=="+")
            {
                labDisplay.Text = (operand1 + operand2).ToString();
            }
            else if(binaryOperator=="-")
            {
                labDisplay.Text = (operand1 - operand2).ToString();
            }
            else if(binaryOperator=="*")
            {
                labDisplay.Text = (operand1 * operand2).ToString();
            }
            else if (binaryOperator == "/")
            {
                labDisplay.Text = (operand1 / operand2).ToString();
            }
            else if(binaryOperator=="xpy")
            {
                labDisplay.Text = Math.Pow(operand1, operand2).ToString();
            }
            else if(binaryOperator== "y√X")
            {
                labDisplay.Text = Math.Pow(operand1, (double)1 / operand2).ToString(); //calculate exponential
            }
            else if(binaryOperator=="mod")
            {
                labDisplay.Text = (operand1 % operand2).ToString(); //calculate mod
            }

            binaryOperator = "";
        }

        private void BinaryOperator_Click(object sender, EventArgs e)
        {
            //cast sender to button
            Button btn = (Button)sender;

            GetOperand1();

            //set binaroy operator type
            binaryOperator = btn.Text;
            //clear display
            labDisplay.Text = "0";
        }

        //these functions are useless beacause of BinaryOperator_Click function
        /*private void btnMinus_Click(object sender, EventArgs e) 
        {
            GetOperand1();
            //set binaroy operator type
            binaryOperator = "-";
            //clear display
            labDisplay.Text = "0";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            GetOperand1();
            //set binaroy operator type
            binaryOperator = "*";
            //clear display
            labDisplay.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            GetOperand1();
            //set binaroy operator type
            binaryOperator = "/";
            //clear display
            labDisplay.Text = "0";
        }*/

        private void btn0_Click(object sender, EventArgs e)
        {
            if(!(labDisplay.Text=="0"))
            {
                labDisplay.Text = labDisplay.Text + "0";
            }
        }

        private void btnStoretoMemory_Click(object sender, EventArgs e)
        {
            GetOperand1(); 
            memory = operand1; //store the value to memory
        }

        private void btnMemoryRecall_Click(object sender, EventArgs e)
        {
            labDisplay.Text = memory.ToString(); //recall the memory value
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            memory = 0.0;
        }

        private void btnMemoryPlus_Click(object sender, EventArgs e)
        {
            GetOperand1();
            memory = memory + operand1; //plus the value to memory
            labDisplay.Text = "0"; //clear display
        }

        private void btnMemoryMinus_Click(object sender, EventArgs e)
        {
            GetOperand1();
            memory = memory - operand1; //minus the value to memory
            labDisplay.Text = "0"; //clear display
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            //assign operand1
            GetOperand1();
            if (rdbDegree.Checked)
                operand1 = operand1 * Math.PI / 180.0;

            labDisplay.Text = Math.Cos(operand1).ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            //assign operand1
            GetOperand1();
            if (rdbDegree.Checked)
                operand1 = operand1 * Math.PI / 180.0;

            labDisplay.Text = Math.Tan(operand1).ToString();
        }

        private void btnChangeSign_Click(object sender, EventArgs e)
        {
            if(labDisplay.Text.Contains("-")) //negative number case
            {
                labDisplay.Text = labDisplay.Text.Substring(1); 
            }
            else // non-negative case
            {
                if(labDisplay.Text!="0") // zero has no sign
                {
                    labDisplay.Text = "-" + labDisplay.Text;
                }

            }
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            GetOperand1();
            labDisplay.Text = Math.Pow(operand1, 0.5).ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(labDisplay.Text.Length>1)//make sure there are more than one character to back
            {
                labDisplay.Text = labDisplay.Text.Substring(0, labDisplay.Text.Length - 1);
            }
            else
            {
                labDisplay.Text = "0"; //if there are no character to back, then display zero
            }

        }

        private void btnNaturalLog_Click(object sender, EventArgs e)
        {
            GetOperand1();
            labDisplay.Text = Math.Log(operand1).ToString();
        }

        private void btnLog10_Click(object sender, EventArgs e)
        {
            GetOperand1();
            labDisplay.Text = Math.Log10(operand1).ToString();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            GetOperand1();

            int temp = 1;
            for (int i = (int)operand1; i > 0; i--) 
            {
                temp = i * temp;
            }

            labDisplay.Text = temp.ToString();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            labDisplay.Text = Math.E.ToString();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            labDisplay.Text = Math.PI.ToString();
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            GetOperand1();
            labDisplay.Text = (1 / operand1).ToString();
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            GetOperand1();
            labDisplay.Text = (operand1 / 100).ToString();
        }
    }
}
