﻿// See https://aka.ms/new-console-template for more information

// Decalre a List
List<string> names = new List<string>();
string name = string.Empty;
// Add values to list
names.Add("Alex");


Console.WriteLine("Enter Names:");
while (name != "-1")
{
    Console.Write("Enter Name:");
    name = Console.ReadLine();
    if(string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
     
        names.Add(name);
        Console.Write($"{name} was inserted successfully");
    }
   
}

// Print values in list
Console.WriteLine("Printing names via for loop");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("Printing names via foreach loop");
foreach (string item in names)
{
    Console.WriteLine(item);
}
