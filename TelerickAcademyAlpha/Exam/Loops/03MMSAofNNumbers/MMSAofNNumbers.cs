namespace _03MMSAofNNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MMSAofNNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var max = double.MinValue;
            var min = double.MaxValue;
            var sum = 0D;
            var avg = 0D;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number >= max)
                {
                    max = number; 
                }

                if (number <= min)
                {
                    min = number;
                }

                sum += number;
                avg = sum / n;
            }

            Console.WriteLine("min={0:f2}",min);
            Console.WriteLine("max={0:f2}", max);
            Console.WriteLine("sum={0:f2}", sum);
            Console.WriteLine("avg={0:f2}", avg);
        }
    }
}
