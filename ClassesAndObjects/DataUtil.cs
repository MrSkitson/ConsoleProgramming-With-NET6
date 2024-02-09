
internal static class DataUtil
{
    
    public static int YearofBirth(int age)
    {
        return DateTime.Now.Year - age;
    }
    public static int YearofBirth(DateTime dateofBirth)
    {
        if(dateofBirth == null)
            return 0;
        return dateofBirth.Year;
    }
    public static int Age(DateTime dateofBirth)
    {
        if (dateofBirth == null)
            return 0;
        return DateTime.Now.Year - dateofBirth.Year;
    }
}

