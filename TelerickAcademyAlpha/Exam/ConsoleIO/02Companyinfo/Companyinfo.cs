namespace _02Companyinfo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Companyinfo
    {
        public static void Main()
        {
            var companyName = Console.ReadLine();
            var companyAddress = Console.ReadLine();
            var phoneNumber = Console.ReadLine();
            var faxNumber = Console.ReadLine();
            var webSite = Console.ReadLine();
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var manPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}",companyAddress);
            Console.WriteLine("Tel. {0}",phoneNumber);
            if (faxNumber == string.Empty)
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: {0}", faxNumber);
            }
            Console.WriteLine("Web site: {0}",webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",firstName,lastName,age,manPhone);
            

        }
    }
}
