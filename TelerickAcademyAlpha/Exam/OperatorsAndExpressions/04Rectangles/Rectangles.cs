namespace _04Rectangles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Rectangles
    {
        public static void Main()
        {
            double inputWidth = double.Parse(Console.ReadLine());
            double inputHeight = double.Parse(Console.ReadLine());

            double areaRectangle = inputWidth * inputHeight;
            double perimeterRectangle = 2*(inputWidth + inputHeight);

            Console.WriteLine("{0:f2} {1:f2}", areaRectangle, perimeterRectangle);
        }
    }
}
