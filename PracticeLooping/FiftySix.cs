using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class FiftySix
    {
        public static void PFiftySix()
        {
            Console.Write("Enter a positive integer: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int answer = 0;
            for (int i = 3; i <= userNum / 2; i++)
            {
                int firstFactor = 1;
                int secondFactor = 1;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    { 
                        firstFactor = 0; j = i; 
                    }
                }
                for (int j = 2; j < userNum - i; j++)
                {
                    if ((userNum - i) % j == 0)
                    {
                        secondFactor = 0; j = userNum - i; 
                    }
                }
                if (firstFactor == 1 && secondFactor == 1)
                {
                    Console.Write("{0} =  {1} + {2}  \n", userNum, i, userNum - i);
                    answer = 1;
                }
            }
            if (answer == 0)
            { Console.Write("\n{0} can not be expressed as sum of two prime numbers.\n\n", userNum); }
        }
    }
}
