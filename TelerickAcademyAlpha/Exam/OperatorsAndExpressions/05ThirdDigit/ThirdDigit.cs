namespace _05ThirdDigit
{
    using System;
    using System.Linq;

    public static class ThirdDigit
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            var digit = 0;
            var digit3 = 0;
            for (int i = 1; i < 3; i++)
            {
                digit = input / 10;
                digit3 = digit % 10;
                input = digit;
            }


            if (digit3 != 7)
            {
                Console.WriteLine("false {0}", digit3);
            }
            else Console.WriteLine("true");

        }
    }
}