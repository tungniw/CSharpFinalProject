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
            }
        }
    }
}