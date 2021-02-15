using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R09725060HSHAss06
{
    class PrimeNumberIdentifier
    {

        public static bool IsAPrimeNumber(int num)
        {
            bool isPrime = true; //set isPrime=true (default)
            int n = num;

            for (int i = 2; i <= Math.Sqrt(n); i++) //only have to check from 2 to sqrt(num)
            {
                if (n % i == 0) //not a prime number
                {
                    isPrime = false; 
                    return isPrime;
                }
            }
            return isPrime;
        }

        public static string GetPrimeNumbers(int limit)
        {
            string result=""; 

            for (int n = 2; n <= limit; n++) //check every number smaller than limit
            {
                if (IsAPrimeNumber(n)) 
                {
                    result = result + n.ToString() + ", ";
                }
            }
            return result;
        }
    }
}
