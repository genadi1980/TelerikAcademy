namespace _07Pointinacircle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Pointinacircle
    {
        public static void Main()
        {
            var x = Math.Abs(double.Parse(Console.ReadLine()));
            var y = Math.Abs(double.Parse(Console.ReadLine()));

            var distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            bool InCircle = (x <= 2 && y <= 2 && distance <= 2);

            if (!InCircle)
            {
                Console.WriteLine("no {0:f2}", distance);
            }
            else
                Console.WriteLine("yes {0:f2}", distance);
        }
    }
}
