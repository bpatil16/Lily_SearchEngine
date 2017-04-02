using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("******************* Welcome to Job search Engine ! ******************");
            Console.WriteLine("Please select from the following options");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create an Account");
            Console.WriteLine("2. AddResune");
            Console.WriteLine("3. PostJob");

            var option = Console.ReadLine();

            switch (option)
            {
                case "0":
                    Console.WriteLine("\n Thank you!");
                    break;
                case "1":
                    Console.Write("\nPlease provide email address: ");
                    var emailAddress = Console.ReadLine();
                    Console.Write("\n What Type of Account: ");
                    var typeOfAccount = Console.ReadLine();
                    var account1 = Engine.CreateAccount(emailAddress, AccountType.Jobseeker);
                    Console.WriteLine($"AccountNumber: {account1.AccountNumber}, TypeOfAccount: {account1.TypeOfAccount}");
                    break;
                case "2":
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
