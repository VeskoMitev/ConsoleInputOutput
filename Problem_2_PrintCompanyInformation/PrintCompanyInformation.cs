namespace ConsoleInputOutput
{
    using System;
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter company name:");
            string companyName = Console.ReadLine();
            if (companyName == "") companyName = "(no company name)";

            Console.Write("Enter company address:");
            string companyAddress  =  Console.ReadLine();
            if (companyAddress == "") companyAddress = "(no address)";

            Console.Write("Enter phone number:");
            string phoneNumber = Console.ReadLine();
            if (phoneNumber == "") phoneNumber = "(no phone)";

            Console.Write("Enter fax number:");
            string faxNumber = Console.ReadLine();
            if (faxNumber == "") faxNumber = "(no fax)";

            Console.Write("Enter Web site:");
            string companyWebSite = Console.ReadLine();
            if (companyWebSite == "") companyWebSite = "(no web site)";

            Console.Write("Manager first name:");
            string managerFirstName = Console.ReadLine();
            if (managerFirstName == "") managerFirstName = "(no manager first name)";

            Console.Write("Manager last name:");
            string managerLastName = Console.ReadLine();
            if (managerLastName == "") managerLastName = "(no manager last name)";

            Console.Write("Manager age:");
            int managerAge = int.Parse( Console.ReadLine());
            

            Console.Write("Manager phone:");
            string managerPhone = Console.ReadLine();
            if (managerPhone == "") managerPhone = "(no phone manager)";


            Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})",
                companyName,companyAddress,phoneNumber,faxNumber,companyWebSite,managerFirstName,managerLastName, managerAge ,managerPhone );

        }
    }
}
