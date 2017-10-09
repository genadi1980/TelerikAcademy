namespace _07Sort3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Sort3Numbers
    {
        static void Main()
        {
            double max = double.MinValue;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

                if (a >= b && b >= c && a >= c )
                {
                    max = a;
                }
                else if (a >= b && b <= c && a >= c)
                {
                    max = a;
                    a = b;
                    b = c;
                    c = a;
                }
                else if (a <= b && b >= c && a >= c)
                {
                    max = b;
                    b = a;
                }
                else if (a <= b && b >= c && a <= c)
                {
                    max = b;
                    b = c;
                    c = a;
                    
                }
                else if (a >= b && b <= c && a <= c)
                {
                    max = c;
                    c = b;
                    b = a; 
                    
                }
                else if (a <= b && b <= c && a <= c)
                {
                    max = c;
                    c = a;

                }
            

            Console.WriteLine("{0} {1} {2}", max, b, c);

        }
    }
}
