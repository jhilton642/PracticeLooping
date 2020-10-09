using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class ThirtyEight
    {
        public static void PThirtyEight()
        {
            Console.WriteLine("Enter a number: ");
            string userInput = Console.ReadLine();
            char[] input = userInput.ToCharArray();
            string string2 = "";
            foreach (var item in input)
            {
                string2 = item + string2;
            }
            if(string2.Equals(userInput))
            {
                Console.WriteLine("Your number is a palendrome");
            }
            else
            {
                Console.WriteLine("Your number is not a palendrome");
            }
        }
    }
}
