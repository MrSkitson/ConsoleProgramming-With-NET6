// See https://aka.ms/new-console-template for more information

//Empty DateTime
using System.Globalization;

DateTime date = new DateTime();

//Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1991, 09, 20);
Console.WriteLine("My Dob is: " + dateOfBirth);
Console.WriteLine("My Dob is: " + dateOfBirth.Date);

Console.WriteLine("Day of Week{0}: ", dateOfBirth.DayOfWeek);
Console.WriteLine("Day of Year{0}: ", dateOfBirth.DayOfYear);
Console.WriteLine("Time of Year{0}: ", dateOfBirth.TimeOfDay);
Console.WriteLine("Tick:{0}", dateOfBirth.Ticks);
Console.WriteLine("Kind:{0}", dateOfBirth.Kind);


//Create a DateTime from current timesetup
DateTime now = DateTime.Now;
Console.WriteLine("the Time is: " + now);

//Create a DateTime from a String
DateTime dateFromString = DateTime.Parse("08/02/2024", CultureInfo.InvariantCulture);
Console.WriteLine("the date from string is: " + dateFromString);
//Add Additional Time

Console.WriteLine("One hour from now is: " + now.AddHours(1));
Console.WriteLine("One day from now is: " + now.AddDays(1));
// Ticks from DateTime 

Console.WriteLine("Time as a numeral:" + now.Ticks);
//Date Only
DateOnly dateOnluofBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine("Date only :" + dateOfBirth.Date);
//TimeOnly Only
TimeOnly timeOnly = TimeOnly.FromDateTime(now);
Console.WriteLine("Time only :" + timeOnly);

