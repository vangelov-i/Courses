using System;

//A company has name, address, phone number, fax number, web
//site and manager. The manager has first name, last name, age
//and a phone number. Write a program that reads the information 
//about a company and its manager and prints it back on the console.
//program	            user
//Company name:     	Software University
//Company address:  	15-18 Tintyava, Sofia
//Phone number:     	+359 899 55 55 92
//Fax number:	
//Web site:         	http://softuni.bg
//Manager first name:	Svetlin
//Manager last name:	Nakov
//Manager age:      	25
//Manager phone:	    +359 2 981 981

//Software University
//Address: 26 V. Kanchev, Sofia
//Tel. +359 899 55 55 92
//Fax: (no fax)
//Web site: http://softuni.bg
//Manager: Svetlin Nakov (age: 25, tel. +359 2 981 981)	


namespace _02PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            //INPUT:
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string comAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            string companyPhone = Console.ReadLine();

            Console.Write("Fax number: ");
            string fax = Console.ReadLine();
            if (fax == "")
            {
                fax = "(no fax)";
            }

            Console.Write("Web site: ");
            string website = Console.ReadLine();
            Console.Write("Manager first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Manager age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Manager phone: ");
            string manPhone = Console.ReadLine();
            
            //OUTPUT:
            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", comAddress);
            Console.WriteLine("Tel. {0}", companyPhone);
            Console.WriteLine("Fax: {0}", fax);
            Console.WriteLine("Web site: {0}", website);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",firstName, lastName, age, manPhone);
        }
    }
}
