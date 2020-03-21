using System;
using System.Collections.Generic;
using System.Linq;
namespace HomeWork01
{
    class Program
    {
        static void Main(string[] args)
        {
            string digit = Console.ReadLine();
            Console.WriteLine(digit);
            Console.WriteLine(isStringANumber(digit));
        }
        static bool isStringANumber(string possibleNumber)
        {
            char[] rightNumbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            List<char> listOfPossibleNumbers = possibleNumber.ToList();

            if (listOfPossibleNumbers[0] == '-')
            {
                listOfPossibleNumbers.RemoveAt(0);
            }
                
            foreach (char posibleNumber in listOfPossibleNumbers)
            {
                foreach (char rightNumber in rightNumbers)
                {
                    if (posibleNumber != rightNumber)
                        return false;
                }
            }

            return true;
        }
    }
}