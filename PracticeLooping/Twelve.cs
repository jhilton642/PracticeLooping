using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class Twelve
    {
        public static void PTwelve()
        {
            Console.WriteLine("Enter the hight you would like your right triangle");
            string temp = Console.ReadLine();
            int triangleHeight = Convert.ToInt32(temp);
            Console.WriteLine();
            int digitCounter = 0;
            for (int i = 1; i <= triangleHeight; i++)
            {
                digitCounter++;
                Console.WriteLine(digitCounter + "  ");
                if (i == triangleHeight)
                {
                    break;
                }
                for (int j = 1; j <= i; j++)
                {
                    digitCounter++;
                    Console.Write(digitCounter + "  ");
                }
            }
            Console.WriteLine();
        }
    }
}
