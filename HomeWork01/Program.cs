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
            string result = " ";
            if( number == 0)
            {
                return "Nulis";
            }

            if (number < 0)
            {
                result = "minus ";
                number = -number;
            }

            int lenght = 1;
            while (lenght > 0)
            {
                lenght = number.ToString().Length; 
                if (lenght <= 3 && number != 0)
                {
                    result += threeDigitsNumberToWord(number);
                    return result;
                }

                else if(lenght > 3 && lenght <= 6)
                {
                    int numberPart = number / 1000;
                    result += threeDigitsNumberToWord(numberPart) + " " + thousandWordCase(numberPart);
                    number = number % 1000;
                }
                else if(lenght > 6 && lenght <= 9)
                {
                    int numberPart = number / 1000000;
                    result += threeDigitsNumberToWord(numberPart) + " " + millionWordCase(numberPart);
                    number = number % 1000000;
                }
                else if(number == 0)
                {
                    return result;
                }
                else
                {
                    return "wrong number, number is too big";
                }
            }
            return result;
        }

        static string threeDigitsNumberToWord(int number)
        {
            string result = " ";
            string hundrets = "shimtai";
            int[] array = integerToArrayOfIntegers(number);
            if (array[0]<2)
            {
                hundrets = "shimtas";
            }
            switch (array.Length)
            {
                case 1:
                    result += oneDigitNumberToWord(number);
                    break;
                case 2:
                    result += twoDigitNumberToWord(array[0], array[1]);
                    break;
                case 3:
                    if (array[1] == 0 && array[2] != 0)
                    {
                        result += oneDigitNumberToWord(array[0]) + " " + hundrets + " " + oneDigitNumberToWord(array[2]);
                    }
                    else if (array[1] == 0 && array[2] == 0)
                    {
                        result += oneDigitNumberToWord(array[0]) + " " + hundrets;
                    }
                    else
                    {
                        result += oneDigitNumberToWord(array[0]) + " " + hundrets + " " + twoDigitNumberToWord(array[1], array[2]);
                    }
                    break;
                default:
                    result = "wrong number";
                    break;
            }
            return result;
        }

        static string millionWordCase(int number)// Pagal skai2iu grazina teisiklinga milijonu linksni
        {
            string result = "milijonai";
            int[] array = integerToArrayOfIntegers(number);

            switch (array.Length)
            {
                case 1:
                    if (number == 1)
                    {
                        result = "milijonas";
                    }
                    break;
                case 2:
                    if (number < 21 && number >= 10 || array[1] == 0)
                    {
                        result = "milijonu";
                    }
                    else if (number >= 21 && array[1] == 1)
                    {
                        result = "milijonas";
                    }
                    break;
                case 3:
                    if (array[2] == 0 || (number <= 120 && number >= 110) )
                    {
                        result = "milijonu";
                    }
                    else if (array[1] != 1 && array[2] == 1)
                    {
                        result = "milijonas";
                    }
                    else
                    {
                        result = "milijonai";
                    }
                    break;
                default:
                    result = "wrong number";
                    break;
            }
            return result;
        }

        static string thousandWordCase(int number)// Pagal skai2iu grazina teisiklinga tukstanci linksni
        {
            string result = "tukstanciai";
            int[] array = integerToArrayOfIntegers(number);

            switch (array.Length)
            {
                case 1:
                    if (number == 1)
                    {
                        result = "tukstantis";
                    }
                    break;
                case 2:
                    if (number < 21 && number >= 10 || array[1] == 0)
                    {
                        result = "tukstanciu";
                    }
                    else if (number >= 21 && array[1] == 1)
                    {
                        result = "tukstantis";
                    }
                    break;
                case 3:
                    if (array[2] == 0 || (number <= 120 && number >= 110))
                    {
                        result = "tukstanciu";
                    }
                    else if (array[1] != 1 && array[2] == 1)
                    {
                        result = "tukstantis";
                    }
                    else
                    {
                        result = "tukstanciai";
                    }
                    break;
                default:
                    result = "wrong number";
                    break;
            }
            return result;

        }


        static int [] integerToArrayOfIntegers(int number)
        {
            int[] result = number.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            return result;
        }

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