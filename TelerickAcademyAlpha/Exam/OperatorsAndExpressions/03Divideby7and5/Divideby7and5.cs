using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Divideby7and5
{
    class Divideby7and5
    {
        static void Main()
        {
            var inputNumber = int.Parse(Console.ReadLine());

            bool isTrueNumber = (inputNumber % 7 == 0) && (inputNumber % 5 == 0);

            if(!isTrueNumber)
            {
                Console.WriteLine("false {0}", inputNumber);
            }
            else
            { 
                Console.WriteLine("true {0}", inputNumber);
            }

        }
    }
}
