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
        
    }
}
