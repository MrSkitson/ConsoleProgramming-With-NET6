// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

string firstName = "Alexandr";
string lastName = "Pigulewski";
DateTime date = DateTime.Now;

//Print to screen
Console.WriteLine(firstName);
Console.WriteLine(lastName);

//Concatenation
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("My full name is " + lastName + " " + firstName);
Console.WriteLine($"My full name is {lastName} {firstName}");
Console.WriteLine("My full name is {0} {1}", lastName, firstName);

//String Length
int length = firstName.Length;
Console.WriteLine($"Your name is {length} letters long");

// Replace string parts
string newName = firstName.Replace('A', 'K');
Console.WriteLine($"Your newq name is {newName}");

string newName1 = firstName.Replace('l', ' ');
Console.WriteLine($"Your new name is {newName1}");

//Append to other string variable
string fullName = firstName + " " + lastName;
Console.WriteLine($"Your full name is {fullName}");

//Split String
string[] splitName = fullName.Split('i');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]); 
}

string nullString = null;
string emptyString = "";
string whiteSapceString = " ";

//Compare String
if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("String is null");
}
if (firstName == lastName)
{
    Console.WriteLine("Names are equal");
}
if (firstName != lastName)
{
    Console.WriteLine("Names are not  equal");
}
int comparisonResult = string.Compare(firstName, lastName);
if (comparisonResult == 0)
{
    Console.WriteLine("Names are equal");
}
else
{
    Console.WriteLine("Names are not  equal");
}
//Convert string

string convertedString = string.Empty;
int number = 1234567679;
convertedString = number.ToString();
Console.WriteLine($"Conerted string is {convertedString}");