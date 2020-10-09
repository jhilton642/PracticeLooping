using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class ThirtyTwo
    {
        public static void PThirtyTwo()
        {
            Console.WriteLine("Enter a positive number");
            string temp = Console.ReadLine();
            int userNumber = Convert.ToInt32(temp);
            int answer = 0;
            if(userNumber == 1)
            {
                Console.WriteLine("Your number is not a prime number");
            }
            if (userNumber == 2)
            {
                Console.WriteLine("Your number is a prime number");
            }
            for(int i = 2; i < userNumber; i++)
            {
                if (userNumber % i == 0)
                {
                    answer = 1;
                    break;
                }
                if(userNumber%i!=0)
                {
                    answer = 2;
                }
            }
            if (answer == 1)
            {
                Console.WriteLine("Your number is not a prime number");
            }
            if(answer == 2)
            {
                Console.WriteLine("Your number is a prime number");
            }
        }
    }
}
