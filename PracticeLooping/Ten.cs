using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class Ten
    {
        public static void PTen()
        {
            Console.WriteLine("Enter the hight you would like your right triangle");
            string temp = Console.ReadLine();
            int triangleHeight = Convert.ToInt32(temp);
            Console.WriteLine();
            for (int i = 1; i <= triangleHeight; i++)
            {
                Console.WriteLine(i);
                if (i == triangleHeight)
                {
                    break;
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
            }
        }
    }
}
