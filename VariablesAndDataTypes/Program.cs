// See https://aka.ms/new-console-template for more information

//Variable Declarations and Types
string fullName = string.Empty;
int age;
double salary;
char gender = char.MinValue;
bool isWorking;

//Prompt USer for Imput
Console.WriteLine("Please Enter Your Name: ");
fullName = Console.ReadLine();

Console.WriteLine("Please Enter Your Age: ");
age = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Please Enter Your Salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please Enter Your Gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Are You Working (true or false): ");
isWorking = Convert.ToBoolean( Console.ReadLine());

//Print information
Console.WriteLine("Your Name is: " + fullName); //concatenation
Console.WriteLine("Your Age is: {0}",age);
Console.WriteLine($"Your Salary is: {salary}"); //interpolation
Console.WriteLine($"Your Gender is: {gender}"); 
Console.WriteLine($"Are you Emplyed: {isWorking}"); 


