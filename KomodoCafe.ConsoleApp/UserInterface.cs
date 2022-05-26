using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomodoCafe.Repository;

namespace KomodoCafe.ConsoleApp
{
    public class UserInterface
    {
        KomodoCafeRepository _repo = new KomodoCafeRepository();
        CustomConsole _console = new CustomConsole();

        bool isRunning = true;

        public void Run()
        {
            _repo.SeedMenuData();

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
                    AddItemToMenu();
                    break;
                case "2":
                    PrintMenu();
                    break;
                case "3":
                    DeleteMenuitem();
                    break;
 
            }
        }

        private void AddItemToMenu()
        {
            _console.EnterMealName();
            string mealName = _console.GetUserInput();

            _console.EnterMealDescription();
            string mealDescription = _console.GetUserInput();

            _console.EnterMealNumber();
            int mealNumber = _console.GetUserInputInt();

            _console.EnterMealPrice();
            decimal mealPrice = _console.GetUserInputDecimal();

            _console.EnterMealIngredients();
            string ingredients = _console.GetUserInput();

            KomodoCafeItem newKomodoCafeItem = new KomodoCafeItem(mealName, mealDescription, mealNumber, mealPrice, ingredients);

            _repo.AddItemToMenu(newKomodoCafeItem);
            _console.PressAnyKeyToContinue();
        }

        public void PrintMenu()
        {
            List<KomodoCafeItem> allMenuItems = _repo.GetAllMenuItems();
            _console.PrintMenu(allMenuItems);
            _console.PressAnyKeyToContinue();
        }

        private void DeleteMenuitem()
        {
            List<KomodoCafeItem> _menuItemList = _repo.GetAllMenuItems();
            _console.PrintMenu(_menuItemList);

            _console.EnterItemToDelete();

            string menuItemToDelete = _console.GetUserInput();

        KomodoCafeItem itemToDelete = _repo.GetMenuItemByName
        (menuItemToDelete);

        if(itemToDelete != null)
        {
            bool isSuccess = _repo.DeleteItemFromMenu
            (itemToDelete);

            if(isSuccess)
            {
                _console.MenuItemSuccessfullyDeleted(itemToDelete);
            }

        }
        else
            {

            _console.PressAnyKeyToContinue();
            }   
        }
    }
}