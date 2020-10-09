using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLooping
{
    class Fourty
    {
        public static void PFourty()
        {
            Console.WriteLine("Enter how many lines you would like the pattern to display: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int lineNumber = 1;
            string countingResult = "";
            string decrementingResult = "";
            Console.WriteLine();
            for (int i = 1; i <= max; i++)
            {
                int counting = 1;
                int decrementing = lineNumber - 1;
                for (int j = 1; j <= lineNumber; j++)
                {
                    switch (counting)
                    {
                        case 1:
                            countingResult = "A";
                            break;
                        case 2:
                            countingResult = "B";
                            break;
                        case 3:
                            countingResult = "C";
                            break;
                        case 4:
                            countingResult = "D";
                            break;
                        case 5:
                            countingResult = "E";
                            break;
                        case 6:
                            countingResult = "F";
                            break;
                        case 7:
                            countingResult = "G";
                            break;
                        case 8:
                            countingResult = "H";
                            break;
                        case 9:
                            countingResult = "I";
                            break;
                        case 10:
                            countingResult = "J";
                            break;
                        case 11:
                            countingResult = "K";
                            break;
                        case 12:
                            countingResult = "L";
                            break;
                        case 13:
                            countingResult = "M";
                            break;
                        case 14:
                            countingResult = "N";
                            break;
                        case 15:
                            countingResult = "O";
                            break;
                        case 16:
                            countingResult = "P";
                            break;
                        case 17:
                            countingResult = "Q";
                            break;
                        case 18:
                            countingResult = "R";
                            break;
                        case 19:
                            countingResult = "S";
                            break;
                        case 20:
                            countingResult = "T";
                            break;
                        case 21:
                            countingResult = "U";
                            break;
                        case 22:
                            countingResult = "V";
                            break;
                        case 23:
                            countingResult = "W";
                            break;
                        case 24:
                            countingResult = "X";
                            break;
                        case 25:
                            countingResult = "Y";
                            break;
                        case 26:
                            countingResult = "Z";
                            break;
                    }
                    Console.Write(countingResult);
                    counting++;
                }
                for (int j = 1; j <= lineNumber - 1; j++)
                {
                    switch (decrementing)
                    {
                        case 1:
                            decrementingResult = "A";
                            break;
                        case 2:
                            decrementingResult = "B";
                            break;
                        case 3:
                            decrementingResult = "C";
                            break;
                        case 4:
                            decrementingResult = "D";
                            break;
                        case 5:
                            decrementingResult = "E";
                            break;
                        case 6:
                            decrementingResult = "F";
                            break;
                        case 7:
                            decrementingResult = "G";
                            break;
                        case 8:
                            decrementingResult = "H";
                            break;
                        case 9:
                            decrementingResult = "I";
                            break;
                        case 10:
                            decrementingResult = "J";
                            break;
                        case 11:
                            decrementingResult = "K";
                            break;
                        case 12:
                            decrementingResult = "L";
                            break;
                        case 13:
                            decrementingResult = "M";
                            break;
                        case 14:
                            decrementingResult = "N";
                            break;
                        case 15:
                            decrementingResult = "O";
                            break;
                        case 16:
                            decrementingResult = "P";
                            break;
                        case 17:
                            decrementingResult = "Q";
                            break;
                        case 18:
                            decrementingResult = "R";
                            break;
                        case 19:
                            decrementingResult = "S";
                            break;
                        case 20:
                            decrementingResult = "T";
                            break;
                        case 21:
                            decrementingResult = "U";
                            break;
                        case 22:
                            decrementingResult = "V";
                            break;
                        case 23:
                            decrementingResult = "W";
                            break;
                        case 24:
                            decrementingResult = "X";
                            break;
                        case 25:
                            decrementingResult = "Y";
                            break;
                        case 26:
                            decrementingResult = "Z";
                            break;
                    }
                    Console.Write(decrementingResult);
                    decrementing--;
                }
                lineNumber++;
                Console.WriteLine();
            }

        }
    }
}
