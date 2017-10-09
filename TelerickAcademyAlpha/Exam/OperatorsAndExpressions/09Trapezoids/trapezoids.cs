using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Trapezoids
{
    class trapezoids
    {
        static void Main()
        {
            double largeBase = double.Parse(Console.ReadLine());
            double smallBase = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double s = (double) (largeBase + smallBase)* height / 2;

            Console.WriteLine("{0:f7}", s);

            


        }
    }
}
