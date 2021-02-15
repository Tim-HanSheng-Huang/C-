using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09725060HSHuangAss09
{
    public partial class MainForm : Form
    {
        double[] vector1 = { -2, 2, 1, -1 };
        double[] vector2 = { 1, 2, 3, 4 };
        char[] seps = new char[] { '\r', '\n', '\t' };
        double[,] matrix1 = { { 1, 2, 3, 4 }, { 4, 3, 2, 1 }, { -1, 2, 3, 0 }, { 1, -1, -2, 3 } };
        double[,] matrix2 = { { 4, 1, 3, -1 }, { -2, 3, -1, 4 }, { 3, 2, -3, 1 }, { 2, 3, -1, 2 } };
        double[,] matrix3 = { { 1, 0, -1, 2 }, { 3, -1, -2, 0 }, { 2, 1, 4, 3 } };

        //testing
        /*double[] vector1 = { -3.5, 8.5, 3.1, -11 };
        double[] vector2 = { 0.05, 8.23, 3.12, -4.52 };
        char[] seps = new char[] { '\r', '\n', '\t' };
        double[,] matrix1 = { { 0.12, 2.35,-2.12, 2.06 }, { -3.14, 7.13, 5.21, -6.64 }, { 2.13, 5.16, -5.14, -3.02 }, { 2.12, 1.45, -0.34, -2.82 } };
        double[,] matrix2 = { { 1.2,3.3,-1.2,3.8}, { 1.7,4.3,7.5,-2.4 }, { 9.2,8.6,-11.3,-21.5 }, { 2.6,1.5,-6.5,2 } };
        double[,] matrix3 = { { 0.2,4.5,-2.2,3}, { -5.4,2.3,4.1,4 }, { 1, 4, 3,5 } };*/

        public MainForm()
        {
            InitializeComponent();
            InitializerUI();
        }

        private void InitializerUI()
        {
            //show v1 and v2
            txbV1.Text = MatrixAndVector.VectorString(vector1);
            txbV2.Text = MatrixAndVector.VectorString(vector2);
            txbM1.Text = MatrixAndVector.MatrixString(matrix1);
            txbM2.Text = MatrixAndVector.MatrixString(matrix2);
            txbM3.Text = MatrixAndVector.MatrixString(matrix3);
        }

        void updateV1()
        {
            string[] items = txbV1.Text.Split(seps,StringSplitOptions.RemoveEmptyEntries);
            for(int i=0;i<vector1.Length;i++)
            {
                vector1[i] = Convert.ToDouble(items[i]);
            }
        }

        void updateV2()
        {
            string[] items = txbV2.Text.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < vector2.Length; i++)
            {
                vector2[i] = Convert.ToDouble(items[i]);
            }
        }

        void updateM1()
        {
            string[] items = txbM1.Text.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            int rowCount = matrix1.GetLength(0);
            int columnCount = matrix1.GetLength(1);
            int itemcount = 0;

            for (int r = 0; r < rowCount; r++)
            {
                for (int c = 0; c < columnCount; c++)
                {
                    matrix1[r, c] = Convert.ToDouble(items[itemcount]);
                    itemcount++;
                }
            }
        }

        void updateM2()
        {
            string[] items = txbM2.Text.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            int rowCount = matrix2.GetLength(0);
            int columnCount = matrix2.GetLength(1);
            int itemcount = 0;

            for (int r = 0; r < rowCount; r++)
            {
                for (int c = 0; c < columnCount; c++)
                {
                    matrix2[r, c] = Convert.ToDouble(items[itemcount]);
                    itemcount++;
                }
            }
        }

        void updateM3()
        {
            string[] items = txbM3.Text.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            int rowCount = matrix3.GetLength(0);
            int columnCount = matrix3.GetLength(1);
            int itemcount = 0;

            for (int r = 0; r < rowCount; r++)
            {
                for (int c = 0; c < columnCount; c++)
                {
                    matrix3[r, c] = Convert.ToDouble(items[itemcount]);
                    itemcount++;
                }
            }
        }

        private void btnShowV1_Click(object sender, EventArgs e)
        {
            updateV1();
            string s = MatrixAndVector.VectorString(vector1);
            richTextBox1.Text = s;
        }

        private void btnShowM1_Click(object sender, EventArgs e)
        {
            updateM1();
            richTextBox1.Text = MatrixAndVector.MatrixString(matrix1);
        }

        private void btnM3xM1_Click(object sender, EventArgs e)
        {
            updateM1();
            updateM3();
            double[,] result = MatrixAndVector.Multiplication(matrix3, matrix1);
            richTextBox1.Text= MatrixAndVector.MatrixString(result);
        }

        private void btnM1xM2_Click(object sender, EventArgs e)
        {
            updateM1();
            updateM2();
            double[,] result = MatrixAndVector.Multiplication(matrix1, matrix2);
            richTextBox1.Text = MatrixAndVector.MatrixString(result);
        }

        private void btnV1PlusV2_Click(object sender, EventArgs e)
        {
            updateV1();
            updateV2();
            double[] result = MatrixAndVector.Addition(vector1, vector2);
            richTextBox1.Text = MatrixAndVector.VectorString(result);
        }

        private void btnV1MinusV2_Click(object sender, EventArgs e)
        {
            updateV1();
            updateV2();
            double[] result = MatrixAndVector.Subtraction(vector1, vector2);
            richTextBox1.Text = MatrixAndVector.VectorString(result);
        }

        private void btnV1V2InnerProduct_Click(object sender, EventArgs e)
        {
            updateV1();
            updateV2();
            double result = MatrixAndVector.InnerProduct(vector1, vector2);
            richTextBox1.Text = result.ToString();
        }

        private void btnNormOfV1_Click(object sender, EventArgs e)
        {
            updateV1();
            double result = MatrixAndVector.Norm(vector1);
            richTextBox1.Text = result.ToString();
        }

        private void btnUnitVectorOfV1_Click(object sender, EventArgs e)
        {
            updateV1();
            double[] result = MatrixAndVector.UnitVector(vector1);
            richTextBox1.Text = MatrixAndVector.VectorString(result);
        }

        private void btnTransposeOfM3_Click(object sender, EventArgs e)
        {
            updateM3();
            double[,] result = MatrixAndVector.TransposeMatrix(matrix3);
            richTextBox1.Text = MatrixAndVector.MatrixString(result);
        }

        private void btnM1PlusM2_Click(object sender, EventArgs e)
        {
            updateM1();
            updateM2();
            double[,] result = MatrixAndVector.Addition(matrix1, matrix2);
            richTextBox1.Text = MatrixAndVector.MatrixString(result);
        }

        private void btnM1MinusM2_Click(object sender, EventArgs e)
        {
            updateM1();
            updateM2();
            double[,] result = MatrixAndVector.Subtraction(matrix1, matrix2);
            richTextBox1.Text = MatrixAndVector.MatrixString(result);
        }

        private void btnM1TimeV1_Click(object sender, EventArgs e)
        {
            updateM1();
            updateV1();
            double[] result = MatrixAndVector.MatrixTimeVector(matrix1, vector1);
            richTextBox1.Text = MatrixAndVector.VectorString(result);
        }

        private void btnV1TimeM1_Click(object sender, EventArgs e)
        {
            updateM1();
            updateV1();
            double[] result = MatrixAndVector.VectorTimeMatrix(vector1,matrix1);
            string printing = "";
            for(int i=0;i<result.Length;i++)
            {
                printing += result[i] + "\t";
            }
            richTextBox1.Text = printing;
        }

        private void btnDeterminantOfM1_Click(object sender, EventArgs e)
        {
            updateM1();
            double result = MatrixAndVector.Determinant(matrix1);
            richTextBox1.Text = result.ToString();
        }
    }
}
