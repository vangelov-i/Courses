using System;
using System.Text;


namespace P2PrintCompanyInfo
{
    class P2CompanyInfo
    {
        static void Main()
        {
            string companyName;
            string companyAddress;
            long phoneNumber;
            long faxNumber;
            string webSite;
            string manFirstName;
            string manLastName;
            byte manAge;
            long manPhone;
            Console.Write("Company name: ");
            companyName = Console.ReadLine();
            Console.Write("Company address: ");
            companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            phoneNumber = long.Parse(Console.ReadLine());
            Console.Write("Fax number: ");
            long.TryParse(Console.ReadLine(), out faxNumber);
            Console.Write("Web site: ");
            webSite = Console.ReadLine();
            Console.Write("Manager first name: ");
            manFirstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            manLastName = Console.ReadLine();
            Console.Write("Manager age: ");
            if (byte.TryParse(Console.ReadLine(), out manAge)) ;
            else
            {
                Console.WriteLine("Invalid input! Try again.");
            }
            Console.Write("Manager phone: ");
            manPhone = long.Parse(Console.ReadLine());

            Console.WriteLine("{0}\nAddress: {1}\nTel. +{2}\nFax: {3} \nWeb site: {4}\nManager: {5} {6} (age:{7}, tel. +{}", companyName, companyAddress, phoneNumber, faxNumber, webSite, manFirstName, manLastName, manAge, manPhone);
        }
    }
}
