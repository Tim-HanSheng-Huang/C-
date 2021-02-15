using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R09725060HSHuangAss04
{
    class FourDigitGame
    {
        // data member
        int[] digits = new int[4];
        Random myRandomNumberGenerator = new Random();

        //member functions
        public void ResetDigits()
        {
            do
            {
                for (int i = 0; i < 4; i++)
                {
                    digits[i] = myRandomNumberGenerator.Next(10); //0-9
                }
            } while (digits[0] == digits[1] || digits[0] == digits[2] || digits[0] == digits[3] ||
            digits[1] == digits[2] || digits[1] == digits[3] || digits[2] == digits[3]);


        }

        public string GetCorrectAnswer()
        {
            string answer = "";

            for (int i = 0; i < 4; i++)
            {
                answer = digits[i].ToString() + answer;
            }

            return answer;
        }

        public bool CheckInput(string guess) //check the input correctness, four digits must be differnt
        {
            if(guess.Length!=4||guess[0] == guess[1] || guess[0] == guess[2] || guess[0] == guess[3] ||
            guess[1] == guess[2] || guess[1] == guess[3] || guess[2] == guess[3])
            {
                return false;
            }

            return true;
        }

        public string CheckCorrectness(string guess)
        {
            
            int countA =0, countB = 0; //count the number of A and B

            for (int i = 3; i >= 0; i--)
            {
                if(guess[i].ToString()==digits[3-i].ToString()) //the first item of "guess" should be compare to the last item of "digits" and so on...
                {
                    countA = countA + 1;
                }
                else
                {
                    for (int j = 3; j >= 0; j--) 
                    {
                        if (guess[i].ToString() == digits[j].ToString()) //count the number of B
                        {
                            countB = countB + 1;
                        }
                    }

                }

            }

            if(countA==4)
            {
                return $"Your Input: {guess} => {countA}A   {countB}B\nYou Got It!!!!";
            }

            return $"Your Input: {guess} => {countA}A   {countB}B";

        }
    }
}
