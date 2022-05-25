using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomodoCafe.Repository
{
    public class KomodoCafeRepository
    {
        public KomodoCafeRepository() {}

        List<KomodoCafe> _menuDB = new List<KomodoCafe>();

        public void AddItemToMenu(KomodoCafe menuItem)
        {
            _menuDB.Add(menuItem);
        }

        public List<KomodoCafe> GetAllMenuItems()
        {
            return _menuDB;
        }

        public KomodoCafe GetMenuItemByNumber(int menuItemNumber)
        {
            foreach (KomodoCafe x in _menuDB)
            {
                if(menuItemNumber.ToUpper() == x.ItemNumber.ToUpper())
                {
                    return x;
                }
            }

            return null;
        }

        // public List<KomodoCafe> GetMenuItemByName(string MealName)
    }
}