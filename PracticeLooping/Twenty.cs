using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class Twenty
    {
        public static void PTwenty()
        {
            Console.WriteLine("Enter the hight you would like your pyramid");
            string temp = Console.ReadLine();
            int pyramidHeight = Convert.ToInt32(temp);
            int spaces = pyramidHeight - 1;
            string asterisk = "*";
            int asteriskCount = 1;
            Console.WriteLine();
            for(int i = 1;i<=pyramidHeight;i++)
            {
                for(int j = 1;j<=spaces; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= asteriskCount; j++)
                {
                    Console.Write(asterisk);
                }
                Console.WriteLine();
                spaces--;
                asteriskCount+=2;
            }
        }
    }
}
