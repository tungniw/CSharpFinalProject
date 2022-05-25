using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Repository
{
    public class Animal
    {
        // Properties
        public string AnimalName { get; set; }
        public DietType TypeOfDiet { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }


        // Constructors

        // Full Constructor
        public Animal(string animalName, DietType typeOfDiet, int age, string species)
        {
            AnimalName = animalName;
            TypeOfDiet = typeOfDiet;
            Age = age;
            Species = species;


        }

        // Empty Constructor 
        public Animal() {}


    }
    // ENUMS - enums go in the namespace level - not in the class.\
    public enum DietType {Herbivore, Omnivore, Carnivore};
}