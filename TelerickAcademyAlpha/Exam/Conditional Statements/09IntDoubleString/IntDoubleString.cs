namespace _09IntDoubleString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class IntDoubleString
    {
        static void Main()
        {
            string typeInput = Console.ReadLine();


            switch (typeInput)
            {
                case "integer":
                    var number = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0}", number + 1);
                    break;
                case "real":
                    var numberDob = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", numberDob + 1);
                    break;
                case "text":
                    var word = Console.ReadLine();
                    Console.WriteLine("{0}*", word);
                    break;
                default:
                    break;
            }
        }
    }
}
