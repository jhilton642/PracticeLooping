using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class FiftyFive
    {
        public static void PFiftyFive()
        {
            Console.WriteLine("Enter a number: ");
            int decimalNum = Convert.ToInt32(Console.ReadLine());
            string hexNum = string.Format("{0:x}", decimalNum);
            Console.WriteLine("The hexidecimal version of your number is: " + hexNum);
        }
    }
}
