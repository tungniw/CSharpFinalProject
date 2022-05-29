using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreetingChallenge.Repository;


namespace GreetingChallenge.ConsoleApp
{
    public class UserInterface
    {
        GreetingChallenge100 _repo = new GreetingChallenge100();

        CustomConsole _console = new CustomConsole();

        bool isRunning = true;

        public void Run()
        {
            _repo.SeedCustomerData();

            while (isRunning)
            {
                _console.PrintMainMenu();
                string userInput = _console.GetUserInput();

                UserInputPortal(userInput);
            }

        }

        private void UserInputPortal(string inputFromUser)
        {
            switch (inputFromUser)
            {
                case "1":
                    AddNewCustomer();
                    break;
                case "2":
                    ShowAllCustomers();
                    break;
                case "3":
                    DeleteCustomer();
                    break;

            }

        }

        private void AddNewCustomer()
        {
            _console.EnterCustomerName();
            string customerName = _console.GetUserInput();

            _console.EnterCustomerType();
            string customerType = _console.GetUserInput();
            ClientType? typeofClient = CustomerType(customerType);

            GreetingChallenge100 newGreetingChallengeUno = new GreetingChallenge100(customerName, typeofClient);

            _repo.AddNewCustomer(newGreetingChallengeUno);
            _console.PressAnyKeyToContinue();

        }

        public void ShowAllCustomers()
        {
            List<GreetingChallenge100> allCustomers = _repo.PrintClientList();
            _console.ShowAllCustomers(allCustomers);
            _console.PressAnyKeyToContinue();
        }

        private void DeleteCustomer()
        {
            List<GreetingChallenge100> _customerDB = _repo.ShowAllCustomers();
            _console.PrintClientList(_customerDB);

            _console.EnterItemToDelete();

            string customerToDelete = _console.GetUserInput();

        GreetingChallenge100 itemToDelete = _repo.GetCustomerByName
        (customerToDelete);

        if(itemToDelete != null)
        {
                bool isSuccess = _repo.DeleteCustomer
                (itemToDelete);

                if(isSuccess)
                {
                    _console.CustomerSuccessfullyDeleted(itemToDelete);
                }
            }
            else 
            {
                _console.PressAnyKeyToContinue();
            }

        }

        private ClientType? CustomerType(string customerType)
        {
            switch (customerType)
            {
                case "1":
                    return ClientType.Potential;
                case "2":
                    return ClientType.Current;
                case "3":
                    return ClientType.Past;
                default:
                    return null;
            }
        }

    }
}