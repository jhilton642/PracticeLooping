using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class Two
    {
        public static void PTwo()
        {
            Console.WriteLine("Enter a number");
            string temp = Console.ReadLine();
            int userNum = Convert.ToInt32(temp);
            int answer = 0;
            for(int i = 0; i <= userNum; i++)
            {
                 answer += i;
                
            }
            Console.WriteLine("The sum of numbers from 0 to " + userNum + " is " + answer + ".");
        }
    }
}
