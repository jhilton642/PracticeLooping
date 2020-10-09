using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class ThirtySeven
    {
        public static void PThirtySeven()
        {
            Console.WriteLine("Enter a number: ");
            string userInput = Console.ReadLine();
            char[] input = userInput.ToCharArray();
            Stack backwordsNum = new Stack();
            foreach (var item in input)
            {
                backwordsNum.Push(item);
            }
            Console.Write("Your number in reverse order is: ");
            foreach (var item in backwordsNum)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
