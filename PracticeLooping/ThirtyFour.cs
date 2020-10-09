using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class ThirtyFour
    {
        public static void PThirtyFour()
        {
            Console.WriteLine("Enter a positive number: ");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number greater than the first: ");
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("The prime numbers between your numbers are: ");
            int answer = 0;
            int counter = userNum1 + 1;
            for (int i = userNum1; i < userNum2; i++)
            {
                if (i == 2)
                {
                    Console.Write("2 ");
                }
            }
            for (int i = userNum1; i < userNum2; i++)
            {
                for (int j = 2; j < counter; j++)
                {
                    if(counter % j == 0)
                    {
                        answer = 1;
                        break;
                    }
                    if (counter % j != 0)
                    {
                        answer = 2;
                    }
                }
                if(answer == 2)
                {
                        Console.Write(counter + " ");
                }
                counter++;
            }
            Console.WriteLine();
        }
    }
}
