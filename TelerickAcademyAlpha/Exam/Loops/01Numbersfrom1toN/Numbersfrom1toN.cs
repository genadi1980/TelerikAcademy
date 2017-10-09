namespace _01Numbersfrom1toN
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Numbersfrom1toN
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
