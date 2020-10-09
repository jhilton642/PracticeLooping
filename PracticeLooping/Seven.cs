using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class Seven
    {
        public static void PSeven()
        {
            Console.WriteLine("Enter a number");
            string temp = Console.ReadLine();
            int userNum = Convert.ToInt32(temp);
            Console.Write(" ");
            for (int i = 0; i <= userNum; i++)
            {
                Console.Write("    " + i);
            }

                for(int j = 0; j <= userNum; j++)
                {
                Console.WriteLine();
                    Console.Write(j);
                for(int i =0; i<= userNum; i++)
                {
                    Console.Write("    " + i*j);
                    
                }
                }
            Console.WriteLine();
            
        }
    }
}
