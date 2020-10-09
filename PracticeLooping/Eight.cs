using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class Eight
    {
        public static void PEight()
        {
            Console.WriteLine("Enter a number");
            string temp = Console.ReadLine();
            int userNum = Convert.ToInt32(temp);
            int sum = 0;
            for(int i = 0; i < userNum; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine("The sum of all the odd numbers is: " + sum);
        }
    }
}
