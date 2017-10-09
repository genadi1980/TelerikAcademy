using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long digit = long.Parse(Console.ReadLine());
            bool isPrime = true;
            
            for (long i = 2; i <= Math.Sqrt(digit); i++)
            {
                if (digit % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");
            
        }
    }
}