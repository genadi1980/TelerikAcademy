namespace CrookedStairs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CrookedStairs
    {
        public static void Main()
        {
            
            var brickHeight1 = int.Parse(Console.ReadLine());
            var brickHeight2 = int.Parse(Console.ReadLine());
            var brickHeight3 = int.Parse(Console.ReadLine());
            var count = 0;
            int L = int.Parse(Console.ReadLine());

            int numbersLength = L * L;

            long[] numbers = new long[numbersLength];
            numbers[0] = brickHeight1;
            numbers[1] = brickHeight2;
            numbers[2] = brickHeight3;

            for (int i = 3; i < numbersLength; i++)
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2] + numbers[i - 3];
            }

            

            for (int i = 0; i < L; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    if (j != 0)
                    {
                        Console.Write(" {0}", numbers[count]);
                        count++;

                    }
                    else
                    {
                        Console.Write("{0}", numbers[count]);
                        count++;
                    }

                }

                Console.WriteLine();
            }

            
        }
    }
}
