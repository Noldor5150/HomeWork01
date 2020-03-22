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
            int[] array = integerToArrayOfIntegers(number);
            switch (array.Length)
            {
                case 1:
                    result += oneDigitNumberToWord(number);
                    break;
                case 2:
                    result += twoDigitNumberToWord(array[0], array[1]);
                    break;
                case 3:
                    if (array[1] == 0)
                    {
                        result += oneDigitNumberToWord(array[0]) + " " + "shimtai" + " " + oneDigitNumberToWord(array[2]);
                    }
                    else
                    {
                        result += oneDigitNumberToWord(array[0]) + " " + "shimtai" + " " + twoDigitNumberToWord(array[1], array[2]);
                    }
                    break;
                case 4:
                    if (array[1] == 0 && array[2]==0 && array[3] == 0)
                    {
                        result += oneDigitNumberToWord(array[0]) + " " + "tukstanciai";
                    }
                    else if(array[1] == 0 && array[2] == 0)
                    {
                        result += oneDigitNumberToWord(array[0]) + " " + "tukstanciai" + " "  +oneDigitNumberToWord(array[3]);
                    }
                    else if (array[1] == 0)
                    {
                        result += oneDigitNumberToWord(array[0]) + " " + "tukstanciai" + " " + twoDigitNumberToWord(array[2], array[3]);
                    }
                    else if(array[2] == 0 && array[3] == 0)
                    {
                        result += oneDigitNumberToWord(array[0]) + " " + "tukstanciai" + " " + oneDigitNumberToWord(array[1]) + " " + "shimtai";
                    }
                    else if (array[2] == 0)
                    {
                        result += oneDigitNumberToWord(array[0]) + " " + "tukstanciai" + " " + oneDigitNumberToWord(array[1]) + " " + "shimtai" + " " + oneDigitNumberToWord(array[3]);
                    }
                    else
                    {
                        result += oneDigitNumberToWord(array[0]) + " " + "tukstanciai" + " " + oneDigitNumberToWord(array[1]) + " " + "shimtai" + " " + twoDigitNumberToWord(array[2], array[3]);
                    }
                    break;
                default:
                    result="wrong number";
                    break;
            }
            return result;
        }



        static int [] integerToArrayOfIntegers(int number)
        {
            int[] result = number.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            return result;
        }

        /*static int arrayOfIntegersToInteger(int[]array)
        {
            string number="";
            int result;

            foreach (int test in array)
            {
                number += test.ToString();
            }
            result = int.Parse(number);
            return result;
        }*/
        static string number2090ToWord(int number)
        {
            List<string> numbersList2090 = new List<string>
            {
                "dvideshimt","trisdeshimt","keturiasdeshimt","penkiasdeshimt","sheshiasdeshimt","septyniasdeshimt","ashtuoniasdeshimt","devyniasdeshimt"
            };
            string result = numbersList2090[number - 2];
            return result;
        }
        static string oneDigitNumberToWord(int number)
        {
            string result;
         
            List<string> numbersList09 = new List<string>
            {
                "nulis","vienas","du","trys","keturi","penki","sheshi",
                "septyni","ashtuoni","devyni"

            };
            result = numbersList09[number];

            return result;
        }
        static string twoDigitNumberToWord(int a, int b)
        {
            string result;
           
            List<string> numbersList1019 = new List<string>
            {
                "deshimt","vienuolika","dvylika", "trylika", "keturiolika","penkiolika",
                "sheshiolika","septyniolika" ,"ashtuomiolika","devyniolika"
            };

            if(a == 1)
            {
                result = numbersList1019[b];
            }
            else if (b == 0)
            {
                result = number2090ToWord(a);
            }
            else
            {
                result = number2090ToWord(a) + " " + oneDigitNumberToWord(b);
            }
            return result;

        }
     
    }
}