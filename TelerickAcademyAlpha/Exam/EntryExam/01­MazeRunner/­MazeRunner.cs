namespace _01­MazeRunner
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MazeRunner
    {
        public static void Main()
        {
            var inputLines = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var evenSum = 0;
            for (int i = 0; i < inputLines; i++)
            {
                var number = int.Parse(Console.ReadLine());
                for (int j = 0; j < 4; j++)
                {
                    var digit = number % 10;
                    number /= 10;
                    if (digit % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                }
                if (evenSum > oddSum)
                {
                    Console.WriteLine("left");
                }
                else if (evenSum < oddSum)
                {
                    Console.WriteLine("right");
                }
                else
                {
                    Console.WriteLine("continue straight");
                }

            }
            
        }
    }
}
