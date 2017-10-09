namespace _04FormattingNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FormattingNumbers
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            string numbeerBinary = Convert.ToString(a, 2);

            Console.WriteLine(" {0}   {1}   {2}  ", a,b,c);
            Console.WriteLine("{0:X}", a);
            Console.WriteLine("{0}", numbeerBinary);
            Console.WriteLine("{0:f2}",b);
            Console.WriteLine("{0:f2}", c);
        } 
    }
}
