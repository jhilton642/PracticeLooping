using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class FiftyFour
    {
        public static void PFiftyFour()
        {
            Console.WriteLine("Enter an octal number: ");
            string stringNum = Console.ReadLine();
            int numberLength = stringNum.Length;
            int octalNum = Convert.ToInt32(stringNum);
            int decimalNum = 0;
            int divideBy = 0;
            int leftNum = 0;
            switch (numberLength)
            {
                case 1:
                    divideBy = 1;
                    break;
                case 2:
                    divideBy = 10;
                    break;
                case 3:
                    divideBy = 100;
                    break;
                case 4:
                    divideBy = 1000;
                    break;
                case 5:
                    divideBy = 10000;
                    break;
                case 6:
                    divideBy = 100000;
                    break;
                case 7:
                    divideBy = 1000000;
                    break;
                case 8:
                    divideBy = 10000000;
                    break;
                case 9:
                    divideBy = 100000000;
                    break;
                case 10:
                    divideBy = 1000000000;
                    break;
            }
            while (octalNum > 0)
            {
                leftNum = octalNum / divideBy;
                decimalNum = (decimalNum + leftNum) * 8;
                octalNum = octalNum % divideBy;
                divideBy = divideBy / 10;
                if (octalNum < 8)
                {
                    decimalNum += octalNum;
                    break;
                }
                else
                {
                    continue;
                }
            }
            int remainder;
            string result = "";
            while (decimalNum > 0)
            {
                remainder = decimalNum % 2;
                decimalNum /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Your number in binary is " + result);
        }
    }
}
