namespace _08DigitasWord
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class DigitasWord
    {
        static void Main()
        {
            string digit = Console.ReadLine();
            var digitWord = string.Empty;
            switch (digit)
            {
                case "0": digitWord = "zero";
                    break;
                case "1":
                    Console.WriteLine("one");
                    break;
                case "2":
                    digitWord = "two";
                    break;
                case "3":
                    digitWord = "three";
                    break;
                case "4":
                    digitWord = "four";
                    break;
                case "5":
                    digitWord = "five";
                    break;
                case "6":
                    digitWord = "six";
                    break;
                case "7":
                    digitWord = "seven";
                    break;
                case "8":
                    digitWord = "eight";
                    break;
                case "9":
                    digitWord = "nine";
                    break;
                default:
                    digitWord = "not a digit"; 
                      break;
            }
            Console.WriteLine(digitWord);
        }
    }
}
