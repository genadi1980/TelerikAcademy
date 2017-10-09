namespace _10FibonacciNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FibonacciNumbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            int i = 0, j = 1, k, t;

            if (n >= 2)
            {
                Console.Write("0, 1");
                
                for (k = 2; k < n; ++k)
                {
                    Console.Write(", ");
                    t = i + j;
                    i = j;
                    j = t;
                    Console.Write(j);
                    
                }
            }
            else if (n == 0)
            {
                Console.Write("0");
            }
            else if (n == 1)
            {
                Console.Write("0, 1");
            }
            

            }

    }
}
