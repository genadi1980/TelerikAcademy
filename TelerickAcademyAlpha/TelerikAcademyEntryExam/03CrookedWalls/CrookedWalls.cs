

namespace _03CrookedWalls
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CrookedWalls
    {
        public static void Main()
        {
            var sequence = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var absDiff = 0L;
            var sum = 0L;
            for (int i = 1; i < sequence.Length; i++)
            {
                absDiff = Math.Abs(sequence[i] - sequence[i - 1]);
                if (absDiff % 2 == 0)
                {
                    i++;
                    sum += absDiff;
                }

            }

            Console.WriteLine(sum);
        }
    }
}
