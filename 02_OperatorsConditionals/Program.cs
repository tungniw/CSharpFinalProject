﻿//OPERATORS

//ARITHMETIC OPERATORS

//Addition
int intA = 22;
int intB = 13;

int sum = intA + intB;
sum += 7;

// Console.WriteLine(sum);


//Subtraction
int difference = intA - intB;
difference -= -7;

// Console.WriteLine(difference);



//Multiplication
int product = intA * intB;
product *=2;

// Console.WriteLine(product);


//Division
int quotient = intA / intB;

// Console.WriteLine(quotient); //Outcome is 1 because ints can't have decimal places.


//Modulus - get the remainder thing
int remainder = intA % intB;


//DATES
DateTime today = DateTime.Now;
DateTime someOtherDay = new DateTime(1978, 1, 1);
TimeSpan timeSpan = today - someOtherDay;

// Console.WriteLine(timeSpan);

//COMPARISON OPERATORS

int age = 25;
string userName = "Harry";

bool equals = age == 41; //False
bool isCorrectUserName = userName == "Lloyd"; //False

bool notEqual = age != 30; //True
bool isNotUser = userName != "Darryl";

bool greaterThan = age > 12; //True
bool lessThan = age < 98; //True

bool greaterThanOrEqual = age >= 2345; //False
bool lessThanOrEqual = age <= 1; //False

// || OR
// && AND

bool trueValue = true;
bool falseValue = false;

bool trueAndFalse = trueValue && falseValue; //False
bool trueOrTrue = trueValue || falseValue; //True

int xyz = 10;
int abc = 12;

// if(xyz > 9 && abc < 14);
// {
//     // Console.WriteLine(true);
// }

//CONDITIONALS

// IF STATEMENTS

// bool isHungry = true;

// if (isHungry)
// {
//     Console.WriteLine("eat something.");
// }

// if (isHungry && age >= 21)
// {
//     Console.WriteLine("eat something.");
// }

// If Else Statement

// bool tpsReportsAreFinished = true;

// if(tpsReportsAreFinished)
// {
//     Console.WriteLine("You don't have to work on Saturday.");
// }
// else{
//     Console.WriteLine("We're gonna need you to come in on Saturday.");
// }

// ELSE IF

// bool tpsReportsAreFinished = true;

// if(tpsReportsAreFinished)
// {
//     Console.WriteLine("You don't have to work on Saturday.");
// }

//     else if (age >= 21)
// {
//     Console.WriteLine("You don't have to work on Saturday. Have fun on St. Paddys.");
// }
// else
// {
//     Console.WriteLine("We're gonna need you to come in on Saturday.");
// }

// tpsReportsAreFinished = false;

// bool bossDoesntCare = true;

// if(tpsReportsAreFinished)
// {
//     Console.WriteLine("You don't have to come in.");
// }
// else
// {
//     if (bossDoesntCare)
//     {
//         Console.WriteLine("You don't have to come in.");
//     }
//     else{
//         Console.WriteLine("You gotta work on Saturday.");
//     }
// }

// SWITCH CASES

// int input = 1;

// switch (input)
// {
//     case 1:
//     Console.WriteLine("it's a one.");
//     break;
//     case 2:
//     Console.WriteLine("it's a two.");
//     break;
//     case 3:
//     Console.WriteLine("it's a three");
//     break;
//     default:
//     Console.WriteLine("I dunno"); // the default is the catch-all.
//     break;
// }

//TERNARIES

// BOOL VARIABLE = CONDITIONAL ? OUTPUT_IF_TRUE : OUTPUT_IF_FALSE ;

age = 35;

bool canDrinkAlcohol = (age >= 21) ? true : false;

string reaction = (age >= 21) ? "hooray" : "bummer";