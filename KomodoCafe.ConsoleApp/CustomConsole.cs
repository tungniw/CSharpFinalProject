using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomodoCafe.Repository;

namespace KomodoCafe.ConsoleApp
{
    public class CustomConsole
    {
        public void PrintMainMenu()
        {
            Console.WriteLine("1. Create new menu item.\n" +
                                "2. View all menu items.\n" +
                                "3. Delete a menu item\n" +
                                "4. Exit\n");
        }

        public void PrintMenuItem(KomodoCafeItem x)
        {
            Console.WriteLine($"Menu Item: {x.MealName}\n" +
                            $"Description: {x.MealDescription}\n" +
                            $"Number: {x.MealNumber}\n" +
                            $"Meal Price: {x.MealPrice}\n" +
                            $"Ingredients: {x.Ingredients}\n");
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
            Console.Write("Enter menu item to delete: ");
        }

        public void MenuItemSuccessfullyDeleted(KomodoCafeItem x)
        {
            Console.WriteLine($"{x.MealName} Successfully deleted");
        }

        public void PrintMenu(List<KomodoCafeItem> MenuItems)
        {
            foreach(KomodoCafeItem MenuItem in MenuItems)
            {
                PrintMenuItem(MenuItem);
            }
        }

        public void PressAnyKeyToContinue()
        {
            Console.Write("Press any key to continue....");
            Console.ReadKey();
        }

        public void EnterMealName() 
        {
            Console.WriteLine("Enter a Meal Name: ");
        }

        public void EnterMealDescription()
        {
            Console.WriteLine("Enter a Meal Description: ");
        }

        public void EnterMealNumber()
        {
            Console.WriteLine("Enter a Meal Number: ");
        }

        public void EnterMealPrice()
        {
            Console.WriteLine("Enter a Meal Price: ");
        }

        public void EnterMealIngredients()
        {
            Console.WriteLine("Enter a Meals Ingredients: ");
        }


    }
}