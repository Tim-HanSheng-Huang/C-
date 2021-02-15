using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R09725060HSHuangAss04
{
    class RootFinder
    {
        //data
        double a, b, c;

        public RootFinder()
        {
            //constructor
        }


        //member methods

        public void setQuadraticCoefficients(double aa, double bb, double cc)
        {
            a = aa; 
            b = bb; 
            c = cc;
        }

        public string findPolynominalRoots()
        {
            string result = "xxxxxx";

            double r1, r2, g1, g2; // Real values and image values

            if(a==0)
            {
                if(b==0)
                {
                    result = "Extremely Degerate!";
                }
                else
                {
                    result = $"Degerate!\nX={(-1) * c / b:F3}"; //degerate 
                }    

                
            }
            else if (Math.Pow(b,2)-4*a*c>=0) //discriminant>=0
            {
                r1 = ((-1) * b + Math.Pow((Math.Pow(b, 2) - 4 * a * c), 0.5)) / (2 * a); 
                r2 = ((-1) * b - Math.Pow((Math.Pow(b, 2) - 4 * a * c), 0.5)) / (2 * a); //imaginary part calculation
                result = $"Multiple Real Roots! \nRoot1={r1:F3} \nRoot2={r2:F3}";
            }
            else // //discriminant<0
            {

                g1 = (-1) * b  / (2 * a);  //real part calculation
                g2 = Math.Pow(((-1)*(Math.Pow(b, 2) - 4 * a * c)), 0.5) / (2 * a); //imaginary part calculation
                result = $"Two Complex Roots! \nRoot1={g1:F3} + {g2:F3}i \nRoot2={g1:F3} - {g2:F3}i"; 
            }

            return result;
        }
    }
}
