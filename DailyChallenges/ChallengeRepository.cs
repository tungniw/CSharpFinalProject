using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyChallenges
{

    public class ChallengeRepository
    {

    string Rock ="ROCK";
    string Paper ="PAPER";
    string Scissors ="SCISSORS";
    public void RockPaperScissors(string player1Choice, string player2Choice)
    {
        string x = player1Choice.ToUpper();
        string y = player2Choice.ToUpper();

        if (x == Rock && y == Scissors)
        {
            Console.WriteLine("Player 1 wins");
        }
        else if (x == Rock && y == Paper)
        {
            Console.WriteLine("Player 2 wins");
        }
        else if (x == Rock && y == Rock)
        {
            Console.WriteLine("Draw");
        }
        else if (x == Scissors && y == Rock)
        {
            Console.WriteLine("Player 2 wins");
        }
        else if (x == Scissors && y == Paper)
        {
            Console.WriteLine("Player 1 wins");
        }
        else if (x == Scissors && y == Scissors)
        {
            Console.WriteLine("Draw");
        }
        else if (x == Paper && y == Rock)
        {
                Console.WriteLine("Player 1 wins");
        }
        else if (x == Paper && y == Scissors)
        {
            Console.WriteLine("Player 2 wins");
        }
        else if (x == Paper && y == Paper)
        {
            Console.WriteLine("Draw");
        }
    }

        // method 5 (write another average() method that takes parameters of (int[] intArr, int max, int min) where max and min are thresholds for outliers - we don't want the outliers included in our average.)
        public decimal Average(int[] intArr, int max, int min)
        {
            decimal sum = 0;
            decimal arrayLength = 0;
            
            foreach (int x in intArr)
            {
                if (x <= max && x >= min)
                {
                    sum += x;
                    arrayLength ++;
                }
            }
            return sum / arrayLength;
        }

        // method 2 (write a method that returns the average of an array of ints. The array of ints must be passed in as a parameter.)(look up casting)
        public decimal Average(int[] intArr)
        {
            decimal sum = Sum(intArr);
            decimal arrayLength = intArr.Length;

            decimal average = (decimal)(sum / arrayLength);

            return average;
        }

        //string x = Average();                                 // INTENTIONAL MISTAKE BY TREVOR
        

        // method 1
        public int Sum(int[] intArr)
        {
            int sum = 0;

            foreach (int x in intArr)
            {
                sum += x;
            }
            return sum;
        }

        public char PrintMainMenu(char x)
{
    
     Console.WriteLine("What do you choose? \n A: \n B: \n C:");
     char input = Char.ToLower(Console.ReadKey().KeyChar);
    switch (input)
    {
    case 'a': 
    Console.WriteLine("\n Alligator");
    return input;
    case 'b':
    Console.WriteLine("\n Biscuit");
    return input;
    case 'c':
    Console.WriteLine("\n Chihuahua");
    return input;
    default:
    Console.WriteLine("\n Spaghetti");
    return input;
    }
}

    //     public List<float> KilometerConverter(List<float> input)
    //     {
    //         List<float> emptyList = new List<float>();


    //         foreach (float x in input)
    //         {
    //             if (x > .497f)
    //             {
    //                 emptyList.Add(x * 1.609344f);
    //             } 
    //             else
    //             {
    //                 y * 1.609344f;
    //             }
    //             return emptyFloats;
    //         }
    //     }     

    //     // public int TotalSum()

    //     public string whoWon(string teamOne, string teamTwo, int teamOneScore, int teamTwoScore)
    //     {

    //     if(teamOneScore == teamTwoScore)
    //     {
    //         return $"{teamOne} and {teamTwo} tie!";
    //     }
    //     else if(teamOneScore > teamTwoScore)
    //     {
    //         return $"{teamOne} wins!";
    //     }
    //     else 
    //     {
    //        return $"{teamTwo} wins!";
    //     }

    // }
    // public string SpongebobCase(string input)
    // {
    //     string output = "";

    //     foreach (char x in input)
    //     {
    //         if (input.IndexOf(x) % 2 == 0)
    //         {
    //         output += char.ToUpper(x);
    //         } else {
    //         output +=  char.ToLower(x);
    //         }
    //     }
        
    //     return output;
    // }
    
        // string teamOne = "Tigers";
        // string teamTwo = "Dolphins";

        // int teamOneScore = 3;
        // int teamTwoScore = 1;

        // if (teamOneScore > teamTwoScore) 
        // {
        //     Console.WriteLine("Tigers win!"); 
        // } 
        // else if (teamTwoScore > teamOneScore)
        // {
        //     Console.WriteLine("Dolphins win!")
        // } 
        // else 
        // {
        //     Console.WriteLine("It's a tie!")
        // }
        //01
        //Write a method that each complete the following tasks:

        //Take in FOUR parameters: 2 strings and 2 ints. The strings being the names of two different soccer teams, and the ints being the teams' scores.

        //Method should return a string of either "{teamOne} won." or "{teamTwo} won." or "{teamOne} and {teamTwo} tied".

        //Invoke each method in Program.cs and print the returned results to the console.





    }
}

// ROCK-PAPER-SCISSORS CHALLENGE
// Write a method that takes in two parameters of type string. The two strings will represent a choice of "rock", "paper", or "scissors" from PlayerONE and PlayerTWO. Print out which player wins or if they tied. Your method should be able to handle weird capitalization of "RoCk", "pAPeR", "scIssOrS".
// string x = Rock;
// string y = Scissors;
// string z = Paper;

//     Rock > Scissors
//     Scissors > Paper
//     Paper > Rock



// HANGMAN CHALLENGE
// Write a method that takes a parameter of type string, and prints out _underscores_ and spaces for representing the string in a game of hangman.
// Example:
// "I love coding" would print "_   _ _ _ _   _ _ _ _ _ _"


// WORD-SCRAMBLE CHALLENGE
// Write a method that takes in a parameter of type string and returns the same word scrambled up.
// Example:
// "sharks" would return "rhssak", or something like that.






// 1. McDonald's hires you to create their new menu app. Create a Class object for a McDonald's value meal.
// 2. Write a method that takes in your birthday and returns how many days you have been alive.
// 3. Write a method that takes in a list of integers, and then returns a dictionary with three key/value pairs that represent the mean, median, and mode. You can write multiple methods to help out.




// public string ValueMealItem { get; set; }
// public decimal ItemCost { get; set; }
// public int CalorieCount { get; set; }


