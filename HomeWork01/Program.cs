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
            Console.WriteLine(numberToWord(input));
        }

        static string numberToWord(int number)
        {
            string result = "";
            if (number < 0)
            {
                result = "minus ";
                number = -number;
            }
            List<string> numbersList = new List<string>
            {
                "nulis","vienas","du","trys","keturi","penki","sheshi","septyni","ashtuoni","devyni","deshimt",
                "vienuolika","dvylika", "trylika", "keturiolika","penkiolika","shehsiolika","septyniolika", 
                "ashtuomiolika","devyniolika"
            };
            return result += numbersList[number];
        }
    }
}