using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class Fourteen
    {
        public static void PFourteen()
        {
            Console.WriteLine("Enter the hight you would like your pyramid");
            string temp = Console.ReadLine();
            int pyramidHeight = System.Convert.ToInt32(temp);
            string asterisk = "*";
            int spaces = pyramidHeight - 1;
            int asteriskCount = 1; 
            for (int i = 0; i < pyramidHeight;i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < asteriskCount; j++)
                {
                    Console.Write(asterisk + " ");
                }
                Console.WriteLine();
                spaces--;
                asteriskCount++;
            }
        }
    }
}
