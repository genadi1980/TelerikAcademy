namespace _02BonusScore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BonusScore
    {
        static void Main()
        {
            int score = int.Parse(Console.ReadLine());
            int bounsSc = 0;
            bool inRange = false;

            if (score >= 1 && score <= 3) 
            {
                bounsSc = score * 10;
                inRange = true;
            }
            else if (score >= 4 && score <= 6)
            {
                bounsSc = score * 100;
                inRange = true;
            }
            else if (score >= 7 && score <= 9)
            {
                bounsSc = score * 1000;
                inRange = true;
            }
            else
            {
                Console.WriteLine("invalid score");
            }

            if (inRange)
            {
                Console.WriteLine("{0}", bounsSc);
            }
        }
    }
}
