using System;

class Program
{
    static void Main()
    {
        Console.Write("hur många hela minuter finns det i låten ");
        int minutes = int.Parse(Console.ReadLine());

        Console.Write("skriv nu hur många sekunder som finns som inte är del av någon hel minut ");
        int seconds = int.Parse(Console.ReadLine());

        int totalSeconds = (minutes * 60) + seconds;

        if (totalSeconds >= 2 * 60 + 45 && totalSeconds <= 4 * 60 + 20)
        {
            Console.WriteLine("Låten får spelas på radiostationen.");
        }
        else
        {
            Console.WriteLine("Låten får inte spelas på radiostationen.");
        }
    }
}
