using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MoonGravity
{
    public static void Main()
    {
        var weight = double.Parse(Console.ReadLine());
        var moonWeight = 17 * weight / 100;

        Console.WriteLine("{0:F3}", moonWeight);
    }
}

