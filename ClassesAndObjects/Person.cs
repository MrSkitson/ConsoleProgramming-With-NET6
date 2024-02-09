// See https://aka.ms/new-console-template for more information


// primitive datatypes

// OOP - Creating my own datatype
// class - blueprint
// Single Responsibility Principle 



public class Person
{
    // Properies when public
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    // Fields
    private double _salary { get; set; }
    private double yearOfBirth { get; set; }

    public void SetSalary(double salary)
    {
        _salary = salary;
    }

    public double  getSalary()
    {
        return _salary;
    }

    public string getFullName()
    {
        return $"{FirstName} {LastName}";
    }
    public string getFullName(string middleName)
    {
        return $"{FirstName} {middleName} {LastName}";
    }
    public double getYearOfBirth()
    {
        return yearOfBirth;
    }
}
