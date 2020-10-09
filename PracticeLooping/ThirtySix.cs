using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class ThirtySix
    {
        public static void PThirtySix()
        {
            Console.WriteLine("Enter how many lines you would like the pattern to display: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int lineNumber = 1;
            Console.WriteLine();
            for (int i = 1; i <= max; i++)
            {
                int counting = 1;
                int decrementing = lineNumber - 1;
                for (int j = 1; j <= lineNumber; j++)
                {
                    Console.Write(counting);
                    counting++;
                }
                for (int j = 1; j <= lineNumber - 1; j++)
                {
                    Console.Write(decrementing);
                    decrementing--;
                }
                lineNumber++;
                Console.WriteLine();
            }
        }
    }
}
