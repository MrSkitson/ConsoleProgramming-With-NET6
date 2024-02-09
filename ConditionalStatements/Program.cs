﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter Number of  apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Number of oranges: ");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());
// If Statements ( ==, < , >,  >=, <=, !=)
if (numberOfApples > numberOfOranges)
{
    Console.WriteLine("You have more apples");
}
else if(numberOfApples < numberOfOranges)
{
    Console.WriteLine("You have more oranges");
}
else if(numberOfApples == numberOfOranges)
{
    Console.WriteLine("You have the same number of apples and oranges");
}

Console.WriteLine("Enter final grade: ");
int grade = Convert.ToInt32(Console.ReadLine());
// Switch Statements
switch (grade)
{
    case int n when n >= 0 && n <= 59:
        Console.WriteLine("You Failed");
        break;
    case int n when n >= 60 && n <= 99:
        Console.WriteLine("You Passed");
        break;
    case 101:
        Console.WriteLine("Single Case example");
        break;
    default: Console.WriteLine("Invalid Grade");
        break;
}
// Ternary Operators
//var message = numberOfApples > numberOfOranges ? "You have more Apples" : "You have more Oranges";
//Console.WriteLine(message);