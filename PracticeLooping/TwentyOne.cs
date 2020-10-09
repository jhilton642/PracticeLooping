using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class TwentyOne
    {
        public static void PTwentyOne()
        {
            Console.WriteLine("Enter a number between 1 and 10");
            string temp1 = Console.ReadLine();
            int userNumber = Convert.ToInt32(temp1);
            Console.WriteLine("Enter how many terms would you like the series to go to");
            string temp2 = Console.ReadLine();
            int seriesNumber = Convert.ToInt32(temp2);
            int sum=userNumber;
            int nextNum = userNumber;
            Console.WriteLine();
            Console.Write("[" + userNumber);
            for (int i = 1; i < seriesNumber; i++)
            {
                 nextNum = nextNum * 10 + userNumber;
                sum += nextNum;
                Console.Write(" + " + nextNum);
            }
            Console.WriteLine("]");
            string suffix;
            if(seriesNumber == 1)
            {
                suffix = "st";
            }
            else if(seriesNumber == 2)
            {
                suffix = "nd";
            }
            else if(seriesNumber == 3)
            {
                suffix = "rd";
            }
            else
            {
                suffix = "th";
            }
            Console.WriteLine("The sum of the series to the " + seriesNumber + suffix + " term is: " + sum);
        }
    }
}
