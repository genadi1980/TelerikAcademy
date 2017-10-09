namespace _06QuadraticEquation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class QuadraticEquation
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var x1 = 0D;
            var x2 = 0D;

            var D = Math.Pow(b, 2) - (4 * a * c);
            

            if(D == 0)
            {
                x1 = - b / (2 * a);
                Console.WriteLine("{0:f2}", x1);
            }
            else if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);

                Console.WriteLine("{0:f2}", Math.Min(x1,x2));
                Console.WriteLine("{0:f2}", Math.Max(x1, x2));                
            }
            else Console.WriteLine("no real roots"); 

        }
    }
}
