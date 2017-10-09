namespace _05NumberComparer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NumberComparer
    {
        public static void Main()
        {
            var A = double.Parse(Console.ReadLine());
            var B = double.Parse(Console.ReadLine());

            var BiggerNumber = Math.Max(A, B);

            Console.WriteLine(BiggerNumber);
        }
    }
}
