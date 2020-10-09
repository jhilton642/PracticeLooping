using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class ThirtyNine
    {
        public static void PThirtyNine()
        {
            int sum = 0;
            for(int i = 100; i < 200; i++)
            {
                if (i % 9 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum of all intigers between 100 and 200 that are divisible by 9 is: " + sum);
        }
    }
}
