namespace _05Biggestof3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Biggestof3
    {
        static void Main()
        {
            var first = double.Parse(Console.ReadLine());
            var second = double.Parse(Console.ReadLine());
            var third = double.Parse(Console.ReadLine());
            var max = 0D;

            if (first >= second)
            {
                max = first;
            }
            else max = second;
            if (max <= third) 
            {
                max = third;
            }
            Console.WriteLine(max);
        }
    }
}
