// See https://aka.ms/new-console-template for more information




Person person = new();
string middleName = string.Empty;
Console.WriteLine("Enter Id:");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter First Name:");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter Last Name:");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter Age:");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Salary:");
int salary = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter MiddleName:");
middleName = Console.ReadLine();
if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine("Full name is: " + person.getFullName());
}
else
{
    Console.WriteLine("Full name is: " + person.getFullName(middleName));
}
//int yearOfBirth = Convert.ToInt32(Console.ReadLine());
person.SetSalary(salary);
Console.WriteLine("First name is: " + person.FirstName);
Console.WriteLine("Last name is: " + person.LastName);
//Console.WriteLine("Full name is: " + person.getFullName);
Console.WriteLine("Year of birth is: " + DataUtil.YearofBirth(person.Age));
Console.WriteLine("Salary is: " + person.getSalary());
//Console.WriteLine("YearOfBirth is: " + person.getYearOfBirth());
//DataUtil dataUtil = new DataUtil();
//DataUtil.YearofBirth(person.Age);
