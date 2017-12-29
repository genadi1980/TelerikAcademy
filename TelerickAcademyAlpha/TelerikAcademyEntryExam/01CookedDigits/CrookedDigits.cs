namespace _01CookedDigits
{
    using System;

    public class CrookedDigits
    {
        public static void Main()
        {
            string n = Console.ReadLine();
            var sum = 0;
            do
            {
                sum = 0;
                for (int i = 0; i < n.Length; i++)
                {
                    var digitChar = n[i];
                    if (Char.IsDigit(digitChar))
                    {
                        var digitNumber = int.Parse(digitChar.ToString());

                        sum += digitNumber;
                    }

                }

                n = sum.ToString();
                
            }
            while (sum > 9);
            
            Console.WriteLine(n);

        }
    }
}