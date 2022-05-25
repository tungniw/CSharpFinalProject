﻿using MoldyPotatoes.ConsoleApp;

ICustomConsole console;

Console.WriteLine("Choose a Language:\n" + 
                                        "1. English\n" + 
                                        "2. Spanish\n");
string input = Console.ReadLine();
switch(input)
{
    case "1":
        console = new CustomConsole();
        break;
    // case "2":
    //     console = new CustomConsole();
    //     break;
    default:
        console = new CustomConsole();
        break;
}

UserInterface _ui = new UserInterface(console);

_ui.Run();

// Dependency injection
// Interfaces 
