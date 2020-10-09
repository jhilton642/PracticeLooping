using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class Seventeen
    {
        public static void PSeventeen()
        {
            Console.WriteLine("Enter the hight you would like your pyramid");
            string temp = Console.ReadLine();
            int pyramidHeight = Convert.ToInt32(temp);
            int spaces = pyramidHeight-1;
            Console.WriteLine();
            for(int i = 1; i <= pyramidHeight; i++)
            {
                Console.WriteLine();
                for(int j= 1; j<=spaces;j++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                spaces--;
            }
            Console.WriteLine();
        }
    }
}
