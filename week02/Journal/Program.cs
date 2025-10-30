// Program.cs
// CSE210 W02 - Journal Program
// Author: Nsikak Eyo
// Course: CSE210 - Programming with Classes
// Date: (add submission date)
// 
// Creativity / Exceeded Requirements (for grader):
// 1) Mood Tracker: Each Entry now stores a Mood (Happy, Sad, Inspired, etc.). This provides emotional context
//    and encourages reflection beyond the typical prompt+response. Implemented in Entry.cs and used in Program.cs.
// 2) Daily Inspirational Quote: A random quote is shown at startup and also attached to each new entry. Implemented
//    in QuoteGenerator.cs and used when creating new entries.
// 3) JSON Save/Load: In addition to the required text save/load, this version supports JSON save/load (FileManager.cs)
//    so the journal can be imported/exported as structured data (extra credit idea from the specification).
// 
// These items are unique to this submission by Nsikak Eyo and are documented here as required.

using System;

class Program
{
    static void Main(string[] args)
    {
        var promptGenerator = new PromptGenerator();
        var quoteGenerator = new QuoteGenerator();
        var theJournal = new Journal();
        var fileManager = new FileManager();

        // Show personalized header & daily inspiration
        Console.WriteLine("===============================================");
        Console.WriteLine(" Welcome to Nsikak Eyo's Personal Journal App");
        Console.WriteLine("===============================================");
        Console.WriteLine($"💡 Today's Inspiration: \"{quoteGenerator.GetRandomQuote()}\"\n");

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a text file");
            Console.WriteLine("4. Load the journal from a text file");
            Console.WriteLine("5. Save the journal to JSON (extra)");
            Console.WriteLine("6. Load the journal from JSON (extra)");
            Console.WriteLine("7. Add a custom prompt");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option (1-8): ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Create a new entry
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine() ?? "";

                    // Mood tracker
                    Console.WriteLine("\nSelect your mood:");
                    Console.WriteLine("1. 😊 Happy   2. 😔 Sad   3. 😤 Stressed");
                    Console.WriteLine("4. 😴 Tired   5. 😎 Excited   6. 😐 Neutral");
                    Console.Write("Enter a number (1-6): ");
                    string moodChoice = Console.ReadLine() ?? "";
                    string mood = moodChoice switch
                    {
                        "1" => "Happy",
                        "2" => "Sad",
                        "3" => "Stressed",
                        "4" => "Tired",
                        "5" => "Excited",
                        _ => "Neutral"
                    };

                    string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                    string quote = quoteGenerator.GetRandomQuote(); // attach a quote to this entry

                    var anEntry = new Entry(date, prompt, response, mood, quote);
                    theJournal.AddEntry(anEntry);
                    Console.WriteLine("\n✅ Entry added.");
                    break;

                case "2":
                    theJournal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter filename to save (e.g., myjournal.txt): ");
                    string saveFilename = Console.ReadLine() ?? "";
                    try
                    {
                        fileManager.SaveToTextFile(theJournal, saveFilename);
                        Console.WriteLine($"✅ Journal saved to {saveFilename}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error saving file: {ex.Message}");
                    }
                    break;

                case "4":
                    Console.Write("Enter filename to load (e.g., myjournal.txt): ");
                    string loadFilename = Console.ReadLine() ?? "";
                    try
                    {
                        theJournal = fileManager.LoadFromTextFile(loadFilename);
                        Console.WriteLine($"📂 Journal loaded from {loadFilename}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading file: {ex.Message}");
                    }
                    break;

                case "5":
                    Console.Write("Enter filename to save as JSON (e.g., myjournal.json): ");
                    string jsonSave = Console.ReadLine() ?? "";
                    try
                    {
                        fileManager.SaveToJsonFile(theJournal, jsonSave);
                        Console.WriteLine($"✅ Journal saved to JSON file {jsonSave}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error saving JSON file: {ex.Message}");
                    }
                    break;

                case "6":
                    Console.Write("Enter filename to load JSON (e.g., myjournal.json): ");
                    string jsonLoad = Console.ReadLine() ?? "";
                    try
                    {
                        theJournal = fileManager.LoadFromJsonFile(jsonLoad);
                        Console.WriteLine($"📂 Journal loaded from JSON file {jsonLoad}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading JSON file: {ex.Message}");
                    }
                    break;

                case "7":
                    Console.Write("Enter a new custom prompt to add: ");
                    string newPrompt = Console.ReadLine() ?? "";
                    if (!string.IsNullOrWhiteSpace(newPrompt))
                    {
                        promptGenerator.AddPrompt(newPrompt);
                        Console.WriteLine("✅ Prompt added.");
                    }
                    else
                    {
                        Console.WriteLine("No prompt entered; nothing added.");
                    }
                    break;

                case "8":
                    quit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select 1-8.");
                    break;
            }
        }

        Console.WriteLine("Goodbye — keep journaling! ✍️");
    }
}
