namespace _02Comparearrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Comparearrays
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            uint[] arrayFirst = new uint[n];
            uint[] arraySecond = new uint[n];

            bool isEqual = false;

            for (int i = 0; i < n; i++)
            {
                arrayFirst[i] = uint.Parse(Console.ReadLine());                            
                
            }
            for (int j = 0; j < n; j++)
            {
                
                    arraySecond[j] = uint.Parse(Console.ReadLine());
                
            }

            if (arrayFirst.SequenceEqual(arraySecond))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
          
        }
    }
}
