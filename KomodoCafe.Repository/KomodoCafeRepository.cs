using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomodoCafe.Repository
{
    public class KomodoCafeRepository
    {
        public KomodoCafeRepository() {} //Empty Constructor
        

        List<KomodoCafeItem> _menuDB = new List<KomodoCafeItem>(); //Fake database

        public void AddItemToMenu(KomodoCafeItem menuItem)  //create
        {
            _menuDB.Add(menuItem);
        }

        public List<KomodoCafeItem> GetAllMenuItems()
        {
            return _menuDB;
        }

        public bool DeleteItemFromMenu(KomodoCafeItem x)  //Delete
        {
            int totalItemsInDB = _menuDB.Count();
            _menuDB.Remove(x);
            if(totalItemsInDB == _menuDB.Count())
            {
                return false;
            }
            return true;
        }


        public void SeedMenuData() //seed data method
        {
            KomodoCafeItem coffee = new KomodoCafeItem("Coffee", "hot melted bean water", 1, 4.99m, "water, and coffee beans");
            KomodoCafeItem icedCoffee = new KomodoCafeItem("Iced Coffee", "melted bean water poured over ice", 2, 4.99m, "water, coffee beans, and ice");
            KomodoCafeItem avocadoToast = new KomodoCafeItem("Avocado Toast", "toasted bread coated in fresh avocado", 3, 2.99m, "bread, and avocado");
            KomodoCafeItem muffin = new KomodoCafeItem("Muffin", "a freshly baked corn muffin made from scratch", 4, 2.99m, "egg, flour, butter, milk, salt, cornmeal");
            KomodoCafeItem fruitCup = new KomodoCafeItem("Fruit Cup", "fresh fruit in a cup", 5, 3.99m, "watermelon, strawberries, grapes, apples, honeydew, and blueberries");

            KomodoCafeItem[] menuArr = { coffee, icedCoffee, avocadoToast, muffin, fruitCup };

            foreach (KomodoCafeItem x in menuArr)
            {
                AddItemToMenu(x);
            }
        }
        // public KomodoCafe GetMenuItemByNumber(string menuItemNumber)
        // {
        //     foreach (KomodoCafe x in _menuDB)
        //     {
        //         if(menuItemNumber.ToUpper() == x.ItemNumber.ToUpper())
        //         {
        //             return x;
        //         }
        //     }

        //     return null;
        // }

        // public List<KomodoCafe> GetMenuItemByName(string MealName)
    }
}