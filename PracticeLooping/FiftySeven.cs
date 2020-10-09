using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class FiftySeven
    {
        public static void PFiftySeven()
        {
            Console.WriteLine("Enter a sentance: ");
            string userString = Console.ReadLine();
            string[] user = userString.Split(" ");
            for (int i = user.Length-1; i >= 0; i--)
            {
                Console.Write(user[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
