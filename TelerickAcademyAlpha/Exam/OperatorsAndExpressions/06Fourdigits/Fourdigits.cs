namespace _06Fourdigits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Fourdigits
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            var number = input;
            var sum = 0;
            var sumInput = input;
            var revInput = input;

            for (int i = 1; i <= 4; i++)
            {                
                var digit = sumInput % 10;
                sumInput /= 10;
                sum += digit;
            }
            Console.WriteLine(sum);
            for (int i = 1; i <= 4; i++)
            {
                
                var revNumber = revInput % 10;
                revInput /= 10;
                Console.Write(revNumber);
            }
            Console.WriteLine();

            var Digit4 = input % 10;
            number = input / 10;
            var Digit3 = number % 10;
            number = number / 10;
            var Digit2 = number % 10;
            number = number / 10;
            var Digit1 = number % 10;

            Console.Write("{3}{0}{1}{2}", Digit1, Digit2, Digit3, Digit4);
            Console.WriteLine();
            Console.WriteLine("{0}{2}{1}{3}", Digit1, Digit2, Digit3, Digit4);
        }
    }
}
