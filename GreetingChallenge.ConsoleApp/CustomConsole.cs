using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreetingChallenge.Repository;

namespace GreetingChallenge.ConsoleApp
{
    public class CustomConsole
    {
        public void PrintMainMenu()
        {
            Console.WriteLine("1. Add client.\n" +
                                    "2. View current clients.\n" +
                                    "3. Delete client.\n" +
                                    "4. Exit.\n");
        }

        public void PrintClientList(GreetingChallenge100 x)
        {
            Console.WriteLine($"Customer Name: {x.CustomerName}\n" +
                                $"Client Status: {x.TypeOfClient}\n");
        }

        public string GetUserInput()
        {
            return Console.ReadLine();
        }

        public int GetUserInputInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public void EnterItemToDelete()
        {
            Console.WriteLine("Enter customer to delete: ");
        }

        public void CustomerSuccessfullyDeleted(GreetingChallenge100 x)
        {
            Console.WriteLine($"{x.CustomerName} Successfully deleted");
        }

        public void PrintClientList(List<GreetingChallenge100> Customers)
        {
            foreach(GreetingChallenge100 Customer in Customers)
            {
                PrintClientList(Customers);
            }
        }

        public void PressAnyKeyToContinue()
        {
            Console.Write("Press any key to continue......");
            Console.ReadKey();
        }

        public void EnterCustomerName()
        {
            Console.WriteLine("Enter customers name: ");
        }

        public void EnterCustomerType()
        {
            Console.WriteLine("What is the customers status with the company: ");
        }

        internal void ShowAllCustomers(List<GreetingChallenge100> allCustomers)
        {
            throw new NotImplementedException();
        }

        public interface UserInterface
        {
            void ShowAllCustomers();
        }

        // internal void PrintClientList(List<GreetingChallenge100> customerDB)
        // {
        //     throw new NotImplementedException();
        // }

        // internal void CustomerSuccessfullyDeleted(GreetingChallenge100 itemToDelete) => throw new NotImplementedException();
    }
}