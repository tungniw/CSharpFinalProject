using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalShelter.Repository;

namespace AnimalShelter.ConsoleApp
{
    public class UserInterface
    {
        // Fields

        // Bool isRunning for our WHILE LOOP
        private bool isRunning = true;

        // New up instance of REPO class stored in a variable
        private AnimalRepository _repo = new AnimalRepository();

        // Methods

        // Run
        public void Run()
        {
            _repo.SeedAnimalData();

            while (isRunning)
            {
                PrintMainMenu();

                string input = GetUserInput();

                // UserInputSwitchCase(input);
            }
        }

        // PrintMainMenu
        private void PrintMainMenu()
        {
            Console.WriteLine("Hello World.");
        }

        // GetUserInput

        private string GetUserInput()
        {
            return Console.ReadLine();
        }

        // CRUD Methods in the context of the UserInterface.
    }
}