using System;
using System.Globalization;

public class Test
{
    public static void Main()
    {
        string s = Console.ReadLine();
        var date = DateTime.ParseExact(s, "dd-MM-yyyy",CultureInfo.InvariantCulture, DateTimeStyles.None);
        date = date.AddDays(999);
        Console.WriteLine("{0:dd-MM-yyyy}", date); 

    }
}