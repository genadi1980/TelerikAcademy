namespace _03Circle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Circle
    {
        public static void Main()
        {
            var radius = double.Parse(Console.ReadLine());

            var perimeter = 2 * Math.PI * radius;

            var area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("{0:f2} {1:f2}",perimeter, area);
        }
    }
}
