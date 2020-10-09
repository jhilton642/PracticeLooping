using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class Thirteen
    {
        public static void PThirteen()
        {
            Console.WriteLine("Enter the hight you would like your pyraid");
            string temp = Console.ReadLine();
            int pyramidHeight = System.Convert.ToInt32(temp);
            Console.WriteLine();
            int spaces = pyramidHeight-1;
            int digits = 1;
            int digitCounter = 0;
            for(int i = 0; i < pyramidHeight; i++) 
            {
                for (int j = 0; j < spaces; j++)
                {

                    Console.Write(" ");
                }
                for(int j = 0;j < digits ; j++)
                {
                    digitCounter++;
                    Console.Write(digitCounter + " ");
                    

                }
                Console.WriteLine();
                digits++;
                spaces--;
            }
           
        }
       
    }
}
