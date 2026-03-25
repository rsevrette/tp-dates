namespace TP_manipulation_dates;

class Program
{
    static void Main(string[] args)
    {
        //Partie 1
        Console.WriteLine("\n_______________Partie 1_______________");
        DateTime dateActuelle = DateTime.Now;

        Console.WriteLine(dateActuelle);
        Console.WriteLine(dateActuelle.ToString("dd/MM/yyyy"));

        //Partie 2
        Console.WriteLine("\n_______________Partie 2_______________");
        DateTime date1janvier = new DateTime(2025, 1, 1);
        Console.WriteLine(date1janvier);
        Console.WriteLine(date1janvier.ToString("dd/MM/yyyy"));

        Console.WriteLine("\n_______________Partie 3_______________");
        Console.WriteLine(date1janvier.ToShortDateString());
        Console.WriteLine(date1janvier.ToLongDateString());
        Console.WriteLine(date1janvier.ToString("dd/MM/yyyy"));
        Console.WriteLine(date1janvier.ToString("yyyy-MM-dd"));

        Console.WriteLine("\n_______________Partie 4_______________");
        DateTime date1 = date1janvier.AddDays(10);
        Console.WriteLine(date1.ToLongDateString());

        DateTime date2 = date1janvier.AddMonths(2);
        Console.WriteLine(date2.ToLongDateString());

        DateTime date3 = date1janvier.AddYears(1);
        Console.WriteLine(date3.ToLongDateString());

        Console.WriteLine("\n_______________Partie 5_______________");
        DateTime date4 = date1janvier.AddDays(-5);
        Console.WriteLine(date4.ToLongDateString());

        DateTime date5 = date1janvier.AddMonths(-1);
        Console.WriteLine(date5.ToLongDateString());

    }
}
