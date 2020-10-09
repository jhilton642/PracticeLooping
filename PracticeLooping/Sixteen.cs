using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class Sixteen
    {
        public static void PSixteen()
        {
            Console.WriteLine("Enter a number: ");
            string temp = Console.ReadLine();
            int usrNum = Convert.ToInt32(temp);
            int evenNum = usrNum / 2;
            if (evenNum % 2 == 1)
            {
                evenNum++;
            }
            if (evenNum % 2 == 0)
            {
                Console.WriteLine("The closest even number between your number and zero is: " + evenNum);
            }
            int sum = usrNum + evenNum;
            Console.WriteLine("The sum of your number and the even number is: " + sum);
        }
    }
}
