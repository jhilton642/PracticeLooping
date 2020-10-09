using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class ThirtyFive
    {
        public static void PThirtyFive()
        {
            int firstNum = 0;
            int secondNum = 1;
            Console.WriteLine("Enter how many Fibonacci numbers you want to see: ");
            string howMany = Console.ReadLine();
            int howManyNums = Convert.ToInt32(howMany);
            Console.WriteLine(firstNum);
            for (int i = 2; i <= howManyNums; i++)
            {
                int temp = firstNum;
                firstNum = firstNum + secondNum;
                secondNum = temp;
                Console.WriteLine(firstNum);
            }
        }
    }
}
