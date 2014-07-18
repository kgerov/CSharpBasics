using System;

class PrintCompanyInformation
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Company name: ");
            string CompanyName = Console.ReadLine();
            Console.Write("Company address: ");
            string CompanyAddress = Console.ReadLine();
            Console.Write("PhoneNumber: ");
            string PhoneNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            string FaxNumber = Console.ReadLine();
            Console.Write("Web site: ");
            string WebSite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string FName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string LName = Console.ReadLine();
            Console.Write("Manager age: ");
            string Age = Console.ReadLine();
            Console.Write("Manager phone: ");
            string Phone = Console.ReadLine();

            Console.WriteLine(CompanyName);
            Console.WriteLine("Address: " + CompanyAddress);
            Console.WriteLine("Tel.: " + PhoneNumber);
            Console.WriteLine("Fax: " + FaxNumber);
            Console.WriteLine("Web Site: " + WebSite);
            Console.WriteLine("Manager: {0} {1}, age: {2},tel. {3}", FName, LName, Age, Phone);



            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}