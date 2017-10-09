

namespace _02NotDivisibleNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NotDivisibleNumbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 7 != 0 && i % 3 != 0)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
