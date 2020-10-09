using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class ThirtyOne
    {
        public static void PThirtyOne()
        {
            Console.WriteLine("Enter the hight you would like your diamond (it must be an odd number)");
            string temp = Console.ReadLine();
            int diamondHight = Convert.ToInt32(temp);
            if (diamondHight % 2 == 0)
            {
                Console.WriteLine("That is not an odd number try again");
                PracticeLooping.ThirtyOne.PThirtyOne();
            }
            else
            {


                int spaces = diamondHight / 2;
                string asterisk = "*";
                int asteriskCount = 1;
                Console.WriteLine();
                for (int i = 1; i <= diamondHight / 2; i++)
                {
                    for (int j = 1; j <= spaces; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= asteriskCount; j++)
                    {
                        Console.Write(asterisk);
                    }
                    Console.WriteLine();
                    spaces--;
                    asteriskCount += 2;
                }
                for (int i = 0; i <= diamondHight / 2; i++)
                {
                    for (int j = 1; j <= spaces; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= asteriskCount; j++)
                    {
                        Console.Write(asterisk);
                    }
                    Console.WriteLine();
                    spaces++;
                    asteriskCount -= 2;
                }

            }
        }
    }
}
