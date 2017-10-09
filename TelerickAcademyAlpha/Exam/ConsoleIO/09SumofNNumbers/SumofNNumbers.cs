using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09SumofNNumbers
{
    public class SumofNNumbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0D;

            for (int i = 1; i <= n; i++)
            {
                var numbers = double.Parse(Console.ReadLine());
                sum += numbers;

            }

            Console.WriteLine(sum);
        }
    }
}
