using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomodoCafe.Repository
{
    public class KomodoCafe
    {
        // Properties
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public int MealNumber { get; set; }
        public decimal MealPrice { get; set; }
        public string Ingredients { get; set; }

    // Full Constructor
    public KomodoCafe(string mealName, string mealDescription, int mealNumber, decimal mealPrice, string ingredients)
        {
            MealName = mealName;
            MealDescription = mealDescription;
            MealNumber = mealNumber;
            MealPrice = mealPrice;
            Ingredients = ingredients;
        }

        // Empty Constructor 
        public KomodoCafe() {}

    }
}