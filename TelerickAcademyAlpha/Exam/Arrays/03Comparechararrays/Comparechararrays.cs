namespace _03Comparechararrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Comparechararrays
    {
        static void Main()
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            char[] firstArr = firstString.ToCharArray();
            char[] secondArr = secondString.ToCharArray();

           
            if (firstArr.Length > secondArr.Length)
            {
                Console.WriteLine(">");
            }
            else if (firstArr.Length < secondArr.Length)
            {
                Console.WriteLine("<");
            }
            else if (firstArr.Length == secondArr.Length)
            {
                bool isEqual = false;
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (firstArr[i] > secondArr[i])
                    {
                        isEqual = ;
                    }
                    else if (firstArr[i] < secondArr[i])
                    {
                        Console.WriteLine("<");
                    }
                    else
                    {
                        Console.WriteLine("=");
                    }
                }
                
            }
        }
    }
}
