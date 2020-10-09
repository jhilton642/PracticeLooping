using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class Fifteen
    {
        public static void PFifteen()
        {
            Console.WriteLine("Enter a number: ");
            string temp = Console.ReadLine();
            int usrNum = Convert.ToInt32(temp);
            int factorial = 1;
            for (int i = usrNum; i > 0; i--){
                factorial = factorial* i;
            }
            Console.WriteLine("The factorial of your number is: " + factorial);
        }
    }
}
