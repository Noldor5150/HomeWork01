using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork01
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numberInRange(input,-9,9));
            
        }

        static bool numberInRange(int inputValue,int bottomLimit, int upperLimit)
        {
            return inputValue <= upperLimit && inputValue >= bottomLimit;
        }
    }
}
