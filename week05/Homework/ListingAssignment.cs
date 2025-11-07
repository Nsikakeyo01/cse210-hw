using System;

public class ListingAssignment : MindfulAssignment
{
    private string[] _prompts = {
        "List people who inspire you.",
        "List personal strengths you appreciate.",
        "List recent things that made you happy."
    };

    public ListingAssignment(string studentName, int duration)
        : base(studentName, "Listing Exercise", duration)
    { }

    public override void StartAssignment()
    {
        Console.WriteLine(GetSummary());
        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Length)];
        Console.WriteLine($"\n📝 Prompt: {prompt}");
        AnimatePause(2);

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

        Console.WriteLine($"\n🎉 You listed {count} items! Great work!");
        AnimatePause(2);
    }
}
