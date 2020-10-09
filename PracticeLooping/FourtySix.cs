using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class FourtySix
    {
        public static void PFourtySix()
        {
            Console.WriteLine("Enter a binary number: ");
            int binaryNum = Convert.ToInt32(Console.ReadLine());
            int decimalNum = 0;
            int base1 = 1;
            while (binaryNum > 0)
            {
                int remainder = binaryNum % 10;
                binaryNum = binaryNum / 10;
                decimalNum += remainder * base1;
                base1 = base1 * 2;
            }
            Console.WriteLine("The decimal number is: " + decimalNum);
        }
    }
}
