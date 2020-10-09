using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class Four
    {
        public static void PFour()
        {
            int[] userNums = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number");
                string temp = Console.ReadLine();
                int userNum = Convert.ToInt32(temp);
                userNums[i] = userNum; 
            }
            int sum = 0;
            for(int i =0; i< userNums.Length; i++)
            {
                sum += userNums[i];
            }
            int average = sum / userNums.Length;
            Console.WriteLine("The sum of your numbers is: " + sum);
            Console.WriteLine("The average of your numbers is: " + average);
        }
    }
}
