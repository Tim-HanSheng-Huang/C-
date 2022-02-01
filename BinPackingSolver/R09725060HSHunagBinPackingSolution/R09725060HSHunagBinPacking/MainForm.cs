using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09725060HSHunagBinPacking
{
    public partial class MainForm : Form
    {

        BinPackingGA myGASolver;
        public MainForm()
        {
            InitializeComponent();
        }

        double binCapacity;
        int numberOfItems;
        int OptimumN;
        double[] itemWeights;


        private double BPPObjectiveFunction(double[][] aSolution, double[] binAccumulation, int k_Obj)
        {
            int N_Obj = 0;
            double FillRatioAccumulation_Obj = 0.0;


            for (int i = 0; i < aSolution.Length; i++) 
            {
                if (aSolution[i][0] == -1) // there is no more bin after(including) bin i
                    break;

                FillRatioAccumulation_Obj += Math.Pow(binAccumulation[i] / binCapacity, k_Obj);
                N_Obj++;
            }

            return FillRatioAccumulation_Obj / N_Obj;

        }


        private void btnSolveByFF_Click(object sender, EventArgs e)
        {
            myGASolver.ShuffleAnArray(itemWeights,itemWeights.Length);
            labFFOutcome.Visible = true;

            double[][] aSolution;
            aSolution = new double[numberOfItems][];
            int numberOfOpenBins = 0;

            double[] binAccumulation = new double[numberOfItems];
            for (int i = 0; i < numberOfItems; i++)
                binAccumulation[i] = -1;

            for (int i = 0; i < numberOfItems; i++)
                aSolution[i] = new double[numberOfItems];
            for (int i = 0; i < numberOfItems; i++)
                for (int j = 0; j < numberOfItems; j++)
                    aSolution[i][j] = -1;

            for (int i = 0; i < numberOfItems; i++)
            {
                for (int j = 0; j < numberOfItems; j++)
                {
                    if (binAccumulation[j] != -1 && binAccumulation[j] + itemWeights[i] <= binCapacity) // item can be assigned to bin j
                    {
                        int insertpos = 0;
                        while (aSolution[j][insertpos] != -1)
                            insertpos++;
                        aSolution[j][insertpos] = itemWeights[i];
                        binAccumulation[j] += itemWeights[i];
                        break;
                    }


                    if (j >= numberOfOpenBins)
                    {
                        binAccumulation[j] = 0; // open new bin
                        numberOfOpenBins++;
                        aSolution[j][0] = itemWeights[i];
                        binAccumulation[j] += itemWeights[i];
                        break;
                    }
                }
            }

            string FFoutcome= "First Fit Solver Outcome: \n\n";
            double objvalue = BPPObjectiveFunction(aSolution, binAccumulation, 2);
            FFoutcome += $"Objective value: \n{objvalue:0.0000}\n\n";
            int binused = myGASolver.CalculateBinUsed(aSolution);
            FFoutcome += "Total number of bins used: \n" + binused.ToString() + "\n";
            labFFOutcome.Text = FFoutcome;



            StringBuilder FFoutcomeoutput = new StringBuilder();
            FFoutcomeoutput.Clear();

            for (int i = 0; i < aSolution.Length; i++)
            {
                if (aSolution[i][0] == -1)
                    break;
                else
                    FFoutcomeoutput.Append($"Bin {i + 1}: ");

                for (int j = 0; j < numberOfItems; j++)
                {
                    if (aSolution[i][j] == -1)
                        break;
                    FFoutcomeoutput.Append($"{aSolution[i][j]}, ");
                }
                FFoutcomeoutput.Append("\n");
            }
            rtbFFOutcome.Text = FFoutcomeoutput.ToString();
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            myGASolver.Reset();
            chtOutcome.Series[0].Points.Clear();
            chtOutcome.Series[1].Points.Clear();
            chtOutcome.Series[2].Points.Clear();
            rtbGAOutcome.Clear();
            labGAOutcome.Text = "GA Solver Outcome:";

            btnRunOne.Enabled = true;
            btnRunToEnd.Enabled = true;
        }

        private void btnRunOne_Click(object sender, EventArgs e)
        {
            myGASolver.RunOneIteration();
            chtOutcome.Series[0].Points.AddXY(myGASolver.IterationId, myGASolver.IterationAverageObjective);
            chtOutcome.Series[1].Points.AddXY(myGASolver.IterationId, myGASolver.IterationBestObjective);
            chtOutcome.Series[2].Points.AddXY(myGASolver.IterationId, myGASolver.SoFarTheBestObjectiveValue);

            labGAOutcome.Visible = true;

            if (myGASolver.Sofarthebestisupdated)
            {
                StringBuilder outcomeoutput = new StringBuilder();
                outcomeoutput.Clear();
                for (int i = 0; i < myGASolver.SoFarTheBestSolution.Length; i++)
                {
                    if (myGASolver.SoFarTheBestSolution[i][0] == -1)
                        break;
                    else
                        outcomeoutput.Append($"Bin {i + 1}: ");

                    for (int j = 0; j < numberOfItems; j++)
                    {
                        if (myGASolver.SoFarTheBestSolution[i][j] == -1)
                            break;
                        outcomeoutput.Append($"{myGASolver.SoFarTheBestSolution[i][j]}, ");
                    }
                    outcomeoutput.Append("\n");
                }
                rtbGAOutcome.Text = outcomeoutput.ToString();

                string GAoutcome = "GA Solver Outcome: \n\n";
                double objvalue = myGASolver.SoFarTheBestObjectiveValue;
                GAoutcome += $"Objective value: \n{objvalue:0.0000}\n\n";
                int binused = myGASolver.CalculateBinUsed(myGASolver.SoFarTheBestSolution);
                GAoutcome += "Total number of bins used: \n" + binused.ToString() + "\n";
                labGAOutcome.Text = GAoutcome;
            }



            

            //outcomeoutput += "\n" + myGASolver.SoFarTheBestObjectiveValue.ToString();
            //outcomeoutput += "\n" + myGASolver.SoFarTheBestBinUsed.ToString();
            //labShowTemp.Text = outcomeoutput;
        }

        private void btnRunToEnd_Click(object sender, EventArgs e)
        {

            while(myGASolver.IterationId<myGASolver.IterationLimit)
            {
                myGASolver.RunOneIteration();
                chtOutcome.Series[0].Points.AddXY(myGASolver.IterationId, myGASolver.IterationAverageObjective);
                chtOutcome.Series[1].Points.AddXY(myGASolver.IterationId, myGASolver.IterationBestObjective);
                chtOutcome.Series[2].Points.AddXY(myGASolver.IterationId, myGASolver.SoFarTheBestObjectiveValue);

                if (myGASolver.Sofarthebestisupdated)
                {
                    StringBuilder outcomeoutput = new StringBuilder();
                    outcomeoutput.Clear();
                    for (int i = 0; i < myGASolver.SoFarTheBestSolution.Length; i++)
                    {
                        if (myGASolver.SoFarTheBestSolution[i][0] == -1)
                            break;
                        else
                            outcomeoutput.Append($"Bin {i + 1}: ");

                        for (int j = 0; j < numberOfItems; j++)
                        {
                            if (myGASolver.SoFarTheBestSolution[i][j] == -1)
                                break;
                            outcomeoutput.Append($"{myGASolver.SoFarTheBestSolution[i][j]}, ");
                        }
                        outcomeoutput.Append("\n");
                    }
                    rtbGAOutcome.Text = outcomeoutput.ToString();
                }
            }

            btnRunToEnd.Enabled = false;
            btnRunOne.Enabled = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            string str;
            str = sr.ReadLine();
            string filename = str;
            str = sr.ReadLine();
            string problemIdentifier = str;

            str = sr.ReadLine();
            char[] seps = { ' ' };
            string[] item = str.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            binCapacity = double.Parse(item[0]);
            numberOfItems = int.Parse(item[1]);
            OptimumN = int.Parse(item[2]);

            itemWeights = new double[numberOfItems];
            for (int i = 0; i < numberOfItems; i++)
            {
                str = sr.ReadLine();
                itemWeights[i] = double.Parse(str);
            }
            sr.Close();

            myGASolver = new BinPackingGA(numberOfItems, itemWeights, binCapacity, BPPObjectiveFunction);
            ppgGA.SelectedObject = myGASolver;

            string basicinformation = "";
            basicinformation += $"File Name: {filename}\n";
            basicinformation += $"Bin Capacity: {binCapacity}\n";
            basicinformation += $"Number of Items: {numberOfItems}\n";
            basicinformation += $"Best Known N: {OptimumN}";

            labInformation.Text = basicinformation;

            StringBuilder sb = new StringBuilder();
            sb.Clear();
            for (int i = 0; i < numberOfItems; i++)
                sb.Append($"{itemWeights[i]}, ");
            rtbProblem.Text = sb.ToString();

            btnReset.Enabled = true;
            btnRunOne.Enabled = false;
            btnRunToEnd.Enabled = false;
            btnSolveByFF.Enabled = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "Created by Han-Sheng Huang (2022)";
            MessageBox.Show(text, "About");
        }
    }
}
