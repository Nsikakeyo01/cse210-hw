using System;

public class ListingActivity : Activity
{
    private string[] _prompts = {
        "List people you are grateful for.",
        "List personal strengths you possess.",
        "List things that made you happy recently.",
        "List small wins from this week."
    };

    public ListingActivity() : base(
        "Listing",
        "Reflect on the positive aspects of your life by listing items in response to prompts.")
    { }

    public override void Start()
    {
        DisplayStartingMessage();
        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Length)];
        Console.WriteLine($"\n📝 {prompt}");
        Console.WriteLine("Start listing items (press Enter after each):");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entry))
                count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        DisplayEndingMessage();
    }
}
