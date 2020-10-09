using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class Fifty
    {
        public static void PFifty()
        {
            Console.WriteLine("Enter a number: ");
            int decimalNum = Convert.ToInt32(Console.ReadLine());
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
