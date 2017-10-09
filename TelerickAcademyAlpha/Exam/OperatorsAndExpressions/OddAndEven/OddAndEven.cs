using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class OddAndEven
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            var remainder = input % 2;
                if (remainder == 0)
                {
                    Console.WriteLine("even {0}", input);
                }
                else Console.WriteLine("odd {0}", input);
        }
    }

