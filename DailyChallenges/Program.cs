﻿using DailyChallenges;    

ChallengeRepository _tomato = new ChallengeRepository();       




//Create a method with access modifier public and datatype string, create a parameter with a datatype of char in ChallengeRepository.cs called RandomChoice(char x)
// Create a private void method called PrintMainMenu() in Program.cs that will print to console "What do you choose? /n A. /n B. /n C."
//Create another method called GetInputFromUser() in Program.cs that will get input from user, returning a Console.ReadLine(); and convert .toUpper
// Save user input from Console.Readline(); into char userInput variable
//pass a switch case through RandomChoice(char x) with case 'A' returning "alligator", case 'B' returning "biscuit", case 'C' returning "chihuahua", and default returning "spaghetti"
// Initialize the RandomChoice(char x) in in Program.cs by passing userInput through it and printing the result to console

// Write a method that asks the user to choose between either A,B, or C. Based off of their choice print "alligator", "biscuit", or "chihuahua" to the console. If they don't choose A, B, or C print "spaghetti" to the console.

char input = ' ';
char animal = _tomato.PrintMainMenu(input);





       
       
        // string teamOne = "Tigers";
//         string teamTwo = "Dolphins";

//         int teamOneScore = 3;
//         int teamTwoScore = 1;
// _tomato.whoWon(teamOne, teamTwo, teamOneScore, teamTwoScore);
// Console.WriteLine(_tomato.whoWon(teamOne, teamTwo, teamOneScore, teamTwoScore));


// NEW CHALLENGE

// Try to do this challenge this weekend in DailyChallenges/ChallengeRepository if you have time. We'll go over the solution on Tuesday.

// Write a method that takes in a parameter of type string and returns the string in sponge bob casing.

// string input = "I know you are, but what am I?";

// string convertedString = ConvertToSpongeBobCasing(input);

// Console.WriteLine(convertedString);

// CONSOLE OUTPUT : i kNoW YoU ArE, bUt wHaT Am i?





// string input = "I know you are, but what am I?";
// string output = _tomato.SpongebobCase(input);
// Console.WriteLine(output);



// int GrandTotal = _tomato.TotalSum();


// List<float> listOfFloats = new List<float>(1f, 2f, 3f, 4f, 5f);
// List<float> kmlist = _tomato.KilometerConverter(listofFloats);

// foreach (float x in kmlist)
// {
//         Console.WriteLine(x);
// }





// ChallengeRepository _cr = new ChallengeRepository(); (links our program to the repository)
// Create a list of floats that we will be later passing through our Method using a List<float>
// Create the method with access modifier of public and datatype as float, create its parameter with a datatype of float
// Create a new, empty list variable in the body of the method with type float.
// ^ This will capture the floats that will be returned
// We need to figure out the conversion of m to km, which is: distance in km = x miles * 1.609344
// Use a foreach loop that iterates through every item in the list
// Any figures that are under 0.5m/0.8km threshold are not included in the return
// Use a boolean to return measurements > 0.5m/0.8km if true, and do not return them if they are under the threshold
// Within the conditional, convert the values we kept and return those new values in km to the new list instantiated within the method
// Use List Variable += Measurement to add, to add the correct measurement to our list every time the condition is met.
// Pass the list through the method and print to the console



