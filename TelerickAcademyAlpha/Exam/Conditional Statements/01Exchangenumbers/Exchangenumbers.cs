﻿namespace _01Exchangenumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Exchangenumbers
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = 0D;
            if (A > B)
            {
                C = A;
                A = B;
                B = C;
                               
            }
            Console.WriteLine("{0} {1}", A,B);
         }
    }
}
