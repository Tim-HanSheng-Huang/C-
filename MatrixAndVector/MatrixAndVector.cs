using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R09725060HSHuangAss09
{
    class MatrixAndVector
    {
        static public string VectorString(double[] vector)
        {
            string result = "";
            foreach(double d in vector)
            {
                //result += $"{d.ToString("0.000")}\n";
                result += $"{d:0.0000}\r\n";
            }
            return result;
        }

        static public string MatrixString(double[,] matrix)
        {
            string result = "";
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);

            for(int r=0;r<rowCount;r++)
            {
                for(int c=0;c<columnCount;c++)
                {
                    result += $"{matrix[r,c]:0.0000}\t";
                }
                result += "\r\n";
            }

            return result;
        }
        
        static public double[] Addition(double[] v1, double[] v2)
        {
            double[] ans = null;
            int v1_length = v1.Length;
            if (v2.Length != v1_length)
                throw new Exception("Dimensions are matched!");
            ans = new double[v1_length];

            for(int i=0;i<v1_length;i++)
            {
                ans[i] = v1[i] + v2[i];
            }

            return ans;
        }

        static public double[,] Addition(double[,] m1, double[,] m2)
        {
            double[,] ans = null;
            int m1_row = m1.GetLength(0);
            int m1_column = m1.GetLength(1);
            if (m1_row != m2.GetLength(0) || m1_column != m2.GetLength(1))
                throw new Exception("Dimensions are not matched!");
            ans = new double[m1_row, m1_column];

            for (int r = 0; r < m1_row; r++)
            {
                for (int c=0;c<m1_column;c++)
                {
                    ans[r, c] = m1[r, c] + m2[r, c];
                }
            }

            return ans;
        }

        static public double[] Subtraction(double[] v1, double[] v2)
        {
            double[] ans = null;
            int v1_length = v1.Length;
            if (v2.Length != v1_length)
                throw new Exception("Dimensions are matched!");
            ans = new double[v1_length];

            for (int i = 0; i < v1_length; i++)
            {
                ans[i] = v1[i] - v2[i];
            }

            return ans;
        }

        static public double[,] Subtraction(double[,] m1, double[,] m2)
        {
            double[,] ans = null;
            int m1_row = m1.GetLength(0);
            int m1_column = m1.GetLength(1);
            if (m1_row != m2.GetLength(0) || m1_column != m2.GetLength(1))
                throw new Exception("Dimensions are not matched!");
            ans = new double[m1_row, m1_column];

            for (int r = 0; r < m1_row; r++)
            {
                for (int c = 0; c < m1_column; c++)
                {
                    ans[r, c] = m1[r, c] - m2[r, c];
                }
            }

            return ans;
        }

        static public double InnerProduct(double[] v1, double[] v2)
        {
            double ans = 0;
            int v1_length = v1.Length;
            if (v2.Length != v1_length)
                throw new Exception("Dimensions are matched!");

            for (int i = 0; i < v1_length; i++)
            {
                ans += v1[i] * v2[i];
            }

            return ans;

        }

        static public double Norm(double[] v)
        {
            double ans = 0;
            int v_length = v.Length;
            for (int i = 0; i < v_length; i++)
            {
                ans += Math.Pow(v[i], 2);
            }
            ans = Math.Pow(ans, 0.5);

            return ans;
        }

        static public double[] UnitVector(double[] v)
        {
            double[] ans = null;
            int v_length = v.Length;
            ans = new double[v_length];

            double norm = Norm(v);

            for (int i = 0; i < v_length; i++)
            {
                ans[i] = v[i] / norm;
            }

            return ans;
        }

        static public double[,] TransposeMatrix(double[,] m)
        {
            double[,] ans = null;
            int original_r = m.GetLength(0);
            int original_c = m.GetLength(1);
            ans = new double[original_c, original_r];

            for (int r = 0; r < original_c; r++) 
            {
                for (int c = 0; c < original_r; c++)
                {
                    ans[r,c] = m[c,r];
                }
            }

            return ans;
        }

        static public double[,] Multiplication(double[,] a, double[,] b)
        {
            double[,] c = null;

            int m = a.GetLength(0);
            int n = a.GetLength(1);
            if (b.GetLength(0) != n)
                throw new Exception("Dimensions are not matched!");
            int p = b.GetLength(1);
            c = new double[m, p];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    c[i, j] = 0.0;
                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return c;
        }

        static public double[] MatrixTimeVector(double[,] m, double[] v)
        {
            double[] ans = null;
            int r = m.GetLength(0);
            int c = m.GetLength(1);
            if (c != v.Length) 
                throw new Exception("Dimensions are not matched!");
            ans = new double[r];

            for (int i = 0; i < r; i++)
            {
                for(int j=0;j<c;j++)
                {
                    ans[i] += m[i, j] * v[j];
                }    
            }

            return ans;
        }

        static public double[] VectorTimeMatrix(double[] v, double[,] m)
        {
            double[] ans = null;
            int r = m.GetLength(0);
            int c = m.GetLength(1);
            if (v.Length != c)
            {
                throw new Exception("Dimensions are not matched!");
            }
            ans = new double[c];


            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    ans[i] += m[j, i] * v[j];
                }
            }

            return ans;

        }

        static public double Determinant(double[,] m)
        {
            double ans = 0;
            int r = m.GetLength(0);
            int c = m.GetLength(1);

            if (r != c || r > 4)
            {
                throw new Exception("Dimensions are not matched!");
            }

            if (r == 4)
            {
                double[,] matrix1 = { { m[1, 1], m[1, 2], m[1, 3] }, { m[2, 1], m[2, 2], m[2, 3] }, { m[3, 1], m[3, 2], m[3, 3] } };
                double[,] matrix2 = { { m[1, 0], m[1, 2], m[1, 3] }, { m[2, 0], m[2, 2], m[2, 3] }, { m[3, 0], m[3, 2], m[3, 3] } };
                double[,] matrix3 = { { m[1, 0], m[1, 1], m[1, 3] }, { m[2, 0], m[2, 1], m[2, 3] }, { m[3, 0], m[3, 1], m[3, 3] } };
                double[,] matrix4 = { { m[1, 0], m[1, 1], m[1, 2] }, { m[2, 0], m[2, 1], m[2, 2] }, { m[3, 0], m[3, 1], m[3, 2] } };
                ans = m[0, 0] * Determinant(matrix1) - m[0, 1] * Determinant(matrix2) + m[0, 2] * Determinant(matrix3) - m[0, 3] * Determinant(matrix4);

            }
            else if (r == 3)
            {
                ans = m[0, 0] * m[1, 1] * m[2, 2] + m[0, 1] * m[1, 2] * m[2, 0] + m[0, 2] * m[1, 0] * m[2, 1]
                    - m[0, 2] * m[1, 1] * m[2, 0] - m[0, 1] * m[1, 0] * m[2, 2] - m[0, 0] * m[1, 2] * m[2, 1];
            }

            return ans;
        }

    }
}
