using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Nsikak Eyo's Scripture Memorizer!");
        Console.WriteLine("Press Enter to start memorizing or type 'quit' anytime to exit.\n");

        // A small library of scriptures for creativity
        List<Scripture> library = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son, " +
                "that whoever believes in him shall not perish but have eternal life."),

            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding; " +
                "in all your ways submit to him, and he will make your paths straight."),

            new Scripture(new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me.")
        };

        // Randomly select a scripture
        Random random = new Random();
        Scripture selectedScripture = library[random.Next(library.Count)];

        while (true)
        {
            Console.Clear();
            selectedScripture.Display();
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");

            string input = Console.ReadLine()?.Trim().ToLower();
            if (input == "quit")
            {
                Console.WriteLine("Goodbye! Keep memorizing and stay inspired.");
                break;
            }

            selectedScripture.HideRandomWords(3); // Hide 3 random words each round

            if (selectedScripture.IsCompletelyHidden())
            {
                Console.Clear();
                selectedScripture.Display();
                Console.WriteLine("\n🎉 Congratulations! You've successfully memorized the scripture!");
                break;
            }
        }
    }
}
