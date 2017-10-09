namespace _01Allocatearray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Allocatearray
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * 5;

            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
