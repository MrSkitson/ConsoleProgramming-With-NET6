// See https://aka.ms/new-console-template for more information

// For Loop (Counter Controlled)
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("I'm in a loop");
//    Console.WriteLine($"Counter value : {i}");
//}
//Console.WriteLine();
//Console.WriteLine("For loop finished");

//While Loop (Conditioin Controlled - Pre check)
int n = 0;
while (n < 5)
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Your entered {n}: ");

}
Console.WriteLine();
Console.WriteLine("WHILE LOOP Finished");
//Do While Loop (Conditioin Controlled - Post check)

do
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Your entered {n}: ");

} while (n < 5);
Console.WriteLine();
Console.WriteLine("Do LOOP Finished");
//Foreach (Honourable Mention
//foreach(var item in collection)
//{

//}
