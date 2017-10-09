namespace _06Biggestof5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Biggestof5
    {
        static void Main()
        {
            var max = Double.MinValue;
            for (int i = 0; i < 5; i++)
            {
                var number = double.Parse(Console.ReadLine());
                

                if (number > max)
                {
                    max = number;
                }
                
            }
            Console.WriteLine(max);
        }
    }
}
