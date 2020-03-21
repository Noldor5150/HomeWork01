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
            Console.WriteLine(stringIsANumber(digit));
        }

        static bool stringIsANumber(string possibleNumber)
        {
            bool stringIsANumber = false;
            char[] rightNumbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] arrayOfPossibleNumbers = possibleNumber.ToCharArray();
            List<char> listOfPossibleNumbers = arrayOfPossibleNumbers.ToList();
            List<char> compareChars = new List<char>() { };

            if (listOfPossibleNumbers[0] == '-')
            {
                listOfPossibleNumbers.RemoveAt(0);
                char[] arrayPositivePossibleNumber = listOfPossibleNumbers.ToArray();
                possibleNumber = new string(arrayPositivePossibleNumber);
            }
                foreach (char posibleNumber in listOfPossibleNumbers)
                {
                    foreach (char rightNumber in rightNumbers)
                    {
                        if (posibleNumber == rightNumber)
                        {
                            compareChars.Add(posibleNumber);
                        }
                    }
                }
                char[] array = compareChars.ToArray();
                string myNumber = new string(array);

                if (myNumber == possibleNumber)
                {
                    stringIsANumber = true;
                }
            
            return stringIsANumber;
        }
    }
}
