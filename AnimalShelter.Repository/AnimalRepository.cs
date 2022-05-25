using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Repository
{
    public class AnimalRepository
    {
        // Fake Database
        private List<Animal> _animalListDB = new List<Animal>();


        // CRUD methods

        // Create

        // CreateAnimal
        public void AddAnimalToDatabase(Animal animal)
        {
            _animalListDB.Add(animal);
        }

        // Read

        // GetAllAnimals

        // GetAnimal

        // Update

        // UpdateAnimal

        // Delete

        // DeleteAnimal

        // Seed Data
        public void SeedAnimalData()
        {
            Animal tucker = new Animal("Tucker", DietType.Carnivore, 1, "Dog");
            Animal zelda = new Animal("Zelda", DietType.Carnivore, 3, "Cat");
            Animal finn = new Animal("Finn", DietType.Carnivore, 1, "Praying Mantis");

            Animal[] animalArr = { tucker, zelda, finn };

            foreach (Animal x in animalArr)
            {
                AddAnimalToDatabase(x);
            }
        }
    }
}