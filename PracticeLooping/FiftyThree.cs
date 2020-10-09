using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class FiftyThree
    {
        public static void PFiftyThree()
        {
            Console.WriteLine("Enter a binary number: ");
            int binaryNum = Convert.ToInt32(Console.ReadLine());
            int decimalNum = 0;
            int base2 = 1;
            while (binaryNum > 0)
            {
                int remainder = binaryNum % 10;
                binaryNum = binaryNum / 10;
                decimalNum += remainder * base2;
                base2 = base2 * 2;
            }
            int octalNum = 0;
            int base1 = 1;
            while (decimalNum > 0)
            {
                int remainder = decimalNum % 8;
                decimalNum = decimalNum / 8;
                octalNum += remainder * base1;
                base1 = base1 * 10;
            }
            Console.WriteLine("The octal equivalent of your number is: " + octalNum);
        }
    }
}
